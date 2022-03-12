use master
go
create database QLHocPhan
go
use QLHocPhan
go
-------------------------
create table GiangVien
(
	MaGiangVien  nvarchar(8) NOT NULL,
	HoTenGV nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NOT NULL,
	SDT char(10) NOT NULL UNIQUE,
	primary key(MaGiangVien)
)
go
create table SinhVien
(
	MSSV nvarchar(8) NOT NULL,
	HoTenHS nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NOT NULL,
	SDT char(10) NOT NULL UNIQUE,
	Khoa nvarchar(50) NOT NULL,
	TinhTrang nvarchar(20) NOT NULL,
	primary key(MSSV)
)
-----Chuyen De---------------
create table DSLopChuyenDe
(
	MaDS nvarchar(10) NOT NULL,
	HocKy int NOT NULL,
	Nam char(5) NOT NULL,
	TenDSLopChuyenDe nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDS)
)
create table DSLopNhomChuyenDe
(
	MaDSNhom nvarchar(10) NOT NULL,
	HocKy int NOT NULL,
	Nam char(5) NOT NULL,
	TenDSNhom nvarchar(50) NOT NULL,
	NgayDang Date,
	primary key(MaDSNhom)
)
create table NhomChuyenDe
(
	MaNhomCD nvarchar(10) NOT NULL,
	TenNhomCD nvarchar(50)NOT NULL,
	MaDSNhom nvarchar(10)NOT NULL,
	primary key(MaNhomCD)
)
ALTER TABLE NhomChuyenDe ADD CONSTRAINT fk_NCD_DSLNCD FOREIGN KEY (MaDSNhom) REFERENCES DSLopNhomChuyenDe (MaDSNhom)

create table LopChuyenDe
(
	MaLopCD nvarchar(10) NOT NULL,
	TenLop nvarchar(50) NOT NULL,
	SiSo int NOT NULL,
	SiSoMax int NOT NULL,
	MaDS nvarchar(10)NOT NULL,
	MaNhomCD nvarchar(10)NOT NULL,
	MaGiangVien nvarchar(8)NOT NULL,
	primary key(MaLopCD)
)

ALTER TABLE LopChuyenDe ADD CONSTRAINT fk_LCD_DSLNCD FOREIGN KEY (MaDS) REFERENCES DSLopChuyenDe (MaDS)
ALTER TABLE LopChuyenDe ADD CONSTRAINT fk_LCD_NCD FOREIGN KEY (MaNhomCD) REFERENCES NhomChuyenDe (MaNhomCD)
ALTER TABLE  LopChuyenDe ADD CONSTRAINT fk_LCD_GV FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)

create table PhieuDangKyCD
(
	MaPhieuDKCD nvarchar(10) NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	NgayDangKy date NOT NULL,
	TinhTrang nvarchar(50) NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	MaNhomCD nvarchar(10)NOT NULL,
	MaLopCD nvarchar(10) NOT NULL,
	primary key(MaPhieuDKCD)

)
ALTER TABLE PhieuDangKyCD ADD  CONSTRAINT fk_PDKCD_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE PhieuDangKyCD ADD CONSTRAINT fk_PDKCD_NCD FOREIGN KEY (MaNhomCD) REFERENCES NhomChuyenDe(MaNhomCD)
ALTER TABLE PhieuDangKyCD ADD CONSTRAINT fk_PDKCD_LCD FOREIGN KEY (MaLopCD) REFERENCES LopChuyenDe(MaLopCD)
go
create table LichThi_ChuyenDe
(
	MaLichThi nvarchar(10),
	MSSV nvarchar(8),
	MaNhomCD nvarchar(10),
	MaLopCD nvarchar(10),
	NgayThi date,
	GioThi time,
	PhongThi nvarchar(10),
	STT int,
	DiaDiem nvarchar(50),
	NamHoc char(5),
	HocKy int,
	GhiChu nvarchar(50),
	primary key(MaLichThi)
)
go
ALTER TABLE LichThi_ChuyenDe add CONSTRAINT fk_LTCD_NCD FOREIGN KEY (MaNhomCD) REFERENCES NhomChuyenDe(MaNhomCD)
ALTER TABLE LichThi_ChuyenDe add CONSTRAINT fk_LTCD_LCD FOREIGN KEY (MaLopCD) REFERENCES LopChuyenDe(MaLopCD)
ALTER TABLE LichThi_ChuyenDe add CONSTRAINT fk_LTCD_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)

