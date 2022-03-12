				/*-----------------------------------DANG KY HOC PHAN-----------------------------*/
	
	drop proc dangkylophocphan;
go
alter proc dangkylophocphan
(
	@MSSV nvarchar(8),
	@MaLopHP nvarchar(10)
)
as
begin

	declare @p_mamonhoc nvarchar(10)
	declare @p_mabangdiem nvarchar(10)
	declare @TenHocPhan nvarchar(50)
	declare @p_Hocky int
	declare @p_Namhoc char(5)

	---thiet lap mac dinh
	select @p_mamonhoc = MaHocPhan from LopHocPhan where MaLopHP = @MaLopHP
	select @TenHocPhan= TenHocPhan from LopHocPhan join HocPhan on LopHocPhan.MaHocPhan = HocPhan.MaHocPhan where MaLopHP=@MaLopHP 
	set @p_mabangdiem = convert(nvarchar,(RAND()*(999999-100000+1)+100000))
	set @p_Hocky= (select HocKy from DanhSachLopHocPhan join LopHocPhan on DanhSachLopHocPhan.MaDSLop=LopHocPhan.MaDSLop where LopHocPhan.MaLopHP=@MaLopHP)
	set @p_Namhoc= (select Nam from DanhSachLopHocPhan join LopHocPhan on DanhSachLopHocPhan.MaDSLop=LopHocPhan.MaDSLop where LopHocPhan.MaLopHP=@MaLopHP)

	---Tăng si số trong Bảng LopHocPhan
	declare @siso int
	declare @sisomax int
	set @sisomax = (select SiSoToiDa from LopHocPhan where MaLopHP=@MaLopHP)
	set @siso = (select SiSo from LopHocPhan where MaLopHP=@MaLopHP)
	if(@siso < @sisomax)
	begin
		---insert tinh trang =  da dang ky
		declare @MaPhieuDKHP nvarchar(10)
		set @MaPhieuDKHP = convert(nvarchar,(RAND()*(999999-100000+1)+100000))
		declare @NgayDK date
		set @NgayDK = GETDATE()
		declare @TinhTrang nvarchar(50)
		set @TinhTrang = N'Đã Đăng Ký'
		IF NOT EXISTS(SELECT * FROM PhieuDangKyHocPhan WHERE MSSV=@MSSV and MaHocPhan=@p_mamonhoc)
		begin
		insert into PhieuDangKyHocPhan(MaPhieuDKHP,MSSV,HocKy,NamHoc,NgayDK,TinhTrang,MaHocPhan,MaLopHP)
		values(@MaPhieuDKHP,@MSSV,@p_Hocky,@p_Namhoc,@NgayDK,@TinhTrang,@p_mamonhoc,@MaLopHP)
		end
		else
		begin
			raiserror(N' Đã đăng ký trùng!!Cảnh báo',16,1)
		end
		select*from PhieuDangKyHocPhan
		--insert hoc phan vao bang diem
		IF NOT EXISTS(SELECT * FROM BangDiem_HocPhan WHERE MSSV = @MSSV and MaLopHP=@MaLopHP)
		begin
		insert into BangDiem_HocPhan(MaBangDiem,MSSV,TenHocPhan,HocKy,NamHoc,MaLopHP,Diem,NgayDang)
		values (@p_mabangdiem,@MSSV,@TenHocPhan,@p_Hocky,@p_Namhoc,@MaLopHP,NULL,GETDATE()) 
		end
		else
		begin
			return 0;
		end
		---update SiSo trong bảng LopHocPhan
		if exists(select * from PhieuDangKyHocPhan where TinhTrang=@TinhTrang and MSSV=@MSSV)
		begin
		update LopHocPhan set SiSo = @siso + 1 where MaLopHP=@MaLopHP
		end
		else
		begin
			return 0;
		end

		end
	else
	begin
		raiserror(N'Lớp học phần này đã đầy',16,1)
	end
	---kiem tra thuc thi cau lenh
	if @@ROWCOUNT >0 return 1
end
go
/*exec dangkylophocphan 'SV004','LP002'
select * from BangDiem_HocPhan
select * from PhieuDangKyHocPhan
select*from LopHocPhan
delete BangDiem_HocPhan
delete PhieuDangKyHocPhan
update LopHocPhan set SiSo =0*/
select*from DanhSachLopHocPhan;
				/*-------------------------------DANG KY CHUYEN DE-----------------------------*/
