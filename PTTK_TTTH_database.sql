create database TTTH
go
use TTTH
go
create table Account
(
	username varchar(10),
	password varchar(20),
	type char(1),
	primary key(username)
)
go
alter table Account add check (type = 1 or type = 2 or type = 3)
go
insert into Account values ('admin', 'admin', 1);

insert into Account values ('GV01', 'a', 2);
insert into Account values ('GV02', 'a', 2);
insert into Account values ('GV03', 'a', 2);
insert into Account values ('GV04', 'a', 2);
insert into Account values ('GV05', 'a', 2);
insert into Account values ('GV06', 'a', 2);
insert into Account values ('GV07', 'a', 2);
insert into Account values ('GV08', 'a', 2);
insert into Account values ('GV09', 'a', 2);
insert into Account values ('GV10', 'a', 2);
insert into Account values ('GV11', 'a', 2);
insert into Account values ('GV12', 'a', 2);
insert into Account values ('GV13', 'a', 2);
insert into Account values ('GV14', 'a', 2);

insert into Account values ('HV01', 'a', 3);
insert into Account values ('HV02', 'a', 3);
insert into Account values ('HV03', 'a', 3);
insert into Account values ('HV04', 'a', 3);
insert into Account values ('HV05', 'a', 3);
insert into Account values ('HV06', 'a', 3);
insert into Account values ('HV07', 'a', 3);
insert into Account values ('HV08', 'a', 3);
insert into Account values ('HV09', 'a', 3);
insert into Account values ('HV10', 'a', 3);

insert into Account values ('HV11', 'a', 3);
insert into Account values ('HV12', 'a', 3);
insert into Account values ('HV13', 'a', 3);
insert into Account values ('HV14', 'a', 3);
insert into Account values ('HV15', 'a', 3);
insert into Account values ('HV16', 'a', 3);
insert into Account values ('HV17', 'a', 3);
insert into Account values ('HV18', 'a', 3);
insert into Account values ('HV19', 'a', 3);
insert into Account values ('HV20', 'a', 3);

insert into Account values ('HV21', 'a', 3);
insert into Account values ('HV22', 'a', 3);
insert into Account values ('HV23', 'a', 3);
insert into Account values ('HV24', 'a', 3);
insert into Account values ('HV25', 'a', 3);
insert into Account values ('HV26', 'a', 3);
insert into Account values ('HV27', 'a', 3);
insert into Account values ('HV28', 'a', 3);
insert into Account values ('HV29', 'a', 3);
insert into Account values ('HV30', 'a', 3);

insert into Account values ('HV31', 'a', 3);
insert into Account values ('HV32', 'a', 3);
insert into Account values ('HV33', 'a', 3);
insert into Account values ('HV34', 'a', 3);
insert into Account values ('HV35', 'a', 3);
insert into Account values ('HV36', 'a', 3);
insert into Account values ('HV37', 'a', 3);
insert into Account values ('HV38', 'a', 3);
insert into Account values ('HV39', 'a', 3);
insert into Account values ('HV40', 'a', 3);

insert into Account values ('HV41', 'a', 3);
insert into Account values ('HV42', 'a', 3);
insert into Account values ('HV43', 'a', 3);
insert into Account values ('HV44', 'a', 3);
insert into Account values ('HV45', 'a', 3);
insert into Account values ('HV46', 'a', 3);
insert into Account values ('HV47', 'a', 3);
insert into Account values ('HV48', 'a', 3);
insert into Account values ('HV49', 'a', 3);
insert into Account values ('HV50', 'a', 3);

insert into Account values ('HV51', 'a', 3);
insert into Account values ('HV52', 'a', 3);
insert into Account values ('HV53', 'a', 3);
insert into Account values ('HV54', 'a', 3);
insert into Account values ('HV55', 'a', 3);
insert into Account values ('HV56', 'a', 3);
insert into Account values ('HV57', 'a', 3);
insert into Account values ('HV58', 'a', 3);
insert into Account values ('HV59', 'a', 3);
insert into Account values ('HV60', 'a', 3);

go

create table GiangVien
(
	MaGV varchar(10),
	HoTen varchar(50),
	NamSinh varchar(10),
	SDT char(10),
	primary key(MaGV)
)

go
insert into GiangVien values ('GV01', 'Nguyen Van A', '1990', '0123456789');
insert into GiangVien values ('GV02', 'Nguyen Van B', '1991', '0123456788');
insert into GiangVien values ('GV03', 'Nguyen Van C', '1992', '0123456787');
insert into GiangVien values ('GV04', 'Nguyen Van D', '1993', '0123456786');
insert into GiangVien values ('GV05', 'Nguyen Van E', '1994', '0123456785');
insert into GiangVien values ('GV06', 'Nguyen Van F', '1990', '0123456784');
insert into GiangVien values ('GV07', 'Nguyen Van G', '1991', '0123456783');
insert into GiangVien values ('GV08', 'Nguyen Van H', '1992', '0123456782');
insert into GiangVien values ('GV09', 'Nguyen Van J', '1993', '0123456781');
insert into GiangVien values ('GV10', 'Nguyen Van K', '1994', '0123456780');
insert into GiangVien values ('GV11', 'Nguyen Van L', '1990', '0123456789');
insert into GiangVien values ('GV12', 'Nguyen Van M', '1991', '0123456788');
insert into GiangVien values ('GV13', 'Nguyen Van N', '1992', '0123456787');
insert into GiangVien values ('GV14', 'Nguyen Van O', '1993', '0123456786');

go

create table HocVien
(	
	MaHV varchar(10),
	HoTen varchar(50),
	NamSinh varchar(10),
	SDT char(10),
	primary key(MaHV)
)
go
insert into HocVien values ('HV01', 'Tran Van A', '2000', '0123456789');
insert into HocVien values ('HV02', 'Tran Van B', '2001', '0123456778');
insert into HocVien values ('HV03', 'Tran Van C', '2002', '0123456767');
insert into HocVien values ('HV04', 'Tran Van D', '2003', '0123456756');
insert into HocVien values ('HV05', 'Tran Van E', '2001', '0123456745');
insert into HocVien values ('HV06', 'Tran Van F', '2002', '0123456734');
insert into HocVien values ('HV07', 'Tran Van G', '2003', '0123456723');
insert into HocVien values ('HV08', 'Tran Van H', '2001', '0123456712');
insert into HocVien values ('HV09', 'Tran Van J', '2002', '0123456701');
insert into HocVien values ('HV10', 'Tran Van K', '2003', '0123456790');

insert into HocVien values ('HV11', 'Phan Van A', '2000', '0123456789');
insert into HocVien values ('HV12', 'Phan Van B', '2001', '0123456778');
insert into HocVien values ('HV13', 'Phan Van C', '2002', '0123456767');
insert into HocVien values ('HV14', 'Phan Van D', '2003', '0123456756');
insert into HocVien values ('HV15', 'Phan Van E', '2001', '0123456745');
insert into HocVien values ('HV16', 'Phan Van F', '2002', '0123456734');
insert into HocVien values ('HV17', 'Phan Van G', '2003', '0123456723');
insert into HocVien values ('HV18', 'Phan Van H', '2001', '0123456712');
insert into HocVien values ('HV19', 'Phan Van J', '2002', '0123456701');
insert into HocVien values ('HV20', 'Phan Van K', '2003', '0123456790');

insert into HocVien values ('HV21', 'Pham Van A', '2000', '0123456789');
insert into HocVien values ('HV22', 'Pham Van B', '2001', '0123456778');
insert into HocVien values ('HV23', 'Pham Van C', '2002', '0123456767');
insert into HocVien values ('HV24', 'Pham Van D', '2003', '0123456756');
insert into HocVien values ('HV25', 'Pham Van E', '2001', '0123456745');
insert into HocVien values ('HV26', 'Pham Van F', '2002', '0123456734');
insert into HocVien values ('HV27', 'Pham Van G', '2003', '0123456723');
insert into HocVien values ('HV28', 'Pham Van H', '2001', '0123456712');
insert into HocVien values ('HV29', 'Pham Van J', '2002', '0123456701');
insert into HocVien values ('HV30', 'Pham Van K', '2003', '0123456790');

insert into HocVien values ('HV31', 'Phung Van A', '2000', '0123456789');
insert into HocVien values ('HV32', 'Phung Van B', '2001', '0123456778');
insert into HocVien values ('HV33', 'Phung Van C', '2002', '0123456767');
insert into HocVien values ('HV34', 'Phung Van D', '2003', '0123456756');
insert into HocVien values ('HV35', 'Phung Van E', '2001', '0123456745');
insert into HocVien values ('HV36', 'Phung Van F', '2002', '0123456734');
insert into HocVien values ('HV37', 'Phung Van G', '2003', '0123456723');
insert into HocVien values ('HV38', 'Phung Van H', '2001', '0123456712');
insert into HocVien values ('HV39', 'Phung Van J', '2002', '0123456701');
insert into HocVien values ('HV40', 'Phung Van K', '2003', '0123456790');

insert into HocVien values ('HV41', 'Ho Van A', '2000', '0123456789');
insert into HocVien values ('HV42', 'Ho Van B', '2001', '0123456778');
insert into HocVien values ('HV43', 'Ho Van C', '2002', '0123456767');
insert into HocVien values ('HV44', 'Ho Van D', '2003', '0123456756');
insert into HocVien values ('HV45', 'Ho Van E', '2001', '0123456745');
insert into HocVien values ('HV46', 'Ho Van F', '2002', '0123456734');
insert into HocVien values ('HV47', 'Ho Van G', '2003', '0123456723');
insert into HocVien values ('HV48', 'Ho Van H', '2001', '0123456712');
insert into HocVien values ('HV49', 'Ho Van J', '2002', '0123456701');
insert into HocVien values ('HV50', 'Ho Van K', '2003', '0123456790');