--drop table LichThi_ChuyenDe
go
----Hoc Phan--------------
create table DanhSachLopHocPhan
(
	MaDSLop nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	Nam char(5) NOT NULL,
	TenDSLop nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDSLop)
)
create table DanhSachHocPhan
(
	MaDS nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	Nam char(5) NOT NULL,
	TenDanhSach nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDs)
)
go
create table HocPhan
(
	MaHocPhan nvarchar(10)NOT NULL,
	TenHocPhan nvarchar(50)NOT NULL,
	MaDS nvarchar(10)NOT NULL,
	primary key(MaHocPhan)
)
go
ALTER TABLE HocPhan ADD CONSTRAINT fk_HP_DSHP FOREIGN KEY (MaDS) REFERENCES DanhSachHocPhan(MaDS)

go
create table PhieuDangKyHocPhan
(
	MaPhieuDKHP nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	NgayDK date NOT NULL,
	TinhTrang nvarchar(50)NOT NULL,
	MaHocPhan nvarchar(10)NOT NULL,
	MaLopHP nvarchar(10) not null,
	primary key(MaPhieuDKHP)
)
DROP TABLE PhieuDangKyHocPhan
go
ALTER TABLE PhieuDangKyHocPhan ADD CONSTRAINT fk_PDKHP_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE PhieuDangKyHocPhan ADD CONSTRAINT fk_PDKHP_HP FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan)
ALTER TABLE PhieuDangKyHocPhan ADD CONSTRAINT fk_PDKHP_LHP FOREIGN KEY (MaLopHP) REFERENCES LopHocPhan(MaLopHP)


go
create table LopHocPhan
(
	MaLopHP nvarchar(10)NOT NULL,
	TenLopHP nvarchar(50)NOT NULL,
	SiSo int NOT NULL,
	SiSoToiDa int NOT NULL,
	MaGiangVien nvarchar(8)NOT NULL,
	MaHocPhan nvarchar(10)NOT NULL,
	MaDSLop nvarchar(10)NOT NULL,
	primary key(MaLopHP)
)
go
ALTER TABLE LopHocPhan ADD CONSTRAINT fk_LHP_GV FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
ALTER TABLE LopHocPhan ADD CONSTRAINT fk_LHP_hp FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan)
ALTER TABLE LopHocPhan ADD CONSTRAINT fk_LHP_DSLHP FOREIGN KEY (MaDSLop) REFERENCES DanhSachLopHocPhan(MaDSLop)

go
create table LichThi_HocPhan
(
	MaLichThi nvarchar(10),
	MSSV nvarchar(8),
	MaHocPhan nvarchar(10),
	MaLopHP nvarchar(10),
	NgayThi date,
	GioThi time,
	PhongThi nvarchar(10),
	STT int,
	DiaDiem nvarchar(50),
	NamHoc char(5),
	HocKy int,
	GhiChu nvarchar(50),
	primary key(MaLichThi)
)
go
ALTER TABLE LichThi_HocPhan add CONSTRAINT fk_LTHP_HP FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan);
ALTER TABLE LichThi_HocPhan add CONSTRAINT fk_LTHP_LHP FOREIGN KEY (MaLopHP) REFERENCES LopHocPhan(MaLopHP);
ALTER TABLE LichThi_HocPhan add CONSTRAINT fk_LTHP_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV);

--drop table LichThi_HocPhan



go
----Chuong Trinh Dao Tao-------------
create table DSChuongTrinhDaoTao
(
	MaDSCT nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	TenDSCT nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDSCT)
)
go
create table ChuongTrinhDaoTao
(
	MaCTDT nvarchar(10)NOT NULL,
	TenCTDT nvarchar(50)NOT NULL,
	MaDSCT nvarchar(10)NOT NULL,
	primary key(MaCTDT)
)
go
ALTER TABLE ChuongTrinhDaoTao ADD CONSTRAINT fk_CTDT_DSCTDT FOREIGN KEY (MaDSCT) REFERENCES DSChuongTrinhDaoTao(MaDSCT)

