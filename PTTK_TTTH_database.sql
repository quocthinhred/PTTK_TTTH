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
insert into Account values ('admin', 'admin', 1);
insert into Account values ('GV01', 'a', 2);
insert into Account values ('GV01', 'a', 2);
insert into Account values ('GV02', 'a', 2);
insert into Account values ('GV03', 'a', 2);
insert into Account values ('GV04', 'a', 2);
insert into Account values ('GV05', 'a', 2);
insert into Account values ('HV01', 'a', 3);
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
insert into GiangVien values ('GV01', 'Nguyễn Văn A', '1990', '0123456789');
insert into GiangVien values ('GV02', 'Nguyễn Văn B', '1991', '0123456788');
insert into GiangVien values ('GV03', 'Nguyễn Văn C', '1992', '0123456787');
insert into GiangVien values ('GV04', 'Nguyễn Văn D', '1993', '0123456786');
insert into GiangVien values ('GV05', 'Nguyễn Văn E', '1994', '0123456785');
insert into GiangVien values ('GV06', 'Nguyễn Văn F', '1990', '0123456784');
insert into GiangVien values ('GV07', 'Nguyễn Văn G', '1991', '0123456783');
insert into GiangVien values ('GV08', 'Nguyễn Văn H', '1992', '0123456782');
insert into GiangVien values ('GV09', 'Nguyễn Văn J', '1993', '0123456781');
insert into GiangVien values ('GV10', 'Nguyễn Văn K', '1994', '0123456780');
insert into GiangVien values ('GV11', 'Nguyễn Văn L', '1990', '0123456789');
insert into GiangVien values ('GV12', 'Nguyễn Văn M', '1991', '0123456788');
insert into GiangVien values ('GV13', 'Nguyễn Văn N', '1992', '0123456787');
insert into GiangVien values ('GV14', 'Nguyễn Văn O', '1993', '0123456786');

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
insert into HocVien values ('HV01', 'Trần Văn A', '2000', '0123456789');
insert into HocVien values ('HV02', 'Trần Văn B', '2001', '0123456778');
insert into HocVien values ('HV03', 'Trần Văn C', '2002', '0123456767');
insert into HocVien values ('HV04', 'Trần Văn D', '2003', '0123456756');
insert into HocVien values ('HV05', 'Trần Văn E', '2001', '0123456745');
insert into HocVien values ('HV06', 'Trần Văn F', '2002', '0123456734');
insert into HocVien values ('HV07', 'Trần Văn G', '2003', '0123456723');
insert into HocVien values ('HV08', 'Trần Văn H', '2001', '0123456712');
insert into HocVien values ('HV09', 'Trần Văn J', '2002', '0123456701');
insert into HocVien values ('HV10', 'Trần Văn K', '2003', '0123456790');

insert into HocVien values ('HV11', 'Phan Văn A', '2000', '0123456789');
insert into HocVien values ('HV12', 'Phan Văn B', '2001', '0123456778');
insert into HocVien values ('HV13', 'Phan Văn C', '2002', '0123456767');
insert into HocVien values ('HV14', 'Phan Văn D', '2003', '0123456756');
insert into HocVien values ('HV15', 'Phan Văn E', '2001', '0123456745');
insert into HocVien values ('HV16', 'Phan Văn F', '2002', '0123456734');
insert into HocVien values ('HV17', 'Phan Văn G', '2003', '0123456723');
insert into HocVien values ('HV18', 'Phan Văn H', '2001', '0123456712');
insert into HocVien values ('HV19', 'Phan Văn J', '2002', '0123456701');
insert into HocVien values ('HV20', 'Phan Văn K', '2003', '0123456790');

insert into HocVien values ('HV21', 'Phạm Văn A', '2000', '0123456789');
insert into HocVien values ('HV22', 'Phạm Văn B', '2001', '0123456778');
insert into HocVien values ('HV23', 'Phạm Văn C', '2002', '0123456767');
insert into HocVien values ('HV24', 'Phạm Văn D', '2003', '0123456756');
insert into HocVien values ('HV25', 'Phạm Văn E', '2001', '0123456745');
insert into HocVien values ('HV26', 'Phạm Văn F', '2002', '0123456734');
insert into HocVien values ('HV27', 'Phạm Văn G', '2003', '0123456723');
insert into HocVien values ('HV28', 'Phạm Văn H', '2001', '0123456712');
insert into HocVien values ('HV29', 'Phạm Văn J', '2002', '0123456701');
insert into HocVien values ('HV30', 'Phạm Văn K', '2003', '0123456790');

