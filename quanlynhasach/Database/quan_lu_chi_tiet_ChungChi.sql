--XEM CHI TIET CHUNG CHI
go
CREATE VIEW chitietchungchi AS
SELECT TenDSLopChungChi,HocKy,Nam,LopChungChi.MaHocPhanCC,TenHocPhanCC,TenLopChungChi,SiSo,SiSoToiDa,HoTenGV
FROM ((LopChungChi join HocPhanChungChi on LopChungChi.MaHocPhanCC = HocPhanChungChi.MaHocPhanCC) join GiangVien on LopChungChi.MaGiangVien = GiangVien.MaGiangVien) join DanhSachLopChungChi on LopChungChi.MaDSLopChungChi = DanhSachLopChungChi.MaDSLopChungChi;

--SELECT*FROM chitietchungchi;
--==THEM = 
create proc Them_lopchungchi
(
	@MaLopChungChi nvarchar(10),
	@MaDSLopChungChi nvarchar(10),
	@MaGiangVien nvarchar(8),
	@MaHocPhanCC nvarchar(10),
	@TenLopChungChi nvarchar(50),
	@SiSo int,
	@SiSoToiDa int
)
as
begin
	insert into LopChungChi values(@MaLopChungChi,@MaDSLopChungChi,@MaGiangVien,@MaHocPhanCC,@TenLopChungChi,@SiSo,@SiSoToiDa);
end;
--exec Them_lopchungchi 'LP002','DS001','GV001','AV001','17_2',0,6;
--==UPDATE
create proc capnhat_lopchungchi
(
	@MaLopChungChi nvarchar(10),
	@MaDSLopChungChi nvarchar(10),
	@MaGiangVien nvarchar(8),
	@MaHocPhanCC nvarchar(10),
	@TenLopChungChi nvarchar(50),
	@SiSo int,
	@SiSoToiDa int
)
as
begin
	UPDATE LopChungChi SET MaDSLopChungChi =@MaDSLopChungChi WHERE MaLopChungChi = @MaLopChungChi;
	UPDATE LopChungChi SET MaGiangVien =@MaGiangVien WHERE MaLopChungChi = @MaLopChungChi;
	UPDATE LopChungChi SET MaHocPhanCC =@MaHocPhanCC WHERE MaLopChungChi = @MaLopChungChi;
	UPDATE LopChungChi SET TenLopChungChi =@TenLopChungChi WHERE MaLopChungChi = @MaLopChungChi;
	UPDATE LopChungChi SET SiSo =@SiSo WHERE MaLopChungChi = @MaLopChungChi;
	UPDATE LopChungChi SET SiSoToiDa =@SiSoToiDa WHERE MaLopChungChi = @MaLopChungChi;
end;
--==DELETE
create proc xoa_lopchungchi
(
	@MaLopChungChi nvarchar(10)
)
as
begin
	delete LopChungChi where MaLopChungChi = @MaLopChungChi;
end

--THEM/SUA/XOA BANG HOCPHANCHUNGCHI
create proc them_hpchungchi
(
	@MaHocPhanCC nvarchar(10),
	@TenHocPhanCC nvarchar(50),
	@MaDS nvarchar(10)
)
as
begin
	insert into HocPhanChungChi values(@MaHocPhanCC,@TenHocPhanCC,@MaDS);
end;
--==Sua
create proc sua_hpchungchi
(
	@MaHocPhanCC nvarchar(10),
	@TenHocPhanCC nvarchar(50),
	@MaDS nvarchar(10)
)
as
begin
	UPDATE HocPhanChungChi SET TenHocPhanCC = @TenHocPhanCC WHERE MaHocPhanCC = @MaHocPhanCC;
	UPDATE HocPhanChungChi SET MaDS = @MaDS WHERE MaHocPhanCC=@MaHocPhanCC;
end;
--==Xoa_hpchungchi
create proc xoa_hpchungchi
(
	@MaHocPhanCC nvarchar(10)

)
as
begin
	DELETE HocPhanChungChi WHERE MaHocPhanCC = @MaHocPhanCC;
end;
--THEM/SUA DANHSACHLOPCHUNGCHI
--==THEM
create proc them_dslopchungchi
(
	@MaDSLopChungChi nvarchar(10),
	@HocKy int,
	@Nam char(5),
	@MaLoaiCC nvarchar(10),
	@TenDSLopChungChi nvarchar(50)

)
as
begin
	insert into DanhSachLopChungChi values(@MaDSLopChungChi,@HocKy,@Nam,@MaLoaiCC,@TenDSLopChungChi,GETDATE());
end;
--SUA
create proc sua_dslopchungchi
(
	@MaDSLopChungChi nvarchar(10),
	@HocKy int,
	@Nam char(5),
	@MaLoaiCC nvarchar(10),
	@TenDSLopChungChi nvarchar(50)

)
as
begin
	UPDATE DanhSachLopChungChi SET HocKy = @HocKy WHERE MaDSLopChungChi=@MaDSLopChungChi;
	UPDATE DanhSachLopChungChi SET Nam = @Nam WHERE MaDSLopChungChi=@MaDSLopChungChi;
	UPDATE DanhSachLopChungChi SET MaLoaiCC =@MaLoaiCC WHERE MaDSLopChungChi=@MaDSLopChungChi;
	UPDATE DanhSachLopChungChi SET TenDSLopChungChi = @TenDSLopChungChi WHERE MaDSLopChungChi=@MaDSLopChungChi;

end;