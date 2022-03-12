﻿CREATE TABLE TaiKhoan
(
	Tendangnhap nvarchar(50),
	Hoten nvarchar(50),
	Matkhau nvarchar(50),
	Quyen nvarchar(50)
)
---TAIKHOAN
insert into TaiKhoan VALUES('SV001','LINH','1234','SinhVien');
insert into TaiKhoan VALUES('SV002','LINH','1234','SinhVien');
insert into TaiKhoan VALUES('GV001','LINH','1234','GiangVien');
insert into TaiKhoan VALUES('GV002','LINH','1234','GiangVien');

---HOCPHAN
SELECT*FROM LopHocPhan;
INSERT INTO LopHocPhan VALUES('LP001','18_1',0,20,'GV001','HP001','DSL001');
INSERT INTO LopHocPhan VALUES('LP002','18_1',0,20,'GV001','HP002','DSL001');
INSERT INTO LopHocPhan VALUES('LP003','18_1',0,20,'GV001','HP003','DSL001');
INSERT INTO LopHocPhan VALUES('LP004','18_1',0,20,'GV001','HP004','DSL001');
INSERT INTO LopHocPhan VALUES('LP005','18_1',0,20,'GV001','HP005','DSL001');

SELECT*FROM GiangVien;
INSERT INTO GiangVien VALUES('GV001','Linh',N'Hồ Chí Minh','0923456765');
INSERT INTO GiangVien VALUES('GV002','Linh',N'Hồ Chí Minh','0923456762');
select*from HocPhan
INSERT INTO HocPhan VALUES('HP001','Co So Du Lieu','DS001');
INSERT INTO HocPhan VALUES('HP002','Thiet ke phan mem','DS001');
INSERT INTO HocPhan VALUES('HP003','Thiet ke phan mem','DS001');
INSERT INTO HocPhan VALUES('HP004','Mang may tinh','DS001');
INSERT INTO HocPhan VALUES('HP005','IOT','DS001');

select*from DanhSachHocPhan;
INSERT INTO DanhSachHocPhan VALUES('DS001',1,'20-21','Hoc ki I/20-21',GetDate());
select*from DanhSachLopHocPhan
INSERT INTO DanhSachLopHocPhan VALUES ('DSL001',1,'20-21','ABC',GETDATE());
SELECT*FROM SinhVien
INSERT INTO SinhVien VALUES('SV001','LINH','HO CHI MINH','0923945697','HTTT','SINH VIEN');
INSERT INTO SinhVien VALUES('SV002','LINH','HO CHI MINH','0923945692','HTTT','SINH VIEN');

SELECT*FROM PhieuDangKyHocPhan
INSERT INTO PhieuDangKyHocPhan VALUES('PDK001','SV001',1,'20-21',GETDATE(),'DA DANG KI','HP001');

----CHUYEN DE----
SELECT*FROM LopChuyenDe
INSERT INTO LopChuyenDe VALUES ('LCD001','18CQ/1',0,20,'DSL001','NCD001','GV001');
INSERT INTO LopChuyenDe VALUES ('LCD002','18CQ/2',0,20,'DSL001','NCD002','GV002');
INSERT INTO LopChuyenDe VALUES ('LCD003','18CQ/3',0,20,'DSL001','NCD003','GV001');
INSERT INTO LopChuyenDe VALUES ('LCD004','18CQ/4',0,20,'DSL001','NCD004','GV002');
INSERT INTO LopChuyenDe VALUES ('LCD005','18CQ/5',0,20,'DSL001','NCD005','GV001');

SELECT*FROM NhomChuyenDe
INSERT INTO NhomChuyenDe VALUES ('NCD001',N'An Toàn Thông Tin 4.0','DSN001');
INSERT INTO NhomChuyenDe VALUES ('NCD002',N'Thiết Kế Thông Tin 4.0','DSN001');
INSERT INTO NhomChuyenDe VALUES ('NCD003',N'IOT 4.0','DSN001');
INSERT INTO NhomChuyenDe VALUES ('NCD004',N'BA 4.0','DSN001');
INSERT INTO NhomChuyenDe VALUES ('NCD005',N'FE 4.0','DSN001');

select*from DSLopNhomChuyenDe
INSERT INTO DSLopNhomChuyenDe VALUES('DSN001',1,'20-21','KI I/20-21',GETDATE());

SELECT*FROM DSLopChuyenDe
INSERT INTO DSLopChuyenDe VALUES('DSL001',1,'20-21','HOCKI 1/2020',GETDATE());

--CHUNG CHI---
select*from PhieuDangKyHPChungChi
select*from LopChungChi

