CREATE DATABASE DBQuanLyBenXe
USE DBQuanLyBenXe

-- Tạo bảng LoaiNhanVien
CREATE TABLE LoaiNhanVien
(
	TenLoaiNV nvarchar(55) NOT NULL,
	MaLoaiNV varchar(10) NOT NULL,
	LuongCoBan money,
	PRIMARY KEY(MaLoaiNV)
)

-- Tạo bảng NhanVien
CREATE TABLE NhanVien
(
	MaNV varchar(10) NOT NULL PRIMARY KEY,
	TenNV varchar (55) NOT NULL,
	NgaySinh datetime,
	CMND varchar (12) NOT NULL,
	DiaChi varchar (255),
	QueQuan varchar(255),
	NgayBatDau datetime,
	MaLoaiNV varchar(10) NOT NULL ,
	SoDienThoai varchar(11),
	Luong money,
	FOREIGN KEY (MaLoaiNV) REFERENCES LoaiNhanVien(MaLoaiNV),
)

-- Tạo bảng HangXe
CREATE TABLE HangXe
(
	MaHangXe varchar(10) NOT NULL PRIMARY KEY,
	TenHangXe varchar(55) NOT NULL,
	SoLuongXe int,
	ChiPhiThueBai money,
)

-- Tạo bảng LoaiXe
CREATE TABLE LoaiXe
(
	MaLoaiXe varchar(10) NOT NULL PRIMARY KEY,
	MaHangXe varchar(10) NOT NULL,
	TenLoaiXe nvarchar(55),
	Gia MONEY,
	FOREIGN KEY (MaHangXe) REFERENCES HangXe(MaHangXe),
)

-- Tạo Bảng Xe
CREATE TABLE Xe
(
	MaXe varchar(10) NOT NULL PRIMARY KEY,
	MaHangXe varchar(10) NOT NULL,
	SoXe varchar(15),
	MaLoaiXe varchar(10) NOT NULL,
	HanhTrinh nvarchar(30),
	Gia int,
	GioXuatPhat datetime,
	SoLuongGhe int,
	SoLuongKhachHang int,
	MaNVLaiXe varchar(10) NOT NULL,
	MaNVPhuXe varchar(10) NOT NULL,
	CONSTRAINT MaNhanVienLaiXe_FK FOREIGN KEY(MaNVLaiXe) REFERENCES NhanVien(MaNV),
	CONSTRAINT MaNhanVienPhuXe_FK FOREIGN KEY(MaNVPhuXe) REFERENCES NhanVien(MaNV),
	FOREIGN KEY(MaHangXe) REFERENCES HangXe(MaHangXe),
)

-- Tạo bảng KhachHang
CREATE TABLE KhachHang
(
	MaKH varchar(10) NOT NULL,
	TenKH nvarchar(55) NOT NULL,
	CMND varchar(12),
	SoDienThoai varchar(10),
	MaXe varchar(10),
	MaGhe varchar(12)
	PRIMARY KEY(MaKH),
	FOREIGN KEY(MaXe) REFERENCES Xe(MaXe),
)


-- NHẬP DỮ LIỆU
--Nhập dữ liệu cho bảng LoaiNhanVien
INSERT INTO dbo.LoaiNhanVien(MaLoaiNV, TenLoaiNV, LuongCoBan)
VALUES
('QL', N'Quản Lý', 10000000),
('NVPV', N'Nhân Viên Phòng Vé', 7000000),
('KT', N'Kế Toán', 5000000),
('LX', N'Lái Xe', 3000000),
('PX', N'Phụ Xe', 3000000)

-- Nhập dữ liệu cho bảng NhanVien
INSERT INTO dbo.NhanVien(MaNV, TenNV, NgaySinh, CMND, DiaChi, QueQuan, NgayBatDau, MaLoaiNV)
VALUES 
('NV1', N'Nguyễn Văn A', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'QL'),
('NV2', N'Lê Văn B', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'NVPV'),
('NV3', N'Hồ Văn C', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'KT'),
('NV4', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV5', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV6', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV7', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV8', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV9', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV10', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV11', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV12', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV13', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV14', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV15', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV16', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV17', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV18', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV19', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV20', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV21', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX'),
('NV22', N'Phan Văn D', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'LX'),
('NV23', N'Lý Văn E', '1/1/1999', '123456789', 'TP.HCM', 'Hà Nội', '1/1/2018', 'PX')