insert into HocVien values ('HV51', 'Le Van A', '2000', '0123456789');
insert into HocVien values ('HV52', 'Le Van B', '2001', '0123456778');
insert into HocVien values ('HV53', 'Le Van C', '2002', '0123456767');
insert into HocVien values ('HV54', 'Le Van D', '2003', '0123456756');
insert into HocVien values ('HV55', 'Le Van E', '2001', '0123456745');
insert into HocVien values ('HV56', 'Le Van F', '2002', '0123456734');
insert into HocVien values ('HV57', 'Le Van G', '2003', '0123456723');
insert into HocVien values ('HV58', 'Le Van H', '2001', '0123456712');
insert into HocVien values ('HV59', 'Le Van J', '2002', '0123456701');
insert into HocVien values ('HV60', 'Le Van K', '2003', '0123456790');
go
create table Khoa
(
	MaKhoa varchar(10),
	NgayBD date,
	NgayKT date,
	primary key (MaKhoa)
)
go
alter table Khoa add check (NgayKT > NgayBD)
go
--delete from Khoa where MaKhoa = 'K1'
insert into Khoa values ('K1','01/01/2020','06/30/2020');
insert into Khoa values ('K2','07/01/2020','12/31/2020');
insert into Khoa values ('K3','01/01/2021','06/30/2021');
insert into Khoa values ('K4','07/01/2021','12/31/2021');

go
create table NhomHocPhan 
(
	MaNHP varchar(10),
	TenNHP varchar(50),
	primary key (MaNHP)
)
go
insert into NhomHocPhan values ('NHP01','Nhom Hoc Phan 1');
insert into NhomHocPhan values ('NHP02','Nhom Hoc Phan 2');

go
create table Mon
(
	MaMon varchar(10),
	TenMon varchar(50),
	BatBuoc bit,
	MaNHP varchar(10),
	primary key (MaMon)
)
go
alter table Mon add constraint FK_Mon_MaNHP foreign key (MaNHP) references NhomHocPhan(MaNHP);
go
insert into Mon values ('M01', 'Mon 1', 1, 'NHP01');
insert into Mon values ('M02', 'Mon 2', 1, 'NHP01');
insert into Mon values ('M03', 'Mon 3', 1, 'NHP01');
insert into Mon values ('M04', 'Mon 4', 0, 'NHP01');
insert into Mon values ('M05', 'Mon 5', 0, 'NHP01');
insert into Mon values ('M06', 'Mon 6', 1, 'NHP02');
insert into Mon values ('M07', 'Mon 7', 1, 'NHP02');
insert into Mon values ('M08', 'Mon 8', 1, 'NHP02');
insert into Mon values ('M09', 'Mon 9', 0, 'NHP02');
insert into Mon values ('M10', 'Mon 10', 0, 'NHP02');

go
create table NhomHocPhanMo
(
	MaNHP varchar(10),
	MaKhoa varchar(10),
	isFull int,
	primary key (MaNHP,MaKhoa)
)
go
alter table NhomHocPhanMo add constraint FK_NhomHocPhanMo_NHP foreign key (MaNHP) references NhomHocPhan(MaNHP);
alter table NhomHocPhanMo add constraint FK_NhomHocPhanMo_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
go
insert into NhomHocPhanMo values ('NHP01','K1',1);
insert into NhomHocPhanMo values ('NHP02','K2',1);
insert into NhomHocPhanMo values ('NHP01','K3',1);
insert into NhomHocPhanMo values ('NHP02','K4',1);
go

create table LopKTVMo
(
	MaMon varchar(10),
	MaKhoa varchar(10),
	MaGV varchar(10),
	LichHoc varchar(100),
	primary key(MaMon, MaKhoa)
)
go
alter table LopKTVMo add constraint FK_LopKTVMo_Mon foreign key (MaMon) references Mon(MaMon);
alter table LopKTVMo add constraint FK_LopKTVMo_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
alter table LopKTVMo add constraint FK_LopKTVMo_GiangVien foreign key (MaGV) references GiangVien(MaGV);
go
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV01', 'M01', 'E101, 17:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV02', 'M02', 'E102, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV03', 'M03', 'E103, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV04', 'M04', 'E104, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV05', 'M05', 'E105, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV01', 'M06', 'E101, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV02', 'M07', 'E102, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV03', 'M08', 'E103, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV04', 'M09', 'E104, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV05', 'M10', 'E105, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV01', 'M01', 'E101, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV02', 'M02', 'E102, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV03', 'M03', 'E103, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV04', 'M04', 'E104, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV05', 'M05', 'E105, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV01', 'M06', 'E101, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV02', 'M07', 'E102, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV03', 'M08', 'E103, 17:00 Thu 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV04', 'M09', 'E104, 19:00 Thu 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV05', 'M10', 'E105, 17:00 Thu 3, 5, 7');


go
--drop table DangKiNhomHocPhan
create table DangKyNhomHocPhan
(
	MaHV varchar(10),
	MaNHP varchar(10),
	MaKhoa varchar(10),
	DTB float,
	HocPhi int,
	SoLanThiLai int,
	KetQua int,
	primary key (MaHV,MaNHP,MaKhoa)
)
go
alter table DangKyNhomHocPhan add check (SoLanThiLai >= 0 and SoLanThiLai <= 3);
alter table DangKyNhomHocPhan add check (KetQua = 0 or KetQua = 1 or KetQua = null);
alter table DangKyNhomHocPhan add check ((DTB >= 0 and DTB <= 10) or DTB = null);
go
alter table DangKyNhomHocPhan add constraint FK_DKNHP_HocVien foreign key (MaHV) references HocVien(MaHV);
alter table DangKyNhomHocPhan add constraint FK_DKNHP_NHPM foreign key (MaNHP,MaKhoa) references NhomHocPhanMo(MaNHP,MaKhoa);

go
insert into DangKyNhomHocPhan values ('HV01','NHP01','K1',8,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV02','NHP01','K1',9,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV03','NHP01','K1',9.5,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV04','NHP01','K1',7,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV05','NHP01','K1',7.5,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV06','NHP01','K1',6,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV07','NHP01','K1',7,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV08','NHP01','K1',9,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV09','NHP01','K1',5,1000000,1,1);
insert into DangKyNhomHocPhan values ('HV10','NHP01','K1',8,1000000,1,1);