go
create table PhieuDangKyCTDT
(
	MaPhieuDKCT nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	MaCTDT nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	NgayDangKy date NOT NULL,
	TinhTrang nvarchar(50)NOT NULL,
	primary key(MaPhieuDKCT)
)
go
ALTER TABLE PhieuDangKyCTDT ADD CONSTRAINT fk_PDKCTDT_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE PhieuDangKyCTDT ADD CONSTRAINT fk_PDKCTDT_CTDT FOREIGN KEY (MaCTDT) REFERENCES ChuongTrinhDaoTao(MaCTDT)

go
-------Chung Chi-------------
create table LoaiChungChi
(
	MaLoaiCC nvarchar(10) NOT NULL,
	TenLoai nvarchar(30) NOT NULL,
	primary key(MaLoaiCC)
)
go
create table DanhSachHocPhanChungChi
(
	MaDS nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	Nam char(5)  NOT NULL,
	MaLoaiCC nvarchar(10) NOT NULL ,
	TenDS nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDS)
)
go
ALTER TABLE DanhSachHocPhanChungChi ADD CONSTRAINT fk_DSHPCC_LCC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)

go
create table HocPhanChungChi
(
	MaHocPhanCC nvarchar(10)NOT NULL,
	TenHocPhanCC nvarchar(50)NOT NULL,
	MaDS nvarchar(10)NOT NULL,
	primary key(MaHocPhanCC)
)
go
ALTER TABLE HocPhanChungChi ADD CONSTRAINT fk_HPCC_DSHPCC FOREIGN KEY (MaDS) REFERENCES DanhSachHocPhanChungChi(MaDS)

go
create table PhieuDangKyHPChungChi
(
	MaPhieuDK nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	MaHocPhanCC nvarchar(10)NOT NULL,
	MaLoaiCC nvarchar(10) NOT NULL ,
	HocKy int NOT NULL,
	Nam char(5) NOT NULL,
	NgayDK date NOT NULL,
	TinhTrang nvarchar(20)NOT NULL,
	MaLopChungChi nvarchar(10)NOT NULL,

	primary key(MaPhieuDK)
)
go
DROP TABLE PhieuDangKyHPChungChi
ALTER TABLE PhieuDangKyHPChungChi ADD CONSTRAINT fk_PDKHPCC_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE PhieuDangKyHPChungChi ADD  CONSTRAINT fk_PDKHPCC_HPCC FOREIGN KEY (MaHocPhanCC) REFERENCES HocPhanChungChi(MaHocPhanCC)
ALTER TABLE PhieuDangKyHPChungChi ADD CONSTRAINT fk_PDKHPCC_LCC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)
ALTER TABLE PhieuDangKyHPChungChi ADD CONSTRAINT fk_PDKHPCC_LLCC FOREIGN KEY (MaLopChungChi) REFERENCES LopChungChi(MaLopChungChi)


go
create table DanhSachLopChungChi
(
	MaDSLopChungChi nvarchar(10)NOT NULL,
	HocKy int NOT NULL,
	Nam char(5)  NOT NULL,
	MaLoaiCC nvarchar(10) NOT NULL, 
	TenDSLopChungChi nvarchar(50)NOT NULL,
	NgayDang date,
	primary key(MaDSLopChungChi)
)
go
ALTER TABLE DanhSachLopChungChi ADD CONSTRAINT fk_DSLCC_LCC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)
go
create table LopChungChi
(
	MaLopChungChi nvarchar(10)NOT NULL UNIQUE,
	MaDSLopChungChi nvarchar(10)NOT NULL,
	MaGiangVien nvarchar(8)NOT NULL,
	MaHocPhanCC nvarchar(10)NOT NULL,
	TenLopChungChi nvarchar(50)NOT NULL,
	SiSo int NOT NULL,
	SiSoToiDa int NOT NULL,
	primary key(MaLopChungChi)
)
go
ALTER TABLE LopChungChi ADD CONSTRAINT fk_LCC_GV FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
ALTER TABLE LopChungChi ADD CONSTRAINT fk_LCC_DSLCC FOREIGN KEY (MaDSLopChungChi) REFERENCES DanhSachLopChungChi(MaDSLopChungChi)
ALTER TABLE LopChungChi ADD CONSTRAINT fk_LCC_HPCC FOREIGN KEY (MaHocPhanCC) REFERENCES HocPhanChungChi(MaHocPhanCC)
go
create table LichThi_ChungChi
(
	MaLichThi nvarchar(10),
	MSSV nvarchar(8),
	MaHocPhanCC nvarchar(10),
	MaLopChungChi nvarchar(10),
	MaLoaiCC nvarchar(10),
	NgayThi date,
	GioThi time,
	PhongThi nvarchar(10),
	STT int,
	DiaDiem nvarchar(50),
	NamHoc char(5),
	HocKy int,
	GhiChu nvarchar(50),
	primary key(MaLichThi)
)
ALTER TABLE LichThi_ChungChi ADD CONSTRAINT fk_LTCC_HPCC FOREIGN KEY (MaHocPhanCC) REFERENCES HocPhanChungChi(MaHocPhanCC)
ALTER TABLE LichThi_ChungChi ADD CONSTRAINT fk_LTCC_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE LichThi_ChungChi ADD CONSTRAINT fk_LTCC_LoaiCC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)
ALTER TABLE LichThi_ChungChi ADD CONSTRAINT fk_LTCC_LOPCC FOREIGN KEY (MaLopChungChi) REFERENCES LopChungChi(MaLopChungChi)