go
drop proc dangkychuyende
go
create proc dangkychuyende
(
	@MSSV nvarchar(8),
	@MaLopCD nvarchar(10)
)
as
begin
	declare @MaPhieuDKCD nvarchar(10)
	set @MaPhieuDKCD = convert(nvarchar,(RAND()*(999999-100000+1)+100000))
	declare @p_Hocky int
	declare @p_Namhoc char(5)
	declare @NgayDangKy date
	declare @TinhTrang nvarchar(50)
	declare @MaNhomCD nvarchar(10)
	declare @MaBangDiem nvarchar(10)
	set @MaBangDiem= convert(nvarchar,(RAND()*(999999-100000+1)+100000))
	declare @TenChuyenDe nvarchar(50)


	----thiet lap bien mac dinh
	set @p_Hocky= (select HocKy from DSLopChuyenDe join LopChuyenDe on DSLopChuyenDe.MaDS=LopChuyenDe.MaDS WHERE MaLopCD = @MaLopCD)
	set @p_Namhoc= (select Nam from DSLopChuyenDe join LopChuyenDe on DSLopChuyenDe.MaDS=LopChuyenDe.MaDS WHERE MaLopCD = @MaLopCD)
	set @NgayDangKy = GETDATE()
	set @TinhTrang = N'Đã Đăng Ký'
	set @MaNhomCD = (select MaNhomCD from LopChuyenDe where MaLopCD=@MaLopCD)
	set @TenChuyenDe = (select TenNhomCD from NhomChuyenDe join LopChuyenDe on NhomChuyenDe.MaNhomCD = LopChuyenDe.MaNhomCD where MaLopCD = @MaLopCD)

	---Tăng si số trong Bảng LopHocPhan
	declare @siso int
	declare @sisomax int
	set @sisomax = (select SiSoMax from LopChuyenDe where MaLopCD=@MaLopCD)
	set @siso = (select SiSo from LopChuyenDe where MaLopCD=@MaLopCD)
	if(@siso < @sisomax)
	begin
		--insert PhieuDangKyChuyenDe---
		if not exists(select * from PhieuDangKyCD where MSSV = @MSSV and MaLopCD=@MaLopCD)
		begin
		insert into PhieuDangKyCD(MaPhieuDKCD,HocKy,NamHoc,NgayDangKy,TinhTrang,MSSV,MaNhomCD,MaLopCD)
		values(@MaPhieuDKCD,@p_Hocky,@p_Namhoc,@NgayDangKy,@TinhTrang,@MSSV,@MaNhomCD,@MaLopCD)
		end
		else
		begin
			raiserror(N'Đã đăng ký!',16,1)
		end

		---insert BangDiem_ChuyenDe---
		if not exists(select * from BangDiem_ChuyenDe where MSSV = @MSSV and MaLopCD=@MaLopCD)
		begin
		insert into BangDiem_ChuyenDe(MaBangDiem,MSSV,TenHocPhan,HocKy,NamHoc,MaLopCD,Diem,NgayDang)
		values(@MaBangDiem,@MSSV,@TenChuyenDe,@p_Hocky,@p_Namhoc,@MaLopCD,NULL,GetDate())
		end
		else
		begin
			return 0;
		end
		---Update SiSo trong bảng LopChuyenDe
		if exists(select * from PhieuDangKyCD where TinhTrang=@TinhTrang and MSSV=@MSSV)
		begin
		update LopChuyenDe set SiSo = SiSo + 1 where LopChuyenDe.MaLopCD=@MaLopCD 
		end
		else
		begin
			return 0;
		end
	end
	else
	begin
		raiserror(N'Lớp chuyên đề này đã đầy',16,1)
	end
	---kiem tra thuc thi cau lenh
	if @@ROWCOUNT >0 return 1
end
/*exec dangkychuyende 'SV001','LCD001'

select * from PhieuDangKyCD
select*from BangDiem_ChuyenDe
select*from LopChuyenDe
update LopChuyenDe set SiSo=0
delete BangDiem_ChuyenDe
delete PhieuDangKyCD*/
select*from DanhSachLopHocPhan;