-- Nhập dữ liệu cho bảng HangXe
INSERT INTO dbo.HangXe(MaHangXe, TenHangXe, SoLuongXe)
VALUES
('PT', N'Phương Trang', 10),
('TB', N'Thành Bưởi', 20),
('PL', N'Phương Lâm', 30)

--Nhập dữ liệu cho bảng LoaiXe
INSERT INTO dbo.LoaiXe(MaLoaiXe, TenLoaiXe, MaHangXe, Gia)
VALUES  
('NA', N'Xe nằm', 'PL', 300000),
('NG', N'Xe ngồi','PT',  200000)

-- Nhập dữ liệu cho bảng Xe
INSERT INTO Xe (MaXe, MaHangXe, SoXe, MaLoaiXe, HanhTrinh, Gia, SoLuongGhe, SoLuongKhachHang, GioXuatPhat, MaNVLaiXe, MaNVPhuXe)
values('PT1','PT','68X1_12345', 'NA', 'tphcm-Kiên Giang',1750000,30,24,'6:30','NV4','NV5'),
('PT2','PT','67X1_12345', 'NG', 'tphcm-An Giang',1650000,30,24,'7:30','NV6','NV7'),
('PT3','PT','69X1_12345', 'NA', 'tphcm-Cà Mau',1850000,30,24,'8:30','NV8','NV9'),
('PT4','PT','63X1_12345', 'NG', 'tphcm-Tiền Giang',1350000,30,24,'6:30','NV10','NV11'),
('PT5','PT','95X1_12345', 'NA', 'tphcm-Hậu Giang',1350000,30,24,'6:30','NV12','NV13'),
('PT6','PT','94X1_12345', 'NG', 'tphcm-Bạc Liêu',1550000,30,24,'6:30','NV14','NV15'),
('PT7','PT','66X1_12345', 'NA', 'tphcm-Đồng Tháp',1650000,30,24,'7:30','NV16','NV17'),
('PT8','PT','64X1_12345', 'NG', 'tphcm-Vĩnh Long',1150000,30,24,'8:30','NV18','NV19'),
('PT9','PT','65X1_12345', 'NA', 'tphcm-Cần Thơ',1050000,30,24,'9:30','NV20','NV21'),
('PT10','PT','71X1_12345', 'NG', 'tphcm-Bến Tre',1550000,30,24,'6:30','NV22','NV23')

--Nhập dữ liệu cho bảng KhachHang
INSERT INTO dbo.KhachHang(MaKH, TenKH, CMND, SoDienThoai, MaXe, MaGhe)
VALUES  
('KH11', N'Công Tự Một', '123456789', '0123456789', 'PT1', 'G01'),
('KH02', N'Công Tự Hai', '987654321', '0123456788', 'PT2', 'G02'),
('KH03', N'Công Tự Ba', '147258369', '0123456787', 'PT3', 'G03'),
('KH04', N'Công Tự Bốn', '112233445', '0123456786', 'PT4', 'G04'),
('KH05', N'Công Tự Năm', '12345678910', '0123456785', 'PT5', 'G05'),
('KH06', N'Công Tự Sáu', '1234567895', '0123456784', 'PT6', 'G06'),
('KH07', N'Công Tự Bảy', '1234567896', '0123456783', 'PT7', 'G07'),
('KH08', N'Công Tự Tám', '1234567897', '0123456782', 'PT8', 'G08'),
('KH09', N'Công Tự Chín', '1234567898', '0123456781', 'PT9', 'G09'),
('KH10', N'Công Tự Mười', '1234567899', '0123456780', 'PT10', 'G10')