go
--==================HOC PHI ====================================
create table HocPhi_HocPhan(
	MaHocPhi nvarchar(10) NOT NULL,
	NamHoc char(5) NOT NULL,
	HocKy int NOT NULL,	
	MSSV nvarchar(8) NOT NULL,
	MaHocPhan nvarchar(10) NOT NULL,
	MaLopHP nvarchar(10)NOT NULL,
	GiaTien money NOT NULL,
	TinhTrang nvarchar(20) NULL,
	NgayPhatHanh date NOT NULL,
	primary key(MaHocPhi)
)
go
--drop table HocPhi_HocPhan
go
ALTER TABLE HocPhi_HocPhan ADD CONSTRAINT fk_HocPhi_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE HocPhi_HocPhan ADD CONSTRAINT fk_HocPhi_LHP FOREIGN KEY (MaLopHP) REFERENCES LopHocPhan(MaLopHP)
ALTER TABLE HocPhi_HocPhan ADD CONSTRAINT fk_HocPhi_HP FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan)

go
create table HocPhi_ChuyenDe(
	MaHocPhi nvarchar(10) NOT NULL,
	MSSV nvarchar(8) NOT NULL,
	NamHoc char(5) NOT NULL,
	HocKy int NOT NULL,
	MaNhomCD nvarchar(10) NOT NULL,
	MaLopCD nvarchar(10) NOT NULL,
	GiaTien money NOT NULL,
	TinhTrang nvarchar(20) NULL,
	NgayPhatHanh date NOT NULL,
	primary key(MaHocPhi)
)
go
--DROP TABLE HocPhi_ChuyenDe
go
ALTER TABLE HocPhi_ChuyenDe ADD CONSTRAINT fk_HocPhiCD_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE HocPhi_ChuyenDe ADD CONSTRAINT fk_HocPhi_LCD FOREIGN KEY (MaLopCD) REFERENCES LopChuyenDe(MaLopCD)
ALTER TABLE HocPhi_ChuyenDe ADD CONSTRAINT fk_HocPhi_NCD FOREIGN KEY (MaNhomCD) REFERENCES NhomChuyenDe(MaNhomCD)


go
create table HocPhi_ChungChi(
	MaHocPhi nvarchar(10) NOT NULL,
	MSSV nvarchar(8) NOT NULL,
	NamHoc char(5) NOT NULL,
	HocKy int NOT NULL,
	MaLoaiCC nvarchar(10) NOT NULL,
	MaLopChungChi nvarchar(10)NOT NULL,
	MaHocPhanCC nvarchar(10) NOT NULL,
	GiaTien money NOT NULL,
	TinhTrang nvarchar(20) NULL,
	NgayPhatHanh date NOT NULL,
	primary key(MaHocPhi)
)
go
ALTER TABLE HocPhi_ChungChi ADD CONSTRAINT fk_HocPhiCC_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE HocPhi_ChungChi ADD CONSTRAINT fk_HocPhi_LCC FOREIGN KEY (MaLopChungChi) REFERENCES LopChungChi(MaLopChungChi)
ALTER TABLE HocPhi_ChungChi ADD CONSTRAINT fk_HocPhi_LoaiCC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)
ALTER TABLE HocPhi_ChungChi ADD CONSTRAINT fk_HocPhi_HPCC FOREIGN KEY (MaHocPhanCC) REFERENCES HocPhanChungChi(MaHocPhanCC)

