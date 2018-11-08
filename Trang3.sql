CREATE DATABASE DBQuanLyBenXe
go
USE DBQuanLyBenXe
go
CREATE TABLE KhachHang
(
	MaKH varchar(10) NOT NULL,
	TenKH nvarchar(55),
	CMND varchar(12),
	SoDienThoai varchar(10),
	MaXe varchar(10),
	MaGhe varchar(10)
	PRIMARY KEY(MaKH),
)
go
CREATE TABLE TenLoaiNhanVien
(
	TenChuc nvarchar(55) NOT NULL,
	MaLoaiNV varchar(10) NOT NULL,
	PRIMARY KEY(TenChuc, MaLoaiNV)
)
go
CREATE TABLE LoaiNhanVien
(
	MaLoaiNV varchar(10) NOT NULL PRIMARY KEY,
	Luong MONEY,
	
)
go
CREATE TABLE LoaiXe
(
	MaXe varchar(10) NOT NULL,
	TenXe nvarchar(55),
	Gia MONEY
)

go
--TẠO KHÓA NGOẠI cho table KhachHang
ALTER TABLE dbo.KhachHang

ADD FOREIGN KEY(MaXe) 

REFERENCES LoaiXe (Maxe)

--Tao khoa chinh cho table LoaiXe
go
ALTER TABLE dbo.LoaiXe ADD PRIMARY KEY(MaXe)

--Nhap du lieu cho bang KhachHang
go
INSERT INTO dbo.KhachHang(MaKH, TenKH, CMND, SoDienThoai, MaXe, MaGhe)

VALUES  ('KH11', N'Công Tự Một', '123456789', '0123456789', 'CP', 'G01'),
('KH02', N'Công Tự Hai', '987654321', '0123456788', 'PL', 'G02'),
('KH03', N'Công Tự Ba', '147258369', '0123456787', 'PT', 'G03'),
('KH04', N'Công Tự Bốn', '112233445', '0123456786', 'CP', 'G04'),
('KH05', N'Công Tự Năm', '12345678910', '0123456785', 'CP', 'G05'),
('KH06', N'Công Tự Sáu', '1234567895', '0123456784', 'PT', 'G06'),
('KH07', N'Công Tự Bảy', '1234567896', '0123456783', 'CP', 'G07'),
('KH08', N'Công Tự Tám', '1234567897', '0123456782', 'PL', 'G08'),
('KH09', N'Công Tự Chín', '1234567898', '0123456781', 'PT', 'G09'),
('KH10', N'Công Tự Mười', '1234567899', '0123456780', 'CP', 'G10')
--Nhap du lieu cho bang LoaiXe
go
INSERT INTO dbo.LoaiXe(MaXe, TenXe, Gia)

VALUES  ('PL', N'Phương Lâm', 300000),
('PT', N'Phương Trang', 200000)

--Nhap du lieu cho bang TenLoaiNhanVien

go
INSERT INTO dbo.TenLoaiNhanVien(TenChuc, MaLoaiNV)

VALUES(N'Quản Lý', 'QL'),
(N'Nhân Viên Phòng Vé', 'NVPV'),
(N'Kế Toán', 'KT')


--Nhap du lieu cho bang LoaiNhanVien
go
INSERT INTO dbo.LoaiNhanVien(MaLoaiNV, Luong)

VALUES('QL', 10000000),
('NVPV', 7000000),
('KT', 5000000)