/*-------------------------------Đăng ký Lớp Chứng Chỉ----------------------*/
go
alter proc dangkychungchi
(
	@MSSV nvarchar(8),
	@MaLoaiCC nvarchar(10),
	@MaLopChungChi nvarchar(10)
)
as
begin
	---thiết lập mặc định---
	declare @MaPhieuDK nvarchar(10)
	set @MaPhieuDK = convert(nvarchar,(RAND()*(999999-100000+1)+100000))
	declare @MaHocPhanCC nvarchar(10)
	set @MaHocPhanCC = (select MaHocPhanCC from LopChungChi where MaLopChungChi=@MaLopChungChi)
	declare @HocKy int
	set @HocKy = ( select HocKy from DanhSachLopChungChi join LopChungChi on DanhSachLopChungChi.MaDSLopChungChi=LopChungChi.MaDSLopChungChi 
																		where LopChungChi.MaLopChungChi=@MaLopChungChi)

	declare @Nam nchar(5)
	set @Nam = ( select Nam from DanhSachLopChungChi join LopChungChi on DanhSachLopChungChi.MaDSLopChungChi=LopChungChi.MaDSLopChungChi 
																		where LopChungChi.MaLopChungChi=@MaLopChungChi)
	declare @NgayDK date
	set @NgayDK = GETDATE()
	declare @TinhTrang nvarchar(20)
	set @TinhTrang = N'Đã Đăng Ký'

	declare @MaBangDiem nvarchar(10)
	set @MaBangDiem = convert(nvarchar,(RAND()*(999999-100000+1)+100000))
	declare @TenHocPhan nvarchar(50)
	set @TenHocPhan = (select TenHocPhanCC from HocPhanChungChi join LopChungChi on HocPhanChungChi.MaHocPhanCC=LopChungChi.MaHocPhanCC where MaLopChungChi=@MaLopChungChi)
	declare @Diem float
	set @Diem = NULL
	---Kiểm tra SiSo trong LopChungChi
	declare @SiSo int
	set @SiSo = (select SiSo from LopChungChi where MaLopChungChi=@MaLopChungChi)
	declare @SiSoToiDa int
	set @SiSoToiDa = (select SiSoToiDa from LopChungChi where MaLopChungChi=@MaLopChungChi)
	---
	if(@SiSo<@SiSoToiDa)
	begin
		----insert PhieuDangKiHPChungChi---
		if not exists(select * from PhieuDangKyHPChungChi where MaHocPhanCC=@MaHocPhanCC and MSSV=@MSSV)
		begin
		insert into PhieuDangKyHPChungChi(MaPhieuDK,MSSV,MaHocPhanCC,MaLoaiCC,HocKy,Nam,NgayDK,TinhTrang,MaLopChungChi)
		values(@MaPhieuDK,@MSSV,@MaHocPhanCC,@MaLoaiCC,@HocKy,@Nam,@NgayDK,@TinhTrang,@MaLopChungChi)
		end
		else
		begin
			raiserror(N'Đăng ký trùng!Cảnh báo',16,1)
		end

		---insert BangDiem_ChungChi
		if not exists(select * from BangDiem_ChungChi where MaLopChungChi=@MaLopChungChi and MSSV=@MSSV)
		begin
		insert into BangDiem_ChungChi(MaBangDiem,MSSV,MaHocPhanCC,TenHocPhan,HocKy,NamHoc,MaLopChungChi,MaLoaiCC,Diem,NgayDang)
		values(@MaBangDiem,@MSSV,@MaHocPhanCC,@TenHocPhan,@HocKy,@Nam,@MaLopChungChi,@MaLoaiCC,@Diem,GetDate())
		end
		else
		begin
			return 0;
		end
		----update SiSo trong bang LopChungChi---
		update LopChungChi set SiSo = SiSo + 1 where MaLopChungChi=@MaLopChungChi

	end
	else
	begin
		RAISERROR (N'Lớp chứng chỉ đã đầy',16,1);
	end
	---kiem tra thuc thi cau lenh
	if @@ROWCOUNT >0 return 1
end

/*exec dangkychungchi 'SV001','LCC001','LP001'
select * from BangDiem_ChungChi
select * from PhieuDangKyHPChungChi
select*from LopChungChi
delete BangDiem_ChungChi
delete PhieuDangKyHPChungChi
update LopChungChi set SiSo=0
select * from DanhSachLopChungChi where Nam = '18-19'*/


/*select * from BangDiem_ChungChi
select * from PhieuDangKyHPChungChi
select * from LopChungChi
select * from HocPhanChungChi
select*from DanhSachHocPhanChungChi
select* from DanhSachLopChungChi*/


----------------------------------------------