------------HOA DON HOC PHI--------------------
go
create table HoaDonHocPhi(
	MaHoaDon nvarchar(10) NOT NULL,
	MaHocPhi nvarchar(10) NOT NULL,
	TinhTrang nvarchar(20),
	HocKy int,
	Nam char(5),
	TongTien money NOT NULL,
	primary key(MaHoaDon)
)
go
ALTER TABLE HoaDonHocPhi drop CONSTRAINT fk_HoaDonHocPhi_HocPhi FOREIGN KEY (MaHocPhi) REFERENCES HocPhi(MaHocPhi)

---==================BANG DIEM============================
go
create table BangDiem_HocPhan
(
	MaBangDiem nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	TenHocPhan nvarchar(50)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	--MaLopChungChi nvarchar(10)NOT NULL,
	--MaLopCD nvarchar(10) NOT NULL,
	MaLopHP nvarchar(10)NOT NULL,
	Diem float,
	NgayDang date,
	primary key(MaBangDiem)
)
go
create table BangDiem_ChuyenDe
(
	MaBangDiem nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	TenHocPhan nvarchar(50)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	--MaLopChungChi nvarchar(10)NOT NULL,
	MaLopCD nvarchar(10) NOT NULL,
	Diem float,
	NgayDang date,
	primary key(MaBangDiem)
)
go
create table BangDiem_ChungChi
(
	MaBangDiem nvarchar(10)NOT NULL,
	MSSV nvarchar(8)NOT NULL,
	MaHocPhanCC nvarchar(10)NOT NULL,
	TenHocPhan nvarchar(50)NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	MaLopChungChi nvarchar(10)NOT NULL,
	MaLoaiCC nvarchar(10) NOT NULL,
	Diem float,
	NgayDang date,
	primary key(MaBangDiem)
)
go
ALTER TABLE BangDiem_HocPhan ADD CONSTRAINT fk_BDHP_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE BangDiem_HocPhan ADD CONSTRAINT fk_BDHP_LHP FOREIGN KEY (MaLopHP) REFERENCES LopHocPhan(MaLopHP)
-----------
ALTER TABLE BangDiem_ChuyenDe ADD CONSTRAINT fk_BDCD_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE BangDiem_ChuyenDe ADD CONSTRAINT fk_BDCD_LCD FOREIGN KEY (MaLopCD) REFERENCES LopChuyenDe(MaLopCD)
----------
ALTER TABLE BangDiem_ChungChi add CONSTRAINT fk_BDCC_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)
ALTER TABLE BangDiem_ChungChi add CONSTRAINT fk_BDCC_LCC FOREIGN KEY (MaLopChungChi) REFERENCES LopChungChi(MaLopChungChi)
ALTER TABLE BangDiem_ChungChi add CONSTRAINT fk_BDCC_LOAICC FOREIGN KEY (MaLoaiCC) REFERENCES LoaiChungChi(MaLoaiCC)
ALTER TABLE BangDiem_ChungChi add CONSTRAINT fk_BDCC_HPCC FOREIGN KEY (MaHocPhanCC) REFERENCES HocPhanChungChi(MaHocPhanCC)


--========================XET TOT NGHIEP=======================
go
create table PhieuDangKyTotNghiep
(
	MaPhieuDKTG nvarchar(10) NOT NULL,
	MSSV nvarchar(8) NOT NULL,
	HocKy int NOT NULL,
	NamHoc char(5) NOT NULL,
	NgayDK int NOT NULL,
	TinhTrang nvarchar(50) NOT NULL,
	primary key(MaPhieuDKTG)
)
go
ALTER TABLE PhieuDangKyTotNghiep ADD CONSTRAINT fk_PDKTG_SV FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV)

go

-------------------KHOA NGOAI------------------
