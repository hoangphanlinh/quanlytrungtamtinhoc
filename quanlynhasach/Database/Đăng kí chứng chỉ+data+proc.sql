select*from LoaiChungChi;
insert into LoaiChungChi Values ('LCCA','Chứng chỉ A');
insert into LoaiChungChi Values ('LCCB','Chứng chỉ B');

insert into LopChungChi values('LCC001','DSL001','GV001','HPCC001','18_3',0,20);
insert into LopChungChi values('LCC002','DSL001','GV001','HPCC003','18_4',0,20);
insert into LopChungChi values('LCC003','DSL002','GV001','HPCC002','18_2',0,20);
insert into LopChungChi values('LCC004','DSL002','GV001','HPCC004','18_6',0,20);
insert into LopChungChi values('LCC005','DSL002','GV001','HPCC006','18_5',0,20);
insert into LopChungChi values('LCC006','DSL001','GV001','HPCC005','18_1',0,20);


INSERT INTO DanhSachLopChungChi VALUES('DSL001',1,'20-21','LCCA','DS CHUNG CHI A/20-21',GETDATE());
INSERT INTO DanhSachLopChungChi VALUES('DSL002',1,'20-21','LCCB','DS CHUNG CHI B/20-21',GETDATE());


INSERT INTO HocPhanChungChi VALUES('HPCC001',N'ANH VĂN','DS001');
INSERT INTO HocPhanChungChi VALUES('HPCC002',N'PHÁP VĂN','DS002');
INSERT INTO HocPhanChungChi VALUES('HPCC003',N'HOA','DS001');
INSERT INTO HocPhanChungChi VALUES('HPCC004',N'KĨ NĂNG MỀM','DS002');
INSERT INTO HocPhanChungChi VALUES('HPCC005',N'KĨ NĂNG NHÓM','DS001');
INSERT INTO HocPhanChungChi VALUES('HPCC006',N'TÂY BAN NHA','DS002');


INSERT INTO DanhSachHocPhanChungChi VALUES('DS001',1,'20-21','LCCA','DS HP CCA/20-21',GETDATE());
INSERT INTO DanhSachHocPhanChungChi VALUES('DS002',1,'20-21','LCCB','DS HP CCB/20-21',GETDATE());


----------------------------------------------
select*from DSLopNhomChuyenDe

create proc xemlopchungchi
(
	@MaLoaiCC nvarchar(10)
)
as
begin
SELECT LCC.MaLopChungChi,LCC.MaDSLopChungChi,LCC.MaGiangVien,LCC.MaHocPhanCC,LCC.TenLopChungChi,LCC.SiSo,LCC.SiSoToiDa 
FROM  LopChungChi LCC JOIN DanhSachLopChungChi ON LCC.MaDSLopChungChi = DanhSachLopChungChi.MaDSLopChungChi WHERE MaLoaiCC = @MaLoaiCC;
end
EXEC xemlopchungchi 'LCCA'