insert into DangKyNhomHocPhan values ('HV01','NHP02','K2',8,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV02','NHP02','K2',9,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV03','NHP02','K2',9.5,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV04','NHP02','K2',7,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV05','NHP02','K2',7.5,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV06','NHP02','K2',6,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV07','NHP02','K2',7,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV08','NHP02','K2',9,1500000,0,1);
insert into DangKyNhomHocPhan values ('HV09','NHP02','K2',6,1500000,1,1);
insert into DangKyNhomHocPhan values ('HV10','NHP02','K2',7,1500000,1,1);

insert into DangKyNhomHocPhan values ('HV11','NHP01','K3',8,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV12','NHP01','K3',9,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV13','NHP01','K3',9.5,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV14','NHP01','K3',7,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV15','NHP01','K3',7.5,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV16','NHP01','K3',6,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV17','NHP01','K3',7,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV18','NHP01','K3',9,1000000,0,1);
insert into DangKyNhomHocPhan values ('HV19','NHP01','K3',5,1000000,1,1);
insert into DangKyNhomHocPhan values ('HV20','NHP01','K3',8,1000000,1,1);

insert into DangKyNhomHocPhan values ('HV11','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV12','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV13','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV14','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV15','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV16','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV17','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV18','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV19','NHP02','K4',null,1500000,0,null);
insert into DangKyNhomHocPhan values ('HV20','NHP02','K4',null,1500000,0,null);
go
create table BangDiem
(
	MaHV varchar(10),
	MaMon varchar(10),
	MaKhoa varchar(10),
	LanThi int,
	DiemThi float,
	NgayThi date,
	primary key (MaHV,MaMon,MaKhoa,LanThi)
)
go
alter table BangDiem add constraint FK_BangDiem_HV foreign key (MaHV) references HocVien(MaHV);
alter table BangDiem add constraint FK_BangDiem_Mon foreign key (MaMon,MaKhoa) references LopKTVMo(MaMon,MaKhoa);
--alter table BangDiem add constraint FK_BangDiem_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
go
alter table BangDiem add check (LanThi >= 0 and LanThi <= 4);
alter table BangDiem add check ((DiemThi >= 0 and DiemThi <= 10) or DiemThi = null);
go
insert into BangDiem values ('HV01','M01', 'K1', 1, 8, '06/15/2020');
insert into BangDiem values ('HV01','M02', 'K1', 1, 8, '06/15/2020');
insert into BangDiem values ('HV01','M03', 'K1', 1, 8, '06/15/2020');
insert into BangDiem values ('HV01','M04', 'K1', 1, 8, '06/15/2020');
insert into BangDiem values ('HV01','M05', 'K1', 1, 8, '06/15/2020');

insert into BangDiem values ('HV02','M01', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV02','M02', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV02','M03', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV02','M04', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV02','M05', 'K1', 1, 9, '06/15/2020');

insert into BangDiem values ('HV03','M01', 'K1', 1, 9.5, '06/15/2020');
insert into BangDiem values ('HV03','M02', 'K1', 1, 9.5, '06/15/2020');
insert into BangDiem values ('HV03','M03', 'K1', 1, 9.5, '06/15/2020');
insert into BangDiem values ('HV03','M04', 'K1', 1, 9.5, '06/15/2020');
insert into BangDiem values ('HV03','M05', 'K1', 1, 9.5, '06/15/2020');

insert into BangDiem values ('HV04','M01', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV04','M02', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV04','M03', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV04','M04', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV04','M05', 'K1', 1, 7, '06/15/2020');

insert into BangDiem values ('HV05','M01', 'K1', 1, 7.5, '06/15/2020');
insert into BangDiem values ('HV05','M02', 'K1', 1, 7.5, '06/15/2020');
insert into BangDiem values ('HV05','M03', 'K1', 1, 7.5, '06/15/2020');
insert into BangDiem values ('HV05','M04', 'K1', 1, 7.5, '06/15/2020');
insert into BangDiem values ('HV05','M05', 'K1', 1, 7.5, '06/15/2020');

insert into BangDiem values ('HV06','M01', 'K1', 1, 6, '06/15/2020');
insert into BangDiem values ('HV06','M02', 'K1', 1, 6, '06/15/2020');
insert into BangDiem values ('HV06','M03', 'K1', 1, 6, '06/15/2020');
insert into BangDiem values ('HV06','M04', 'K1', 1, 6, '06/15/2020');
insert into BangDiem values ('HV06','M05', 'K1', 1, 6, '06/15/2020');

insert into BangDiem values ('HV07','M01', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV07','M02', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV07','M03', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV07','M04', 'K1', 1, 7, '06/15/2020');
insert into BangDiem values ('HV07','M05', 'K1', 1, 7, '06/15/2020');

insert into BangDiem values ('HV08','M01', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV08','M02', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV08','M03', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV08','M04', 'K1', 1, 9, '06/15/2020');
insert into BangDiem values ('HV08','M05', 'K1', 1, 9, '06/15/2020');

insert into BangDiem values ('HV09','M01', 'K1', 1, 3, '06/15/2020');
insert into BangDiem values ('HV09','M02', 'K1', 1, 3, '06/15/2020');
insert into BangDiem values ('HV09','M03', 'K1', 1, 3, '06/15/2020');
insert into BangDiem values ('HV09','M04', 'K1', 1, 3, '06/15/2020');
insert into BangDiem values ('HV09','M05', 'K1', 1, 3, '06/15/2020');

insert into BangDiem values ('HV09','M01', 'K1', 2, 5, '06/22/2020');
insert into BangDiem values ('HV09','M02', 'K1', 2, 5, '06/22/2020');
insert into BangDiem values ('HV09','M03', 'K1', 2, 5, '06/22/2020');


insert into BangDiem values ('HV10','M01', 'K1', 1, 4, '06/15/2020');
insert into BangDiem values ('HV10','M02', 'K1', 1, 4, '06/15/2020');
insert into BangDiem values ('HV10','M03', 'K1', 1, 4, '06/15/2020');
insert into BangDiem values ('HV10','M04', 'K1', 1, 4.5, '06/15/2020');
insert into BangDiem values ('HV10','M05', 'K1', 1, 4.5, '06/15/2020');

insert into BangDiem values ('HV10','M01', 'K1', 2, 8, '06/22/2020');
insert into BangDiem values ('HV10','M02', 'K1', 2, 8, '06/22/2020');
insert into BangDiem values ('HV10','M03', 'K1', 2, 8, '06/22/2020');

insert into BangDiem values ('HV01','M06', 'K2', 1, 8, '12/15/2020');
insert into BangDiem values ('HV01','M07', 'K2', 1, 8, '12/15/2020');
insert into BangDiem values ('HV01','M08', 'K2', 1, 8, '12/15/2020');
insert into BangDiem values ('HV01','M09', 'K2', 1, 8, '12/15/2020');
insert into BangDiem values ('HV01','M10', 'K2', 1, 8, '12/15/2020');

insert into BangDiem values ('HV02','M06', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV02','M07', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV02','M08', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV02','M09', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV02','M10', 'K2', 1, 9, '12/15/2020');

insert into BangDiem values ('HV03','M06', 'K2', 1, 9.5, '12/15/2020');
insert into BangDiem values ('HV03','M07', 'K2', 1, 9.5, '12/15/2020');
insert into BangDiem values ('HV03','M08', 'K2', 1, 9.5, '12/15/2020');
insert into BangDiem values ('HV03','M09', 'K2', 1, 9.5, '12/15/2020');
insert into BangDiem values ('HV03','M10', 'K2', 1, 9.5, '12/15/2020');

insert into BangDiem values ('HV04','M06', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV04','M07', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV04','M08', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV04','M09', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV04','M10', 'K2', 1, 7, '12/15/2020');

insert into BangDiem values ('HV05','M06', 'K2', 1, 7.5, '12/15/2020');
insert into BangDiem values ('HV05','M07', 'K2', 1, 7.5, '12/15/2020');
insert into BangDiem values ('HV05','M08', 'K2', 1, 7.5, '12/15/2020');
insert into BangDiem values ('HV05','M09', 'K2', 1, 7.5, '12/15/2020');
insert into BangDiem values ('HV05','M10', 'K2', 1, 7.5, '12/15/2020');

insert into BangDiem values ('HV06','M06', 'K2', 1, 6, '12/15/2020');
insert into BangDiem values ('HV06','M07', 'K2', 1, 6, '12/15/2020');
insert into BangDiem values ('HV06','M08', 'K2', 1, 6, '12/15/2020');
insert into BangDiem values ('HV06','M09', 'K2', 1, 6, '12/15/2020');
insert into BangDiem values ('HV06','M10', 'K2', 1, 6, '12/15/2020');

insert into BangDiem values ('HV07','M06', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV07','M07', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV07','M08', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV07','M09', 'K2', 1, 7, '12/15/2020');
insert into BangDiem values ('HV07','M10', 'K2', 1, 7, '12/15/2020');

insert into BangDiem values ('HV08','M06', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV08','M07', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV08','M08', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV08','M09', 'K2', 1, 9, '12/15/2020');
insert into BangDiem values ('HV08','M10', 'K2', 1, 9, '12/15/2020');

insert into BangDiem values ('HV09','M06', 'K2', 1, 3, '12/15/2020');
insert into BangDiem values ('HV09','M07', 'K2', 1, 3, '12/15/2020');
insert into BangDiem values ('HV09','M08', 'K2', 1, 3, '12/15/2020');
insert into BangDiem values ('HV09','M09', 'K2', 1, 3, '12/15/2020');
insert into BangDiem values ('HV09','M10', 'K2', 1, 3, '12/15/2020');

insert into BangDiem values ('HV09','M06', 'K2', 2, 5, '12/22/2020');
insert into BangDiem values ('HV09','M07', 'K2', 2, 5, '12/22/2020');
insert into BangDiem values ('HV09','M08', 'K2', 2, 5, '12/22/2020');


insert into BangDiem values ('HV10','M06', 'K2', 1, 4, '12/15/2020');
insert into BangDiem values ('HV10','M07', 'K2', 1, 4, '12/15/2020');
insert into BangDiem values ('HV10','M08', 'K2', 1, 4, '12/15/2020');
insert into BangDiem values ('HV10','M09', 'K2', 1, 4.5, '12/15/2020');
insert into BangDiem values ('HV10','M10', 'K2', 1, 4.5, '12/15/2020');

insert into BangDiem values ('HV10','M06', 'K2', 2, 8, '12/22/2020');
insert into BangDiem values ('HV10','M07', 'K2', 2, 8, '12/22/2020');
insert into BangDiem values ('HV10','M08', 'K2', 2, 8, '12/22/2020');

insert into BangDiem values ('HV11','M01', 'K3', 1, 8, '06/15/2021');
insert into BangDiem values ('HV11','M02', 'K3', 1, 8, '06/15/2021');
insert into BangDiem values ('HV11','M03', 'K3', 1, 8, '06/15/2021');
insert into BangDiem values ('HV11','M04', 'K3', 1, 8, '06/15/2021');
insert into BangDiem values ('HV11','M05', 'K3', 1, 8, '06/15/2021');

insert into BangDiem values ('HV12','M01', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV12','M02', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV12','M03', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV12','M04', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV12','M05', 'K3', 1, 9, '06/15/2021');

insert into BangDiem values ('HV13','M01', 'K3', 1, 9.5, '06/15/2021');
insert into BangDiem values ('HV13','M02', 'K3', 1, 9.5, '06/15/2021');
insert into BangDiem values ('HV13','M03', 'K3', 1, 9.5, '06/15/2021');
insert into BangDiem values ('HV13','M04', 'K3', 1, 9.5, '06/15/2021');
insert into BangDiem values ('HV13','M05', 'K3', 1, 9.5, '06/15/2021');

insert into BangDiem values ('HV14','M01', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV14','M02', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV14','M03', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV14','M04', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV14','M05', 'K3', 1, 7, '06/15/2021');

insert into BangDiem values ('HV15','M01', 'K3', 1, 7.5, '06/15/2021');
insert into BangDiem values ('HV15','M02', 'K3', 1, 7.5, '06/15/2021');
insert into BangDiem values ('HV15','M03', 'K3', 1, 7.5, '06/15/2021');
insert into BangDiem values ('HV15','M04', 'K3', 1, 7.5, '06/15/2021');
insert into BangDiem values ('HV15','M05', 'K3', 1, 7.5, '06/15/2021');

insert into BangDiem values ('HV16','M01', 'K3', 1, 6, '06/15/2021');
insert into BangDiem values ('HV16','M02', 'K3', 1, 6, '06/15/2021');
insert into BangDiem values ('HV16','M03', 'K3', 1, 6, '06/15/2021');
insert into BangDiem values ('HV16','M04', 'K3', 1, 6, '06/15/2021');
insert into BangDiem values ('HV16','M05', 'K3', 1, 6, '06/15/2021');

insert into BangDiem values ('HV17','M01', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV17','M02', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV17','M03', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV17','M04', 'K3', 1, 7, '06/15/2021');
insert into BangDiem values ('HV17','M05', 'K3', 1, 7, '06/15/2021');

insert into BangDiem values ('HV18','M01', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV18','M02', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV18','M03', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV18','M04', 'K3', 1, 9, '06/15/2021');
insert into BangDiem values ('HV18','M05', 'K3', 1, 9, '06/15/2021');

insert into BangDiem values ('HV19','M01', 'K3', 1, 3, '06/15/2021');
insert into BangDiem values ('HV19','M02', 'K3', 1, 3, '06/15/2021');
insert into BangDiem values ('HV19','M03', 'K3', 1, 3, '06/15/2021');
insert into BangDiem values ('HV19','M04', 'K3', 1, 3, '06/15/2021');
insert into BangDiem values ('HV19','M05', 'K3', 1, 3, '06/15/2021');

insert into BangDiem values ('HV19','M01', 'K3', 2, 5, '06/22/2021');
insert into BangDiem values ('HV19','M02', 'K3', 2, 5, '06/22/2021');
insert into BangDiem values ('HV19','M03', 'K3', 2, 5, '06/22/2021');


insert into BangDiem values ('HV20','M01', 'K3', 1, 4, '06/15/2021');
insert into BangDiem values ('HV20','M02', 'K3', 1, 4, '06/15/2021');
insert into BangDiem values ('HV20','M03', 'K3', 1, 4, '06/15/2021');
insert into BangDiem values ('HV20','M04', 'K3', 1, 4.5, '06/15/2021');
insert into BangDiem values ('HV20','M05', 'K3', 1, 4.5, '06/15/2021');

insert into BangDiem values ('HV20','M01', 'K3', 2, 8, '06/22/2021');
insert into BangDiem values ('HV20','M02', 'K3', 2, 8, '06/22/2021');
insert into BangDiem values ('HV20','M03', 'K3', 2, 8, '06/22/2021');

insert into BangDiem values ('HV11','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV11','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV11','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV11','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV11','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV12','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV12','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV12','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV12','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV12','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV13','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV13','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV13','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV13','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV13','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV14','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV14','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV14','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV14','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV14','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV15','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV15','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV15','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV15','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV15','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV16','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV16','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV16','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV16','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV16','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV17','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV17','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV17','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV17','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV17','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV18','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV18','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV18','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV18','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV18','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV19','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV19','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV19','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV19','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV19','M10', 'K4', 1, null, '12/15/2021');

insert into BangDiem values ('HV20','M06', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV20','M07', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV20','M08', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV20','M09', 'K4', 1, null, '12/15/2021');
insert into BangDiem values ('HV20','M10', 'K4', 1, null, '12/15/2021');



go


create table ChungChi
(
	MaCC varchar(10),
	TenCC varchar(50),
	primary key (MaCC)
)

go

insert into ChungChi values ('CCA', 'Chung chi A');
insert into ChungChi values ('CCB', 'Chung chi B');


go
create table Nhanh
(
	MaNhanh varchar(10),
	TenNhanh varchar(50),
	MaCC varchar(10),
	primary key (MaNhanh)
)
go
alter table Nhanh add constraint FK_Nhanh_CC foreign key (MaCC) references ChungChi(MaCC);
go

insert into Nhanh values ('NCCA1', 'Nhanh chung chi A 1', 'CCA');
insert into Nhanh values ('NCCB1', 'Nhanh chung chi B 1', 'CCB');
insert into Nhanh values ('NCCB2', 'Nhanh chung chi B 2', 'CCB');

go
create table LopChungChi
(
	MaLCC varchar(10),
	TenLCC varchar(50),
	MaNhanh varchar(10),
	primary key (MaLCC)
)
go
alter table LopChungChi add constraint FK_LCC_Nhanh foreign key (MaNhanh) references Nhanh(MaNhanh);
go
insert into LopChungChi values ('LCC01', 'Lop Chung Chi 1', 'NCCA1');
insert into LopChungChi values ('LCC02', 'Lop Chung Chi 2','NCCA1');
insert into LopChungChi values ('LCC03', 'Lop Chung Chi 3','NCCA1');

insert into LopChungChi values ('LCC04', 'Lop Chung Chi 4','NCCB1');
insert into LopChungChi values ('LCC05', 'Lop Chung Chi 5','NCCB1');
insert into LopChungChi values ('LCC06', 'Lop Chung Chi 6','NCCB2');
insert into LopChungChi values ('LCC07', 'Lop Chung Chi 7','NCCB2');


create table LopChungChiMo
(
	MaLCC varchar(10),
	MaKhoa varchar(10),
	LichHoc varchar(100),
	MaGV varchar(10),
	isFull int,
	primary key (MaLCC, MaKhoa)
)
go
alter table LopChungChiMo add constraint FK_LCCM_LCC foreign key (MaLCC) references LopChungChi(MaLCC);
alter table LopChungChiMo add constraint FK_LCCM_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
alter table LopChungChiMo add constraint FK_LCCM_GV foreign key (MaGV) references GiangVien(MaGV);
go
insert into LopChungChiMo values ('LCC01', 'K1', 'A101, 7:30, Thu 2, 4, 6', 'GV06',1);
insert into LopChungChiMo values ('LCC02', 'K1', 'A102, 7:30, Thu 3, 5, 7', 'GV07',1);
insert into LopChungChiMo values ('LCC03', 'K1', 'A103, 9:30, Thu 2, 4, 6', 'GV08',1);
insert into LopChungChiMo values ('LCC01', 'K2', 'A101, 7:30, Thu 2, 4, 6', 'GV06',1);
insert into LopChungChiMo values ('LCC02', 'K2', 'A102, 7:30, Thu 3, 5, 7', 'GV07',1);
insert into LopChungChiMo values ('LCC03', 'K2', 'A103, 9:30, Thu 2, 4, 6', 'GV08',1);
insert into LopChungChiMo values ('LCC01', 'K3', 'A101, 7:30, Thu 2, 4, 6', 'GV06',1);
insert into LopChungChiMo values ('LCC02', 'K3', 'A102, 7:30, Thu 3, 5, 7', 'GV07',1);
insert into LopChungChiMo values ('LCC03', 'K3', 'A103, 9:30, Thu 2, 4, 6', 'GV08',1);
insert into LopChungChiMo values ('LCC01', 'K4', 'A101, 7:30, Thu 2, 4, 6', 'GV06',1);
insert into LopChungChiMo values ('LCC02', 'K4', 'A102, 7:30, Thu 3, 5, 7', 'GV07',1);
insert into LopChungChiMo values ('LCC03', 'K4', 'A103, 9:30, Thu 2, 4, 6', 'GV08',1);

insert into LopChungChiMo values ('LCC04', 'K1', 'B102, 7:30, Thu 3, 5, 7', 'GV09',1);
insert into LopChungChiMo values ('LCC05', 'K1', 'B103, 7:30, Thu 2, 4, 6', 'GV10',1);
insert into LopChungChiMo values ('LCC04', 'K2', 'B102, 7:30, Thu 3, 5, 7', 'GV09',1);
insert into LopChungChiMo values ('LCC05', 'K2', 'B103, 7:30, Thu 2, 4, 6', 'GV10',1);
insert into LopChungChiMo values ('LCC04', 'K3', 'B102, 7:30, Thu 3, 5, 7', 'GV09',1);
insert into LopChungChiMo values ('LCC05', 'K3', 'B103, 7:30, Thu 2, 4, 6', 'GV10',1);
insert into LopChungChiMo values ('LCC04', 'K4', 'B102, 7:30, Thu 3, 5, 7', 'GV09',1);
insert into LopChungChiMo values ('LCC05', 'K4', 'B103, 7:30, Thu 2, 4, 6', 'GV10',1);

insert into LopChungChiMo values ('LCC06', 'K1', 'B202, 7:30, Thu 3, 5, 7', 'GV01',1);
insert into LopChungChiMo values ('LCC07', 'K1', 'B203, 7:30, Thu 2, 4, 6', 'GV02',1);
insert into LopChungChiMo values ('LCC06', 'K2', 'B202, 7:30, Thu 3, 5, 7', 'GV01',1);
insert into LopChungChiMo values ('LCC07', 'K2', 'B203, 7:30, Thu 2, 4, 6', 'GV02',1);
insert into LopChungChiMo values ('LCC06', 'K3', 'B202, 7:30, Thu 3, 5, 7', 'GV01',1);
insert into LopChungChiMo values ('LCC07', 'K3', 'B203, 7:30, Thu 2, 4, 6', 'GV02',1);
insert into LopChungChiMo values ('LCC06', 'K4', 'B202, 7:30, Thu 3, 5, 7', 'GV01',1);
insert into LopChungChiMo values ('LCC07', 'K4', 'B203, 7:30, Thu 2, 4, 6', 'GV02',1);
go

create table DangKyLopChungChi
(
	MaHV varchar(10),
	MaLCC varchar(10),
	MaKhoa varchar(10),
	HocPhi int,
	DiemThi float,
	NgayThi date,
	primary key (MaHV, MaLCC, MaKhoa)
)
go
alter table DangKyLopChungChi add constraint FK_DKLCC_HV foreign key (MaHV) references HocVien(MaHV);
alter table DangKyLopChungChi add constraint FK_DKLCC_LVV foreign key (MaLCC,MaKhoa) references LopChungChiMo(MaLCC,MaKhoa);
--alter table DangKyLopChungChi add constraint FK_DKLCC_Khoa foreign key (MaKhoa) references LopChungChi(MaKhoa);
go
alter table DangKyLopChungChi add check (HocPhi > 0);
alter table DangKyLopChungChi add check ((DiemThi >= 0 and DiemThi <= 10) or DiemThi = null);
go
insert into DangKyLopChungChi values ('HV01', 'LCC01', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV02', 'LCC01', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV03', 'LCC01', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV04', 'LCC01', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV05', 'LCC01', 'K1', 1000000, 9, '06/15/2020');

insert into DangKyLopChungChi values ('HV01', 'LCC02', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV02', 'LCC02', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV03', 'LCC02', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV04', 'LCC02', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV05', 'LCC02', 'K1', 1000000, 9, '06/15/2020');

insert into DangKyLopChungChi values ('HV01', 'LCC03', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV02', 'LCC03', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV03', 'LCC03', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV04', 'LCC03', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV05', 'LCC03', 'K1', 1000000, 9, '06/15/2020');
--
insert into DangKyLopChungChi values ('HV06', 'LCC04', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV07', 'LCC04', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV08', 'LCC04', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV09', 'LCC04', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV10', 'LCC04', 'K1', 1000000, 9, '06/15/2020');

insert into DangKyLopChungChi values ('HV06', 'LCC05', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV07', 'LCC05', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV08', 'LCC05', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV09', 'LCC05', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV10', 'LCC05', 'K1', 1000000, 9, '06/15/2020');
--
insert into DangKyLopChungChi values ('HV11', 'LCC06', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV12', 'LCC06', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV13', 'LCC06', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV14', 'LCC06', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV15', 'LCC06', 'K1', 1000000, 9, '06/15/2020');

insert into DangKyLopChungChi values ('HV11', 'LCC07', 'K1', 1000000, 5, '06/15/2020');
insert into DangKyLopChungChi values ('HV12', 'LCC07', 'K1', 1000000, 6, '06/15/2020');
insert into DangKyLopChungChi values ('HV13', 'LCC07', 'K1', 1000000, 7, '06/15/2020');
insert into DangKyLopChungChi values ('HV14', 'LCC07', 'K1', 1000000, 8, '06/15/2020');
insert into DangKyLopChungChi values ('HV15', 'LCC07', 'K1', 1000000, 9, '06/15/2020');
-- khoa 2
insert into DangKyLopChungChi values ('HV16', 'LCC01', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV17', 'LCC01', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV18', 'LCC01', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV19', 'LCC01', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV20', 'LCC01', 'K2', 1000000, 9, '12/15/2020');

insert into DangKyLopChungChi values ('HV16', 'LCC02', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV17', 'LCC02', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV18', 'LCC02', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV19', 'LCC02', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV20', 'LCC02', 'K2', 1000000, 9, '12/15/2020');

insert into DangKyLopChungChi values ('HV16', 'LCC03', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV17', 'LCC03', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV18', 'LCC03', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV19', 'LCC03', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV20', 'LCC03', 'K2', 1000000, 9, '12/15/2020');
--
insert into DangKyLopChungChi values ('HV21', 'LCC04', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV22', 'LCC04', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV23', 'LCC04', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV24', 'LCC04', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV25', 'LCC04', 'K2', 1000000, 9, '12/15/2020');

insert into DangKyLopChungChi values ('HV21', 'LCC05', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV22', 'LCC05', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV23', 'LCC05', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV24', 'LCC05', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV25', 'LCC05', 'K2', 1000000, 9, '12/15/2020');
--
insert into DangKyLopChungChi values ('HV26', 'LCC06', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV27', 'LCC06', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV28', 'LCC06', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV29', 'LCC06', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV30', 'LCC06', 'K2', 1000000, 9, '12/15/2020');

insert into DangKyLopChungChi values ('HV26', 'LCC07', 'K2', 1000000, 5, '12/15/2020');
insert into DangKyLopChungChi values ('HV27', 'LCC07', 'K2', 1000000, 6, '12/15/2020');
insert into DangKyLopChungChi values ('HV28', 'LCC07', 'K2', 1000000, 7, '12/15/2020');
insert into DangKyLopChungChi values ('HV29', 'LCC07', 'K2', 1000000, 8, '12/15/2020');
insert into DangKyLopChungChi values ('HV30', 'LCC07', 'K2', 1000000, 9, '12/15/2020');
--Khoa 3
insert into DangKyLopChungChi values ('HV31', 'LCC01', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV32', 'LCC01', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV33', 'LCC01', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV34', 'LCC01', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV35', 'LCC01', 'K3', 1000000, 9, '06/15/2021');

insert into DangKyLopChungChi values ('HV31', 'LCC02', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV32', 'LCC02', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV33', 'LCC02', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV34', 'LCC02', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV35', 'LCC02', 'K3', 1000000, 9, '06/15/2021');

insert into DangKyLopChungChi values ('HV31', 'LCC03', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV32', 'LCC03', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV33', 'LCC03', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV34', 'LCC03', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV35', 'LCC03', 'K3', 1000000, 9, '06/15/2021');
--
insert into DangKyLopChungChi values ('HV36', 'LCC04', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV37', 'LCC04', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV38', 'LCC04', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV39', 'LCC04', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV40', 'LCC04', 'K3', 1000000, 9, '06/15/2021');

insert into DangKyLopChungChi values ('HV36', 'LCC05', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV37', 'LCC05', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV38', 'LCC05', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV39', 'LCC05', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV40', 'LCC05', 'K3', 1000000, 9, '06/15/2021');
--
insert into DangKyLopChungChi values ('HV41', 'LCC06', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV42', 'LCC06', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV43', 'LCC06', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV44', 'LCC06', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV45', 'LCC06', 'K3', 1000000, 9, '06/15/2021');

insert into DangKyLopChungChi values ('HV41', 'LCC07', 'K3', 1000000, 5, '06/15/2021');
insert into DangKyLopChungChi values ('HV42', 'LCC07', 'K3', 1000000, 6, '06/15/2021');
insert into DangKyLopChungChi values ('HV43', 'LCC07', 'K3', 1000000, 7, '06/15/2021');
insert into DangKyLopChungChi values ('HV44', 'LCC07', 'K3', 1000000, 8, '06/15/2021');
insert into DangKyLopChungChi values ('HV45', 'LCC07', 'K3', 1000000, 9, '06/15/2021');
--Khoa 4
insert into DangKyLopChungChi values ('HV46', 'LCC01', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV47', 'LCC01', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV48', 'LCC01', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV49', 'LCC01', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV50', 'LCC01', 'K4', 1000000, null, '12/15/2021');

insert into DangKyLopChungChi values ('HV46', 'LCC02', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV47', 'LCC02', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV48', 'LCC02', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV49', 'LCC02', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV50', 'LCC02', 'K4', 1000000, null, '12/15/2021');

insert into DangKyLopChungChi values ('HV46', 'LCC03', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV47', 'LCC03', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV48', 'LCC03', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV49', 'LCC03', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV50', 'LCC03', 'K4', 1000000, null, '12/15/2021');
--
insert into DangKyLopChungChi values ('HV51', 'LCC04', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV52', 'LCC04', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV53', 'LCC04', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV54', 'LCC04', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV55', 'LCC04', 'K4', 1000000, null, '12/15/2021');

insert into DangKyLopChungChi values ('HV51', 'LCC05', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV52', 'LCC05', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV53', 'LCC05', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV54', 'LCC05', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV55', 'LCC05', 'K4', 1000000, null, '12/15/2021');
--
insert into DangKyLopChungChi values ('HV56', 'LCC06', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV57', 'LCC06', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV58', 'LCC06', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV59', 'LCC06', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV60', 'LCC06', 'K4', 1000000, null, '12/15/2021');

insert into DangKyLopChungChi values ('HV56', 'LCC07', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV57', 'LCC07', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV58', 'LCC07', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV59', 'LCC07', 'K4', 1000000, null, '12/15/2021');
insert into DangKyLopChungChi values ('HV60', 'LCC07', 'K4', 1000000, null, '12/15/2021');
go

create table HocVien_ChungChi
(
	MaHV varchar(10),
	MaCC varchar(10),
	KetQua int,
	primary key (MaHV, MaCC)
)
go
alter table HocVien_ChungChi add constraint FK_HVCCC_HV foreign key (MaHV) references HocVien(MaHV);
alter table HocVien_ChungChi add constraint FK_HVCCC_CC foreign key (MaCC) references ChungChi(MaCC);
go
alter table HocVien_ChungChi add check (KetQua = null or KetQua = 0 or KetQua = 1)
go
insert into HocVien_ChungChi values ('HV01','CCA', 1);
insert into HocVien_ChungChi values ('HV02','CCA', 1);
insert into HocVien_ChungChi values ('HV03','CCA', 1);
insert into HocVien_ChungChi values ('HV04','CCA', 1);
insert into HocVien_ChungChi values ('HV05','CCA', 1);

insert into HocVien_ChungChi values ('HV06','CCB', 1);
insert into HocVien_ChungChi values ('HV07','CCB', 1);
insert into HocVien_ChungChi values ('HV08','CCB', 1);
insert into HocVien_ChungChi values ('HV09','CCB', 1);
insert into HocVien_ChungChi values ('HV10','CCB', 1);
insert into HocVien_ChungChi values ('HV11','CCB', 1);
insert into HocVien_ChungChi values ('HV12','CCB', 1);
insert into HocVien_ChungChi values ('HV13','CCB', 1);
insert into HocVien_ChungChi values ('HV14','CCB', 1);
insert into HocVien_ChungChi values ('HV15','CCB', 1);

insert into HocVien_ChungChi values ('HV16','CCA', 1);
insert into HocVien_ChungChi values ('HV17','CCA', 1);
insert into HocVien_ChungChi values ('HV18','CCA', 1);
insert into HocVien_ChungChi values ('HV19','CCA', 1);
insert into HocVien_ChungChi values ('HV20','CCA', 1);

insert into HocVien_ChungChi values ('HV21','CCB', 1);
insert into HocVien_ChungChi values ('HV22','CCB', 1);
insert into HocVien_ChungChi values ('HV23','CCB', 1);
insert into HocVien_ChungChi values ('HV24','CCB', 1);
insert into HocVien_ChungChi values ('HV25','CCB', 1);
insert into HocVien_ChungChi values ('HV26','CCB', 1);
insert into HocVien_ChungChi values ('HV27','CCB', 1);
insert into HocVien_ChungChi values ('HV28','CCB', 1);
insert into HocVien_ChungChi values ('HV29','CCB', 1);
insert into HocVien_ChungChi values ('HV30','CCB', 1);

insert into HocVien_ChungChi values ('HV31','CCA', 1);
insert into HocVien_ChungChi values ('HV32','CCA', 1);
insert into HocVien_ChungChi values ('HV33','CCA', 1);
insert into HocVien_ChungChi values ('HV34','CCA', 1);
insert into HocVien_ChungChi values ('HV35','CCA', 1);

insert into HocVien_ChungChi values ('HV36','CCB', 1);
insert into HocVien_ChungChi values ('HV37','CCB', 1);
insert into HocVien_ChungChi values ('HV38','CCB', 1);
insert into HocVien_ChungChi values ('HV39','CCB', 1);
insert into HocVien_ChungChi values ('HV40','CCB', 1);
insert into HocVien_ChungChi values ('HV41','CCB', 1);
insert into HocVien_ChungChi values ('HV42','CCB', 1);
insert into HocVien_ChungChi values ('HV43','CCB', 1);
insert into HocVien_ChungChi values ('HV44','CCB', 1);
insert into HocVien_ChungChi values ('HV45','CCB', 1);

insert into HocVien_ChungChi values ('HV46','CCA', null);
insert into HocVien_ChungChi values ('HV47','CCA', null);
insert into HocVien_ChungChi values ('HV48','CCA', null);
insert into HocVien_ChungChi values ('HV49','CCA', null);
insert into HocVien_ChungChi values ('HV50','CCA', null);

insert into HocVien_ChungChi values ('HV51','CCB', null);
insert into HocVien_ChungChi values ('HV52','CCB', null);
insert into HocVien_ChungChi values ('HV53','CCB', null);
insert into HocVien_ChungChi values ('HV54','CCB', null);
insert into HocVien_ChungChi values ('HV55','CCB', null);
insert into HocVien_ChungChi values ('HV56','CCB', null);
insert into HocVien_ChungChi values ('HV57','CCB', null);
insert into HocVien_ChungChi values ('HV58','CCB', null);
insert into HocVien_ChungChi values ('HV59','CCB', null);
insert into HocVien_ChungChi values ('HV60','CCB', null);

go
create table NhomChuyenDe
(
	MaNCD varchar(10),
	TenNCD varchar(50),
	primary key (MaNCD)
)
go
insert into NhomChuyenDe values ('NCD01', 'Nhom Chuyen De 1');
insert into NhomChuyenDe values ('NCD02', 'Nhom Chuyen De 2');


create table LopChuyenDe
(
	MaLCD varchar(10),
	TenCD varchar(50),
	MaNCD varchar(10),
	primary key (MaLCD)
)
go
alter table LopChuyenDe add constraint FK_LCD_NCD foreign key (MaNCD) references NhomChuyenDe(MaNCD);
go
insert into LopChuyenDe values ('CD01', 'Chuyen De 1', 'NCD01');
insert into LopChuyenDe values ('CD02', 'Chuyen De 2', 'NCD01');
insert into LopChuyenDe values ('CD03', 'Chuyen De 3', 'NCD02');
insert into LopChuyenDe values ('CD04', 'Chuyen De 4', 'NCD02');

create table LopChuyenDeMo
(
	MaLCD varchar(10),
	MaKhoa varchar(10),
	LichHoc varchar(100),
	MaGV varchar(10),
	isFull int,
	primary key (MaLCD, MaKhoa)
)
go
alter table LopChuyenDeMo add constraint FK_LCDM_LCD foreign key (MaLCD) references LopChuyenDe(MaLCD);
alter table LopChuyenDeMo add constraint FK_LCDM_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
alter table LopChuyenDeMo add constraint FK_LCDM_GV foreign key (MaGV) references GiangVien(MaGV);
go
insert into LopChuyenDeMo values ('CD01', 'K1', 'C101, 12:30, Thu 2, 4, 6', 'GV11',1);
insert into LopChuyenDeMo values ('CD02', 'K1', 'C102, 12:30, Thu 2, 4, 6', 'GV12',1);
insert into LopChuyenDeMo values ('CD03', 'K1', 'C103, 12:30, Thu 2, 4, 6', 'GV13',1);
insert into LopChuyenDeMo values ('CD04', 'K1', 'C104, 12:30, Thu 2, 4, 6', 'GV14',1);

insert into LopChuyenDeMo values ('CD01', 'K2', 'C101, 12:30, Thu 2, 4, 6', 'GV11',1);
insert into LopChuyenDeMo values ('CD02', 'K2', 'C102, 12:30, Thu 2, 4, 6', 'GV12',1);
insert into LopChuyenDeMo values ('CD03', 'K2', 'C103, 12:30, Thu 2, 4, 6', 'GV13',1);
insert into LopChuyenDeMo values ('CD04', 'K2', 'C104, 12:30, Thu 2, 4, 6', 'GV14',1);

insert into LopChuyenDeMo values ('CD01', 'K3', 'C101, 12:30, Thu 2, 4, 6', 'GV11',1);
insert into LopChuyenDeMo values ('CD02', 'K3', 'C102, 12:30, Thu 2, 4, 6', 'GV12',1);
insert into LopChuyenDeMo values ('CD03', 'K3', 'C103, 12:30, Thu 2, 4, 6', 'GV13',1);
insert into LopChuyenDeMo values ('CD04', 'K3', 'C104, 12:30, Thu 2, 4, 6', 'GV14',1);

insert into LopChuyenDeMo values ('CD01', 'K4', 'C101, 12:30, Thu 2, 4, 6', 'GV11',1);
insert into LopChuyenDeMo values ('CD02', 'K4', 'C102, 12:30, Thu 2, 4, 6', 'GV12',1);
insert into LopChuyenDeMo values ('CD03', 'K4', 'C103, 12:30, Thu 2, 4, 6', 'GV13',1);
insert into LopChuyenDeMo values ('CD04', 'K4', 'C104, 12:30, Thu 2, 4, 6', 'GV14',1);

go

create table DangKyLopChuyenDe 
(
	MaHV varchar(10),
	MaLCD varchar(10),
	MaKhoa varchar(10),
	HocPhi int,
	primary key (MaHV, MaLCD, MaKhoa)
)
go
alter table DangKyLopChuyenDe add constraint FK_DKLCD_HV foreign key (MaHV) references HocVien(MaHV);
alter table DangKyLopChuyenDe add constraint FK_DKLCD_LCDM foreign key (MaLCD,MaKhoa) references LopChuyenDeMo(MaLCD,MaKhoa);
go
alter table DangKyLopChuyenDe add check (HocPhi > 0);
go
--21-30 hoc 1-2 31-40 hoc 3-4
insert into DangKyLopChuyenDe values ('HV21', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV22', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV23', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV24', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV25', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV26', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV27', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV28', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV29', 'CD01', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV30', 'CD01', 'K1', 1500000);

insert into DangKyLopChuyenDe values ('HV21', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV22', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV23', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV24', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV25', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV26', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV27', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV28', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV29', 'CD02', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV30', 'CD02', 'K1', 1500000);

insert into DangKyLopChuyenDe values ('HV31', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV32', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV33', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV34', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV35', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV36', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV37', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV38', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV39', 'CD03', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV40', 'CD03', 'K1', 1500000);

insert into DangKyLopChuyenDe values ('HV31', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV32', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV33', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV34', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV35', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV36', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV37', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV38', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV39', 'CD04', 'K1', 1500000);
insert into DangKyLopChuyenDe values ('HV40', 'CD04', 'K1', 1500000);
--k2
insert into DangKyLopChuyenDe values ('HV21', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV22', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV23', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV24', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV25', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV26', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV27', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV28', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV29', 'CD03', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV30', 'CD03', 'K2', 1500000);

insert into DangKyLopChuyenDe values ('HV21', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV22', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV23', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV24', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV25', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV26', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV27', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV28', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV29', 'CD04', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV30', 'CD04', 'K2', 1500000);

insert into DangKyLopChuyenDe values ('HV31', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV32', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV33', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV34', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV35', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV36', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV37', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV38', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV39', 'CD01', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV40', 'CD01', 'K2', 1500000);

insert into DangKyLopChuyenDe values ('HV31', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV32', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV33', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV34', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV35', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV36', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV37', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV38', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV39', 'CD02', 'K2', 1500000);
insert into DangKyLopChuyenDe values ('HV40', 'CD02', 'K2', 1500000);
--k3
insert into DangKyLopChuyenDe values ('HV41', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV42', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV43', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV44', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV45', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV46', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV47', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV48', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV49', 'CD03', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV50', 'CD03', 'K3', 1500000);

insert into DangKyLopChuyenDe values ('HV41', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV42', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV43', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV44', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV45', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV46', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV47', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV48', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV49', 'CD04', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV50', 'CD04', 'K3', 1500000);

insert into DangKyLopChuyenDe values ('HV51', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV52', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV53', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV54', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV55', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV56', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV57', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV58', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV59', 'CD01', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV60', 'CD01', 'K3', 1500000);

insert into DangKyLopChuyenDe values ('HV51', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV52', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV53', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV54', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV55', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV56', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV57', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV58', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV59', 'CD02', 'K3', 1500000);
insert into DangKyLopChuyenDe values ('HV60', 'CD02', 'K3', 1500000);
--k4
insert into DangKyLopChuyenDe values ('HV41', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV42', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV43', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV44', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV45', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV46', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV47', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV48', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV49', 'CD01', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV50', 'CD01', 'K4', 1500000);

insert into DangKyLopChuyenDe values ('HV41', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV42', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV43', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV44', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV45', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV46', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV47', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV48', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV49', 'CD02', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV50', 'CD02', 'K4', 1500000);

insert into DangKyLopChuyenDe values ('HV51', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV52', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV53', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV54', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV55', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV56', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV57', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV58', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV59', 'CD03', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV60', 'CD03', 'K4', 1500000);

insert into DangKyLopChuyenDe values ('HV51', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV52', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV53', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV54', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV55', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV56', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV57', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV58', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV59', 'CD04', 'K4', 1500000);
insert into DangKyLopChuyenDe values ('HV60', 'CD04', 'K4', 1500000);

go
create table HocVien_TotNghiep
(
	MaHV varchar(10),
	MaKhoa varchar(10),
	Diem float,
	PhiDuThi int,
	NgayThi date,
	MaGV varchar(10),
	primary key (MaHV, MaKhoa)
)
go 
alter table HocVien_TotNghiep add constraint FK_HVTN_HV foreign key (MaHV) references HocVien(MaHV);
alter table HocVien_TotNghiep add constraint FK_HVTN_Khoa foreign key (MaKhoa) references Khoa(MaKhoa);
alter table HocVien_TotNghiep add constraint FK_HVTN_GV foreign key (MaGV) references GiangVien(MaGV);
go
alter table HocVien_TotNghiep add check (PhiDuThi > 0);
alter table HocVien_TotNghiep add check ((Diem >= 0 and Diem <= 10) or Diem = null);
go
insert into HocVien_TotNghiep values ('HV01', 'K2', 5, 100000, '12/30/2020', 'GV01');
insert into HocVien_TotNghiep values ('HV02', 'K2', 6, 100000, '12/30/2020', 'GV02');
insert into HocVien_TotNghiep values ('HV03', 'K2', 7, 100000, '12/30/2020', 'GV03');
insert into HocVien_TotNghiep values ('HV04', 'K2', 8, 100000, '12/30/2020', 'GV04');
insert into HocVien_TotNghiep values ('HV05', 'K2', 9, 100000, '12/30/2020', 'GV05');
insert into HocVien_TotNghiep values ('HV06', 'K2', 6, 100000, '12/30/2020', 'GV06');
insert into HocVien_TotNghiep values ('HV07', 'K2', 9, 100000, '12/30/2020', 'GV07');
insert into HocVien_TotNghiep values ('HV08', 'K2', 8, 100000, '12/30/2020', 'GV08');
insert into HocVien_TotNghiep values ('HV09', 'K2', 4.5, 100000, '12/30/2020', 'GV09');
insert into HocVien_TotNghiep values ('HV10', 'K2', 1, 100000, '12/30/2020', 'GV10');

insert into HocVien_TotNghiep values ('HV09', 'K3', 5, 100000, '12/30/2020', 'GV09');
insert into HocVien_TotNghiep values ('HV10', 'K3', 10, 100000, '12/30/2020', 'GV10');





go


--insert,delete hoc vien, giang vien --> account
-- trg diem trung binh

-- proc: lấy ra 3 môn bắt buộc của học phần mà student đó đang update
go
create or alter proc checkPassedAllSub
	@studentID varchar(10),@NHP_ID varchar(10), @check int output
as
begin
	
	set @check = 1
	declare c cursor for select distinct bd.MaHV,bd.MaMon,bd.MaKhoa,bd.LanThi from Mon m, LopKTVMo lm, BangDiem bd,HocVien hv, DangKiNhomHocPhan dk 
												 where m.MaMon = lm.MaMon and bd.MaMon = lm.MaMon and hv.MaHV= bd.MaHV and hv.MaHV = dk.MaHV and m.MaNHP=dk.MaNHP and hv.MaHV = @studentID and m.BatBuoc = 1 and dk.MaNHP = @NHP_ID and bd.LanThi = 1

	open c
	declare @idStud varchar(10)
	declare @idSubj varchar(10)
	declare @idCour varchar(10)
	declare @examCount int
	fetch next from c into @idStud,@idSubj,@idCour,@examCount
	while(@@fetch_status=0)
	begin
		declare @temp int
		select @temp = DiemThi from BangDiem where MaHV = @idStud and MaMon = @idSubj and MaKhoa = @idCour and LanThi = @examCount
		if (@temp = null)
			set @check = 0
			fetch next from c into @idStud,@idSubj,@idCour,@examCount
	end
	close c
	deallocate c
end;


go
--proc kiểm tra xem 1 môn truyền vào có phải là môn bắt buộc không
create or alter proc checkSubjectIsRequired 
	@subjectID varchar(10), @check int output
as
begin
	declare @temp bit;
	select @temp = BatBuoc from Mon where MaMon = @subjectID
	if (@temp = 1) set @check = 1
	else set @check = 0
end

go

--> khi update 1 bảng điểm của môn bắt buộc -> check thi hết 3 môn bắt buộc chưa? -> nếu thi rồi thì update DTB ở DK NHP 
--> nếu DTB < 5 thì insert 3 row BangDiem cho 3 môn bắt buộc với số lần thi lại tăng lên và ngày thi = ngày thi gần nhất + 3 


go
create or alter proc updateDTB 
	@studentID varchar(10), @NHP_ID varchar(10), @courseID varchar(10)
as
begin 
	declare c cursor for select distinct  bd.DiemThi,bd.MaMon
						 from Mon m, LopKTVMo lm, BangDiem bd,HocVien hv, DangKiNhomHocPhan dk 
						 where m.MaMon = lm.MaMon and bd.MaMon = lm.MaMon and hv.MaHV= bd.MaHV and hv.MaHV = dk.MaHV and m.MaNHP=dk.MaNHP 
									and hv.MaHV = @studentID and m.BatBuoc = 1 and dk.MaNHP = @NHP_ID and bd.MaKhoa = @courseID
									and bd.LanThi >= all(select bd.LanThi from Mon m, LopKTVMo lm, BangDiem bd,HocVien hv, DangKiNhomHocPhan dk 
														 where m.MaMon = lm.MaMon and bd.MaMon = lm.MaMon and hv.MaHV= bd.MaHV and hv.MaHV = dk.MaHV and bd.MaKhoa = @courseID
															   and m.MaNHP=dk.MaNHP and hv.MaHV = @studentID and m.BatBuoc = 1 and dk.MaNHP = @NHP_ID)
	declare @total float = 0
	declare @count int = 0;
	declare @DiemThi float
	declare @subID varchar(10)
	open c
	fetch next from c into @DiemThi,@subID
	while(@@fetch_status=0)
	begin
		print(cast(@DiemThi as varchar))
		set @total += @DiemThi
		set @count += 1
		fetch next from c into @DiemThi,@subID
	end
	print(cast(@total/@count as varchar))
	print(cast(@total as varchar))
	print(cast(@count as varchar))
	update DangKiNhomHocPhan set DTB = @total/@count where MaHV = @studentID and MaNHP = @NHP_ID and MaKhoa = @courseID
	close c
	deallocate c

end


--BangDiem  lần thi 1 -> rớt -> insert lần thi 2 nhưng chưa thi : điểm là null 
--> nếu đã thi lại 3 môn bb ở lần thi 2 ( check 3 môn bb -> != null) -> số lần thi lại lên 1

--DangKiNHP số lần thi lại 0

-- after -> update rồi 
-- kiểm tra có phải môn bắt buộc? 
-- kiểm tra (lần thi - 1 != số lần thi lại) thì reset DTB và số lần thi lại = lần thi -1 
-->  kiểm tra thi hết 3 môn bắt buộc chưa ? -> 
-- nếu có thì thực hiện update DTB  
-- nếu DTB < 5 và if ( lần thi  <= 4 ) thì tăng số thi lại lên 1 và insert 3 row


go
create or alter proc insertNewBangDiem
	@maHV varchar(10), @maKhoa varchar(10), @lanthi varchar(10), @date date, @NHP_ID varchar(10)
	
as
begin
	
	declare c cursor for select distinct bd.MaHV,bd.MaMon,bd.MaKhoa,bd.LanThi from Mon m, LopKTVMo lm, BangDiem bd,HocVien hv, DangKiNhomHocPhan dk 
												 where m.MaMon = lm.MaMon and bd.MaMon = lm.MaMon and hv.MaHV= bd.MaHV and hv.MaHV = dk.MaHV and m.MaNHP=dk.MaNHP and hv.MaHV = @maHV and m.BatBuoc = 1 and dk.MaNHP = @NHP_ID and bd.LanThi = 1

	open c
	declare @idStud varchar(10)
	declare @idSubj varchar(10)
	declare @idCour varchar(10)
	declare @examCount int
	fetch next from c into @idStud,@idSubj,@idCour,@examCount
	while(@@fetch_status=0)
	begin
		insert into BangDiem values (@maHV, @idSubj ,@maKhoa, @lanthi + 1, null, dateadd(day,3,@date))
		fetch next from c into @idStud,@idSubj,@idCour,@examCount
	end
	close c
	deallocate c
end;




go
create or alter trigger trg_update_BangDiem
on BangDiem
after update 
as
begin
	declare @check int
	declare @mon varchar(10)
	declare @maHV varchar(10)
	declare @maKhoa varchar(10)
	select @mon =MaMon,@maHV = MaHV, @maKhoa = MaKhoa from inserted
	exec checkSubjectIsRequired @mon, @check output
	if (@check = 1)
	begin
		declare @lanthi int
		declare @solanthilai int
		declare @maNHP varchar(10)
		declare @DTB float
		declare @date date
		select @lanthi=LanThi from inserted
		select @maNHP= m.MaNHP from Mon m where m.MaMon = @mon
		select @solanthilai=SoLanThiLai from DangKiNhomHocPhan where MaHV = @maHV and MaNHP = @maNHP and MaKhoa = @maKhoa
		select @date =NgayThi from inserted
		if (@lanthi - @solanthilai != 1) 
		begin
			update DangKiNhomHocPhan set DTB = null, SoLanThiLai = @lanthi -1 where MaHV = @maHV and MaNHP = @maNHP and MaKhoa = @maKhoa
		end
		declare @check2 int
		exec checkPassedAllSub @maHV, @maNHP, @check2 output
		if (@check2 = 1) 
		begin
			exec updateDTB @maHV, @maNHP, @maKhoa 
		end
		select @DTB = DTB from DangKiNhomHocPhan where MaHV = @maHV and MaNHP = @maNHP and MaKhoa = @maKhoa
		if (@DTB < 5 and @lanthi < 4)
		begin
			exec insertNewBangDiem @maHV, @maKhoa, @lanthi, @date, @maNHP
		end
	end
end;





--proc  insert Bảng Điểm của tất cả các môn của 1 NHP
go
create or alter proc insertBangDiem
	@maHV varchar(10), @maKhoa varchar(10),  @NHP_ID varchar(10)	
as
begin
	declare @date date
	select @date = NgayKT from Khoa where MaKhoa = @maKhoa
	set @date = dateadd(day,-15, @date) 
	declare c cursor for select MaMon from Mon where MaNHP = @NHP_ID;
	open c
	declare @idSubj varchar(10)
	fetch next from c into @idSubj
	while(@@fetch_status=0)
	begin
		insert into BangDiem values (@maHV, @idSubj ,@maKhoa, 1, null, @date)
		fetch next from c into @idSubj
	end
	close c
	deallocate c
end;
go
--trigger HV Đăng kí 1 nhóm học phần thì thêm tất cả Bảng điểm của môn có Học phần đó
create or alter trigger trg_insert_DKNHP
on DangKiNhomHocPhan
after insert
as
begin
	declare @studentID varchar(10)
	declare @courseID varchar(10)
	declare @NHP_ID varchar(10)
	select @studentID = MaHV,@courseID = MaKhoa,@NHP_ID =  MaNHP from inserted
	exec insertBangDiem @studentID,@courseID,@NHP_ID
end;


--proc  insert LopKTV Mo của tất cả các môn của 1 NHP Khi Thêm mới 1 NHP Mo
go
create or alter proc insertLopKTVMo
	@maKhoa varchar(10),  @NHP_ID varchar(10)	
as
begin
	declare c cursor for select MaMon from Mon where MaNHP = @NHP_ID;
	open c
	declare @idSubj varchar(10)
	fetch next from c into @idSubj
	while(@@fetch_status=0)
	begin
		insert into LopKTVMo values (@idSubj,@maKhoa, null, null)
		fetch next from c into @idSubj
	end
	close c
	deallocate c
end;

go
--trigger Thêm 1 NHP Mo thi Auto insert cac Lop KTV Mo cua NHP do
create or alter trigger trg_insert_LKTVMo
on NhomHocPhanMo
after insert
as
begin
	declare @courseID varchar(10)
	declare @NHP_ID varchar(10)
	select @courseID = MaKhoa,@NHP_ID =  MaNHP from inserted
	exec insertLopKTVMo @courseID,@NHP_ID
	update NhomHocPhanMo set isFull = 1 where MaNHP = @NHP_ID and MaKhoa = @courseID
end;






go
--trigger xóa HV -> xóa account
create or alter trigger trg_delete_HocVien
on HocVien
after delete
as
begin
	declare @id varchar(10)
	select @id = MaHV from deleted
	delete from Account where username = @id
end;
--drop trigger trg_delete_HocVien
go
--trigger thêm HV -> thêm account
create or alter trigger trg_insert_HocVien
on HocVien
after insert 
as
begin
	declare @id varchar(10)
	select @id = MaHV from inserted
	insert into Account values (@id,'a','3')
end;

go
--trigger xóa GV -> xóa account
create or alter trigger trg_delete_GiangVien
on GiangVien
after delete
as
begin
	declare @id varchar(10)
	select @id = MaGV from deleted
	delete from Account where username = @id
end;


go
--trigger thêm GV -> thêm account
create or alter trigger trg_insert_GiangVien
on GiangVien
after insert 
as
begin
	declare @id varchar(10)
	select @id = MaGV from inserted
	insert into Account values (@id,'a','2')
end;

go
--trigger set isFull = 1 khi LopCCMo
create or alter trigger trg_insert_LopCCMo
on LopChungChiMo
after insert 
as
begin
	declare @courseID varchar(10)
	declare @LCC_ID varchar(10)
	select @courseID = MaKhoa,@LCC_ID =  MaLCC from inserted
	update LopChungChiMo set isFull = 1 where MaLCC = @LCC_ID and MaKhoa = @courseID
end;

--trigger set isFull = 1 khi LopCDMo
go
create or alter trigger trg_insert_LopCDMo
on LopChuyenDeMo
after insert 
as
begin
	declare @courseID varchar(10)
	declare @LCD_ID varchar(10)
	select @courseID = MaKhoa,@LCD_ID =  MaLCD from inserted
	update LopChuyenDeMo set isFull = 1 where MaLCD = @LCD_ID and MaKhoa = @courseID
end;





go
--proc kiem tra si so 1 nhom hoc phan mo? da full hay chua? 
create or alter proc checkNHPIsFull
	@maKhoa varchar(10),  @NHP_ID varchar(10), @check int output
as
begin
	set @check = 0
	declare @idSub varchar(10)
	declare @count int = 0
	select top(1) @idSub = MaMon from Mon where MaNHP = @NHP_ID
	select @count = count(*) from LopKTVMo l, BangDiem b where l.MaKhoa = b.MaKhoa and l.MaMon = b.MaMon and l.MaKhoa = @maKhoa and l.MaMon = @idSub and b.LanThi = 1
	if (@count >= 10) set @check = 1
end;


go
-- trigger update isFull = 1 khi so luong hoc sinh = 10 khi insert bang DangKyNhomHocPhan
create or alter trigger trg_check_isFull_NHPMo
on DangKyNhomHocPhan
after insert 
as
begin
	declare @courseID varchar(10)
	declare @NHP_ID varchar(10)
	declare @check int
	select @courseID = MaKhoa,@NHP_ID = MaNHP from inserted
	exec checkNHPIsFull @courseID, @NHP_ID, @check output
	if (@check = 1) 
		update NhomHocPhanMo set isFull = 1 where MaKhoa = @courseID and MaNHP = @NHP_ID
end;

go
-- trigger update isFull = 1 khi so luong hoc sinh = 10 khi insert bang DangKyLopChungChi
create or alter trigger trg_check_isFull_LopCCMo
on DangKyLopChungChi
after insert 
as
begin
	declare @courseID varchar(10)
	declare @LCC_ID varchar(10)
	declare @count int = 0
	select @courseID = MaKhoa,@LCC_ID = MaLCC from inserted
	select @count = count(*) from LopChungChiMo l, DangKyLopChungChi d where l.MaLCC = @LCC_ID and l.MaKhoa = @courseID and l.MaLCC = d.MaLCC and l.MaKhoa = d.MaKhoa
	if (@count >= 10) 
		update LopChungChiMo set isFull = 1 where MaKhoa = @courseID and MaLCC = @LCC_ID
end;


go
-- trigger update isFull = 1 khi so luong hoc sinh = 10 khi insert bang DangKyLopChuyenDe
create or alter trigger trg_check_isFull_LopCDMo
on DangKyLopChuyenDe
after insert 
as
begin
	declare @courseID varchar(10)
	declare @LCD_ID varchar(10)
	declare @count int = 0
	select @courseID = MaKhoa,@LCD_ID = MaLCD from inserted
	select @count = count(*) from LopChuyenDeMo l, DangKyLopChuyenDe d where l.MaLCD = @LCD_ID and l.MaKhoa = @courseID and l.MaLCD = d.MaLCD and l.MaKhoa = d.MaKhoa
	if (@count >= 10) 
		update LopChungChiMo set isFull = 1 where MaKhoa = @courseID and MaLCC = @LCD_ID
end;