ALTER proc HuyDKHocPhan
(
	@MaPhieuDKHP nvarchar(10)
)
as
begin
	DELETE PhieuDangKyHocPhan WHERE MaPhieuDKHP = @MaPhieuDKHP;

end
go

alter trigger CapNhatSiSo_LopHocPhan
on PhieuDangKyHocPhan
AFTER DELETE
as
begin
	UPDATE LopHocPhan SET SiSo = SiSo-1 FROM LopHocPhan JOIN deleted ON LopHocPhan.MaHocPhan= deleted.MaHocPhan;
	DELETE BangDiem_HocPhan FROM BangDiem_HocPhan JOIN deleted ON BangDiem_HocPhan.MaLopHP=deleted.MaLopHP WHERE BangDiem_HocPhan.MSSV=deleted.MSSV;
	DELETE LichThi_HocPhan FROM deleted join LichThi_HocPhan on LichThi_HocPhan.MaHocPhan=deleted.MaHocPhan WHERE LichThi_HocPhan.MSSV = deleted.MSSV;
	

end

go
create trigger INSERT_LopHocPhan
on PhieuDangKyHocPhan
AFTER INSERT
as
begin
	declare @MSSV nvarchar(8)
	declare @MaLichThi nvarchar(10)
	declare @MaHocPhan nvarchar(10)
	declare @MaLopHP nvarchar(10)
	declare @NamHoc char(5)
	declare @HocKy int
	declare @STT int
	set @STT = @STT+1;
	set @MaHocPhan = (select MaHocPhan from inserted)
	set @MaLopHP = (select MaLopHP from inserted)
	set @NamHoc = (select inserted.NamHoc from inserted)
	set @HocKy = (select HocKy from inserted)
	set @MaLichThi = convert(nvarchar,(RAND()*(999999-100000+1)+100000));
	set @MSSV = (select MSSV from inserted)

	INSERT INTO LichThi_HocPhan values(@MaLichThi,@MSSV,@MaHocPhan,@MaLopHP,NULL,NULL,NULL,@STT,NULL,@NamHoc,@HocKy,NULL);
end

go


----------------------
SELECT*FROM LopHocPhan
UPDATE LopHocPhan SET SiSo=0
SELECT*FROM BangDiem_HocPhan
select*from LichThi_HocPhan

--================CHUYEN DE=================
go
create proc HuyDKChuyenDe
(
	@MaPhieuDKCD nvarchar(10)
)
as
begin
	DELETE PhieuDangKyCD WHERE MaPhieuDKCD = @MaPhieuDKCD;
end

go
alter trigger trg_delete_PhieuDangKyCD
on PhieuDangKyCD
AFTER DELETE
as
begin
	UPDATE LopChuyenDe SET SiSo = SiSo-1 FROM LopChuyenDe JOIN deleted ON LopChuyenDe.MaNhomCD= deleted.MaNhomCD;
	DELETE BangDiem_ChuyenDe FROM BangDiem_ChuyenDe JOIN deleted ON BangDiem_ChuyenDe.MaLopCD=deleted.MaLopCD;
	DELETE LichThi_ChuyenDe FROM LichThi_ChuyenDe JOIN deleted ON LichThi_ChuyenDe.MaNhomCD = deleted.MaNhomCD;
end
SELECT*FROM LichThi_HocPhan
go
alter trigger INSERT_PhieuDangKyCD
on PhieuDangKyCD
AFTER INSERT
as
begin
	declare @MSSV nvarchar(8)
	declare @MaLichThi nvarchar(10)
	declare @MaNhomCD nvarchar(10)
	declare @MaLopCD nvarchar(10)
	declare @NamHoc char(5)
	declare @HocKy int
	declare @STT int
	set @MSSV = (select MSSV from inserted)
	set @STT = @STT+1;
	set @MaNhomCD = (select MaNhomCD from inserted)
	set @MaLopCD = (select MaLopCD from inserted)
	set @NamHoc = (select inserted.NamHoc from inserted)
	set @HocKy = (select HocKy from inserted)
	set @MaLichThi = convert(nvarchar,(RAND()*(999999-100000+1)+100000));

	INSERT INTO LichThi_ChuyenDe values(@MaLichThi,@MSSV,@MaNhomCD,@MaLopCD,NULL,NULL,NULL,@STT,NULL,@NamHoc,@HocKy,NULL) 
end

--===========CHUNG CHI==================================
go
alter proc HuyDKChungChi
(
	@MaPhieuDKCC nvarchar(10)
)
as
begin
	DELETE PhieuDangKyHPChungChi WHERE MaPhieuDK = @MaPhieuDKCC;
end;
go
CREATE trigger trg_del_PhieuDKHPCC
on PhieuDangKyHPChungChi
AFTER DELETE
as
begin
	UPDATE LopChungChi SET SiSo = SiSo-1 FROM LopChungChi JOIN deleted ON LopChungChi.MaLopChungChi= deleted.MaLopChungChi;
	DELETE BangDiem_ChungChi FROM BangDiem_ChungChi JOIN deleted ON BangDiem_ChungChi.MaHocPhanCC = deleted.MaHocPhanCC WHERE BangDiem_ChungChi.MSSV = deleted.MSSV;
	DELETE LichThi_ChungChi FROM LichThi_ChungChi JOIN deleted ON LichThi_ChungChi.MaHocPhanCC = deleted.MaHocPhanCC WHERE LichThi_ChungChi.MSSV = deleted.MSSV;
end
go
create trigger INSERT_PhieuDangKyHPCC
on PhieuDangKyHPChungChi
AFTER INSERT
as
begin
	declare @MaLoaiCC nvarchar(10)
	declare @MSSV nvarchar(8)
	declare @MaLichThi nvarchar(10)
	declare @MaHocPhanCC nvarchar(10)
	declare @MaLopChungChi nvarchar(10)
	declare @NamHoc char(5)
	declare @HocKy int
	declare @STT int
	set @MaLoaiCC = (select MaLoaiCC from inserted)
	set @MSSV = (select MSSV from inserted)
	set @STT = @STT+1;
	set @MaHocPhanCC = (select MaHocPhanCC from inserted)
	set @MaLopChungChi = (select MaLopChungChi from inserted)
	set @NamHoc = (select inserted.Nam from inserted)
	set @HocKy = (select HocKy from inserted)
	set @MaLichThi = convert(nvarchar,(RAND()*(999999-100000+1)+100000));

	INSERT INTO LichThi_ChungChi values(@MaLichThi,@MSSV,@MaHocPhanCC,@MaLopChungChi,@MaLoaiCC,NULL,NULL,NULL,@STT,NULL,@NamHoc,@HocKy,NULL);
end
-----------------------------------------------
select*from BangDiem_HocPhan
select*from BangDiem_ChuyenDe
select*from BangDiem_ChungChi


------------------TRUY CUU HOC PHI ----------------------------

---HOC PHI HOC PHAN----
select*from HocPhi_HocPhan
SELECT*FROM PhieuDangKyHocPhan