insert into HocVien values ('HV31', 'Phùng Văn A', '2000', '0123456789');
insert into HocVien values ('HV32', 'Phùng Văn B', '2001', '0123456778');
insert into HocVien values ('HV33', 'Phùng Văn C', '2002', '0123456767');
insert into HocVien values ('HV34', 'Phùng Văn D', '2003', '0123456756');
insert into HocVien values ('HV35', 'Phùng Văn E', '2001', '0123456745');
insert into HocVien values ('HV36', 'Phùng Văn F', '2002', '0123456734');
insert into HocVien values ('HV37', 'Phùng Văn G', '2003', '0123456723');
insert into HocVien values ('HV38', 'Phùng Văn H', '2001', '0123456712');
insert into HocVien values ('HV39', 'Phùng Văn J', '2002', '0123456701');
insert into HocVien values ('HV40', 'Phùng Văn K', '2003', '0123456790');

insert into HocVien values ('HV41', 'Hồ Văn A', '2000', '0123456789');
insert into HocVien values ('HV42', 'Hồ Văn B', '2001', '0123456778');
insert into HocVien values ('HV43', 'Hồ Văn C', '2002', '0123456767');
insert into HocVien values ('HV44', 'Hồ Văn D', '2003', '0123456756');
insert into HocVien values ('HV45', 'Hồ Văn E', '2001', '0123456745');
insert into HocVien values ('HV46', 'Hồ Văn F', '2002', '0123456734');
insert into HocVien values ('HV47', 'Hồ Văn G', '2003', '0123456723');
insert into HocVien values ('HV48', 'Hồ Văn H', '2001', '0123456712');
insert into HocVien values ('HV49', 'Hồ Văn J', '2002', '0123456701');
insert into HocVien values ('HV50', 'Hồ Văn K', '2003', '0123456790');

insert into HocVien values ('HV51', 'Lê Văn A', '2000', '0123456789');
insert into HocVien values ('HV52', 'Lê Văn B', '2001', '0123456778');
insert into HocVien values ('HV53', 'Lê Văn C', '2002', '0123456767');
insert into HocVien values ('HV54', 'Lê Văn D', '2003', '0123456756');
insert into HocVien values ('HV55', 'Lê Văn E', '2001', '0123456745');
insert into HocVien values ('HV56', 'Lê Văn F', '2002', '0123456734');
insert into HocVien values ('HV57', 'Lê Văn G', '2003', '0123456723');
insert into HocVien values ('HV58', 'Lê Văn H', '2001', '0123456712');
insert into HocVien values ('HV59', 'Lê Văn J', '2002', '0123456701');
insert into HocVien values ('HV60', 'Lê Văn K', '2003', '0123456790');
go
create table Khoa
(
	MaKhoa varchar(10),
	NgayBD date,
	NgayKT date,
	primary key (MaKhoa)
)
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
	primary key (MaNHP,MaKhoa)
)
go
insert into NhomHocPhanMo values ('NHP01','K1');
insert into NhomHocPhanMo values ('NHP02','K2');
insert into NhomHocPhanMo values ('NHP01','K3');
insert into NhomHocPhanMo values ('NHP02','K4');
go

create table LopKTVMo
(
	MaMon varchar(10),
	MaKhoa varchar(10),
	MaGV varchar(10),
	LichHoc nvarchar(100),
	primary key(MaMon, MaKhoa)
)
go
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV01', 'M01', 'Phòng E101, 17:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV02', 'M02', 'Phòng E102, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV03', 'M03', 'Phòng E103, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV04', 'M04', 'Phòng E104, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K1', 'GV05', 'M05', 'Phòng E105, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV01', 'M06', 'Phòng E101, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV02', 'M07', 'Phòng E102, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV03', 'M08', 'Phòng E103, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV04', 'M09', 'Phòng E104, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K2', 'GV05', 'M10', 'Phòng E105, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV01', 'M01', 'Phòng E101, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV02', 'M02', 'Phòng E102, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV03', 'M03', 'Phòng E103, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV04', 'M04', 'Phòng E104, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K3', 'GV05', 'M05', 'Phòng E105, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV01', 'M06', 'Phòng E101, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV02', 'M07', 'Phòng E102, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV03', 'M08', 'Phòng E103, 17:00 Thứ 3, 5, 7');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV04', 'M09', 'Phòng E104, 19:00 Thứ 2, 4, 6');
insert into LopKTVMo(MaKhoa,MaGV,MaMon,LichHoc) values ('K4', 'GV05', 'M10', 'Phòng E105, 17:00 Thứ 3, 5, 7');


go
create table DangKiNhomHocPhan
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
insert into DangKiNhomHocPhan values ('HV01','NHP01','K1',8,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV02','NHP01','K1',9,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV03','NHP01','K1',9.5,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV04','NHP01','K1',7,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV05','NHP01','K1',7.5,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV06','NHP01','K1',6,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV07','NHP01','K1',7,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV08','NHP01','K1',9,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV09','NHP01','K1',5,1000000,1,1);
insert into DangKiNhomHocPhan values ('HV10','NHP01','K1',8,1000000,1,1);

