
create table TaiKhoan
(
	Tendangnhap nvarchar(50) NOT NULL,
	HoTen nvarchar(50) NOT NULL,
	Matkhau nvarchar(50) NOT NULL,
	Quyen nvarchar(50) NOT NULL,
)
SELECT*FROM HocPhan
select*from PhieuDangKyHocPhan

DELETE PhieuDangKyHocPhan WHERE MSSV='SV001';