insert into DangKiNhomHocPhan values ('HV01','NHP02','K2',8,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV02','NHP02','K2',9,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV03','NHP02','K2',9.5,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV04','NHP02','K2',7,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV05','NHP02','K2',7.5,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV06','NHP02','K2',6,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV07','NHP02','K2',7,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV08','NHP02','K2',9,1500000,0,1);
insert into DangKiNhomHocPhan values ('HV09','NHP02','K2',6,1500000,1,1);
insert into DangKiNhomHocPhan values ('HV10','NHP02','K2',7,1500000,1,1);

insert into DangKiNhomHocPhan values ('HV11','NHP01','K3',8,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV12','NHP01','K3',9,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV13','NHP01','K3',9.5,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV14','NHP01','K3',7,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV15','NHP01','K3',7.5,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV16','NHP01','K3',6,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV17','NHP01','K3',7,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV18','NHP01','K3',9,1000000,0,1);
insert into DangKiNhomHocPhan values ('HV19','NHP01','K3',5,1000000,1,1);
insert into DangKiNhomHocPhan values ('HV20','NHP01','K3',8,1000000,1,1);

insert into DangKiNhomHocPhan values ('HV11','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV12','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV13','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV14','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV15','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV16','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV17','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV18','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV19','NHP02','K4',null,1500000,0,null);
insert into DangKiNhomHocPhan values ('HV20','NHP02','K4',null,1500000,0,null);
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

insert into Nhanh values ('NCCA1', 'Nhanh chung chi A 1', 'CCA');
insert into Nhanh values ('NCCB1', 'Nhanh chung chi B 1', 'CCB');
insert into Nhanh values ('NCCB2', 'Nhanh chung chi B 2', 'CCB');

go
create table LopChungChi
(
	MaLCC varchar(10),
	MaNhanh varchar(10),
	primary key (MaLCC)
)
go
insert into LopChungChi values ('LCC01', 'NCCA1');
insert into LopChungChi values ('LCC02', 'NCCA1');
insert into LopChungChi values ('LCC03', 'NCCA1');

insert into LopChungChi values ('LCC04', 'NCCB1');
insert into LopChungChi values ('LCC05', 'NCCB1');
insert into LopChungChi values ('LCC06', 'NCCB2');
insert into LopChungChi values ('LCC07', 'NCCB2');


create table LopChungChiMo
(
	MaLCC varchar(10),
	MaKhoa varchar(10),
	LichHoc varchar(100),
	MaGV varchar(10),
	primary key (MaLCC, MaKhoa)
)
go
insert into LopChungChiMo values ('LCC01', 'K1', 'A101, 7:30, Thu 2, 4, 6', 'GV06');
insert into LopChungChiMo values ('LCC02', 'K1', 'A102, 7:30, Thu 3, 5, 7', 'GV07');
insert into LopChungChiMo values ('LCC03', 'K1', 'A103, 9:30, Thu 2, 4, 6', 'GV08');
insert into LopChungChiMo values ('LCC01', 'K2', 'A101, 7:30, Thu 2, 4, 6', 'GV06');
insert into LopChungChiMo values ('LCC02', 'K2', 'A102, 7:30, Thu 3, 5, 7', 'GV07');
insert into LopChungChiMo values ('LCC03', 'K2', 'A103, 9:30, Thu 2, 4, 6', 'GV08');
insert into LopChungChiMo values ('LCC01', 'K3', 'A101, 7:30, Thu 2, 4, 6', 'GV06');
insert into LopChungChiMo values ('LCC02', 'K3', 'A102, 7:30, Thu 3, 5, 7', 'GV07');
insert into LopChungChiMo values ('LCC03', 'K3', 'A103, 9:30, Thu 2, 4, 6', 'GV08');
insert into LopChungChiMo values ('LCC01', 'K4', 'A101, 7:30, Thu 2, 4, 6', 'GV06');
insert into LopChungChiMo values ('LCC02', 'K4', 'A102, 7:30, Thu 3, 5, 7', 'GV07');
insert into LopChungChiMo values ('LCC03', 'K4', 'A103, 9:30, Thu 2, 4, 6', 'GV08');

insert into LopChungChiMo values ('LCC04', 'K1', 'B102, 7:30, Thu 3, 5, 7', 'GV09');
insert into LopChungChiMo values ('LCC05', 'K1', 'B103, 7:30, Thu 2, 4, 6', 'GV10');
insert into LopChungChiMo values ('LCC04', 'K2', 'B102, 7:30, Thu 3, 5, 7', 'GV09');
insert into LopChungChiMo values ('LCC05', 'K2', 'B103, 7:30, Thu 2, 4, 6', 'GV10');
insert into LopChungChiMo values ('LCC04', 'K3', 'B102, 7:30, Thu 3, 5, 7', 'GV09');
insert into LopChungChiMo values ('LCC05', 'K3', 'B103, 7:30, Thu 2, 4, 6', 'GV10');
insert into LopChungChiMo values ('LCC04', 'K4', 'B102, 7:30, Thu 3, 5, 7', 'GV09');
insert into LopChungChiMo values ('LCC05', 'K4', 'B103, 7:30, Thu 2, 4, 6', 'GV10');

insert into LopChungChiMo values ('LCC06', 'K1', 'B202, 7:30, Thu 3, 5, 7', 'GV01');
insert into LopChungChiMo values ('LCC07', 'K1', 'B203, 7:30, Thu 2, 4, 6', 'GV02');
insert into LopChungChiMo values ('LCC06', 'K2', 'B202, 7:30, Thu 3, 5, 7', 'GV01');
insert into LopChungChiMo values ('LCC07', 'K2', 'B203, 7:30, Thu 2, 4, 6', 'GV02');
insert into LopChungChiMo values ('LCC06', 'K3', 'B202, 7:30, Thu 3, 5, 7', 'GV01');
insert into LopChungChiMo values ('LCC07', 'K3', 'B203, 7:30, Thu 2, 4, 6', 'GV02');
insert into LopChungChiMo values ('LCC06', 'K4', 'B202, 7:30, Thu 3, 5, 7', 'GV01');
insert into LopChungChiMo values ('LCC07', 'K4', 'B203, 7:30, Thu 2, 4, 6', 'GV02');
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
	MaLCC varchar(10),
	KetQua varchar(50),
	primary key (MaHV, MaLCC)
)

create procedure fill_HocVien_ChungChi ()







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
insert into LopChuyenDe values ('CD01', 'Chuyen De 1');
insert into LopChuyenDe values ('CD02', 'Chuyen De 2');
insert into LopChuyenDe values ('CD03', 'Chuyen De 3');
insert into LopChuyenDe values ('CD04', 'Chuyen De 4');

create table LopChuyenDeMo
(
	MaLCD varchar(10),
	MaKhoa varchar(10),
	LichHoc varchar(100),
	MaGV varchar(10),
	primary key (MaLCD, MaKhoa)
)
go
insert into LopChuyenDeMo values ('CD01', 'K1', 'C101, 12:30, Thu 2, 4, 6', 'GV11');
insert into LopChuyenDeMo values ('CD02', 'K1', 'C102, 12:30, Thu 2, 4, 6', 'GV12');
insert into LopChuyenDeMo values ('CD03', 'K1', 'C103, 12:30, Thu 2, 4, 6', 'GV13');
insert into LopChuyenDeMo values ('CD04', 'K1', 'C104, 12:30, Thu 2, 4, 6', 'GV14');

insert into LopChuyenDeMo values ('CD01', 'K2', 'C101, 12:30, Thu 2, 4, 6', 'GV11');
insert into LopChuyenDeMo values ('CD02', 'K2', 'C102, 12:30, Thu 2, 4, 6', 'GV12');
insert into LopChuyenDeMo values ('CD03', 'K2', 'C103, 12:30, Thu 2, 4, 6', 'GV13');
insert into LopChuyenDeMo values ('CD04', 'K2', 'C104, 12:30, Thu 2, 4, 6', 'GV14');

insert into LopChuyenDeMo values ('CD01', 'K3', 'C101, 12:30, Thu 2, 4, 6', 'GV11');
insert into LopChuyenDeMo values ('CD02', 'K3', 'C102, 12:30, Thu 2, 4, 6', 'GV12');
insert into LopChuyenDeMo values ('CD03', 'K3', 'C103, 12:30, Thu 2, 4, 6', 'GV13');
insert into LopChuyenDeMo values ('CD04', 'K3', 'C104, 12:30, Thu 2, 4, 6', 'GV14');

insert into LopChuyenDeMo values ('CD01', 'K4', 'C101, 12:30, Thu 2, 4, 6', 'GV11');
insert into LopChuyenDeMo values ('CD02', 'K4', 'C102, 12:30, Thu 2, 4, 6', 'GV12');
insert into LopChuyenDeMo values ('CD03', 'K4', 'C103, 12:30, Thu 2, 4, 6', 'GV13');
insert into LopChuyenDeMo values ('CD04', 'K4', 'C104, 12:30, Thu 2, 4, 6', 'GV14');

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








