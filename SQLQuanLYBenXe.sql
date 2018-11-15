CREATE DATABASE QLyBenXe
GO

USE QLyBenXe
GO

-- Tạo bảng LoaiNhanVien
CREATE TABLE LoaiNhanVien
(
	MaLoaiNV nvarchar(10) PRIMARY KEY,
	TenLoaiNV nvarchar(55) NOT NULL,
	LuongCoBan money,
)
GO

-- Tạo bảng NhanVien
CREATE TABLE NhanVien
(
	MaNV nvarchar(10) PRIMARY KEY,
	TenNV nvarchar (55) NOT NULL,
	CMND nvarchar (12) NOT NULL,
	NgaySinh datetime,
	DiaChi nvarchar (255),
	QueQuan nvarchar(255),
	NgayBatDau datetime,
	MaLoaiNV nvarchar(10) NOT NULL ,
	SoDienThoai nvarchar(11),
	Luong money,
	FOREIGN KEY (MaLoaiNV) REFERENCES LoaiNhanVien(MaLoaiNV),
)
GO

-- Tạo bảng TaiKhoanNhanVien
CREATE TABLE TaiKhoanNhanVien
(
	MaNV nvarchar(10) PRIMARY KEY,
	MaTK nvarchar(20) NOT NULL,
	MatKhau nvarchar(55) NOT NULL,
	CONSTRAINT FK_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) 
)
GO

-- Tạo bảng HangXe
CREATE TABLE HangXe
(
	MaHangXe nvarchar(10) PRIMARY KEY,
	TenHangXe nvarchar(55) NOT NULL,
	SoLuongXe int,
	ChiPhiThueBai money,
)
GO

-- Tạo bảng LoaiXe
CREATE TABLE LoaiXe
(
	MaLoaiXe nvarchar(10) PRIMARY KEY,
	TenLoaiXe nvarchar(55),
)
GO

-- Tạo Bảng Xe
CREATE TABLE Xe
(
	MaXe nvarchar(10) PRIMARY KEY,
	MaHangXe nvarchar(10) NOT NULL,
	SoXe nvarchar(15) NOT NULL,
	MaLoaiXe nvarchar(10) NOT NULL,
	HanhTrinh nvarchar(30),
	Gia int,
	GioXuatPhat datetime,
	SoLuongGhe int,
	SoLuongKhachHang int,
	MaNVLaiXe nvarchar(10) NOT NULL,
	CONSTRAINT FK_MaNVLaiXe FOREIGN KEY(MaNVLaiXe) REFERENCES NhanVien(MaNV),
	CONSTRAINT FK_MaHangXe FOREIGN KEY(MaHangXe) REFERENCES HangXe(MaHangXe),
	CONSTRAINT FK_MaLoaiXe FOREIGN KEY(MaLoaiXe) REFERENCES LoaiXe(MaLoaiXe),
)
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang
(
	MaKH nvarchar(10) NOT NULL,
	TenKH nvarchar(55),
	CMND nvarchar(12),
	SoDienThoai nvarchar(10),
	MaXe nvarchar(10) NOT NULL,
	MaGhe nvarchar(10),
	PRIMARY KEY(MaKH),
	FOREIGN KEY(MaXe) REFERENCES Xe(MaXe),
)
GO

-- NHẬP DỮ LIỆU
--Nhập dữ liệu cho bảng LoaiNhanVien
INSERT INTO dbo.LoaiNhanVien(MaLoaiNV, TenLoaiNV, LuongCoBan)
VALUES
('QL', N'Quản Lý', 10000000),
('NVPV', N'Nhân Viên Phòng Vé', 7000000),
('KT', N'Kế Toán', 5000000),
('LX', N'Lái Xe', 3000000),
('PX', N'Phụ Xe', 3000000)
GO

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
GO

-- Nhập dữ liệu cho bảng HangXe
INSERT INTO dbo.HangXe(MaHangXe, TenHangXe, SoLuongXe)
VALUES
('PT', N'Phương Trang', 10),
('TB', N'Thành Bưởi', 20),
('PL', N'Phương Lâm', 30)
GO

--Nhập dữ liệu cho bảng LoaiXe
INSERT INTO dbo.LoaiXe(MaLoaiXe, TenLoaiXe)
VALUES  
('NA', N'Xe nằm'),
('NG', N'Xe ngồi')
GO

-- Nhập dữ liệu cho bảng Xe
INSERT INTO Xe (MaXe, MaHangXe, SoXe, MaLoaiXe, HanhTrinh, Gia, SoLuongGhe, SoLuongKhachHang, GioXuatPhat, MaNVLaiXe)
values('PT1','PT','68X1_12345', 'NA', 'tphcm-Kiên Giang',1750000,30,24,'6:30','NV4'),
('PT2','PT','67X1_12345', 'NG', 'tphcm-An Giang',1650000,30,24,'7:30','NV6'),
('PT3','PT','69X1_12345', 'NA', 'tphcm-Cà Mau',1850000,30,24,'8:30','NV8'),
('PT4','PT','63X1_12345', 'NG', 'tphcm-Tiền Giang',1350000,30,24,'6:30','NV10'),
('PT5','PT','95X1_12345', 'NA', 'tphcm-Hậu Giang',1350000,30,24,'6:30','NV12'),
('PT6','PT','94X1_12345', 'NG', 'tphcm-Bạc Liêu',1550000,30,24,'6:30','NV14'),
('PT7','PT','66X1_12345', 'NA', 'tphcm-Đồng Tháp',1650000,30,24,'7:30','NV16'),
('PT8','PT','64X1_12345', 'NG', 'tphcm-Vĩnh Long',1150000,30,24,'8:30','NV18'),
('PT9','PT','65X1_12345', 'NA', 'tphcm-Cần Thơ',1050000,30,24,'9:30','NV20'),
('PT10','PT','71X1_12345', 'NG', 'tphcm-Bến Tre',1550000,30,24,'6:30','NV22')
GO

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
GO

-- Tạo SP thêm loại nhân viên
CREATE PROC SP_ThemLoaiNhanVien(@maLoaiNV nvarchar(10), @tenLoaiNV nvarchar(55), @luongCoBan money)
AS
	INSERT INTO LoaiNhanVien(MaLoaiNV, TenLoaiNV, LuongCoBan)
	VALUES(@maLoaiNV, @tenLoaiNV, @luongCoBan)
GO

-- Tạo SP thêm loại xe
CREATE PROC SP_ThemLoaiXe(@maLoaiXe nvarchar(10), @tenLoaiXe nvarchar(10))
AS
	INSERT INTO LoaiXe(MaLoaiXe, TenLoaiXe)
	VALUES (@maLoaiXe, @tenLoaiXe)
GO

-- Tạo SP thêm hãng xe
CREATE PROC SP_ThemHangXe(@maHangXe nvarchar(10), @tenHangXe nvarchar(55), @soLuongXe int, @chiPhiThueBai money)
AS
	INSERT INTO HangXe(MaHangXe, TenHangXe, SoLuongXe, ChiPhiThueBai)
	VALUES (@maHangXe, @tenHangXe, @soLuongXe, @chiPhiThueBai)
GO

-- Tạo SP thêm khách hàng
CREATE PROC SP_ThemKhachHang(@maKH nvarchar(10), @tenKH nvarchar(55), @cmnd nvarchar(12), @soDienThoai nvarchar(10), @maXe nvarchar(10), @maGhe nvarchar(10))
AS
	INSERT INTO KhachHang(MaKH, TenKH, CMND, SoDienThoai, MaXe, MaGhe)
	VALUES (@maKH, @tenKH, @cmnd, @soDienThoai, @maXe, @maGhe)
GO

-- Tạo SP thêm nhân viên
CREATE PROC SP_ThemNhanVien(@maNV nvarchar(10), @tenNV nvarchar(55), @cmnd nvarchar(12), @ngaySinh datetime, @diaChi nvarchar(255), @queQuan nvarchar(255), @ngayBatDau datetime, @maLoaiNV nvarchar(10), @soDienThoai nvarchar(11), @luong money)
AS
	SET DATEFORMAT dmy
	INSERT INTO NhanVien(MaNV, TenNV, CMND, NgaySinh, DiaChi, QueQuan, NgayBatDau, MaLoaiNV, SoDienThoai, Luong)
	VALUES (@maNV, @tenNV, @cmnd, @ngaySinh, @diaChi, @queQuan, @ngayBatDau, @maLoaiNV, @soDienThoai, @luong)
GO

-- Tạo SP thêm xe
CREATE PROC SP_ThemXe(@maXe nvarchar(10), @maHangXe nvarchar(10), @soXe nvarchar(15), @maLoaiXe nvarchar(10), @hanhTrinh nvarchar(255), @gia int, @gioXuatPhat datetime, @soLuongGhe int, @soLuongKhachHang int, @maNVLaiXe nvarchar(10))
AS
	SET DATEFORMAT dmy
	INSERT INTO Xe(MaXe, MaHangXe, SoXe, MaLoaiXe, HanhTrinh, Gia, GioXuatPhat, SoLuongGhe, SoLuongKhachHang, MaNVLaiXe)
	VALUES (@maXe, @maHangXe, @soXe, @maLoaiXe, @hanhTrinh, @gia, @gioXuatPhat, @soLuongGhe, @soLuongKhachHang, @maNVLaiXe)
GO

-- Tạo SP thêm tài khoản nhân viên
CREATE PROC SP_ThemTaiKhoanNhanVien(@maNV nvarchar(10), @maTK nvarchar(10), @matKhau nvarchar(55))
AS
	SET DATEFORMAT dmy
	INSERT INTO TaiKhoanNhanVien(MaNV, MaTK, MatKhau)
	VALUES (@maNV, @maTK, @matKhau)
GO


-- Tạo SP sửa loại nhân viên
CREATE PROC SP_SuaLoaiNhanVien(@maLoaiNV nvarchar(10), @tenLoaiNV nvarchar(55), @luongCoBan money)
AS
	UPDATE LoaiNhanVien	
	SET 
		TenLoaiNV = @tenLoaiNV, 
		LuongCoBan = @luongCoBan
	WHERE
		MaLoaiNV = @maLoaiNV
GO

-- Tạo SP sửa loại xe
CREATE PROC SP_SuaLoaiXe(@maLoaiXe nvarchar(10), @tenLoaiXe nvarchar(10))
AS
	UPDATE LoaiXe
	SET  
		TenLoaiXe = @tenLoaiXe
	WHERE
		MaLoaiXe = @maLoaiXe
GO

-- Tạo SP sửa hãng xe
CREATE PROC SP_SuaHangXe(@maHangXe nvarchar(10), @tenHangXe nvarchar(55), @soLuongXe int, @chiPhiThueBai money)
AS
	UPDATE HangXe
	SET  
		TenHangXe = @tenHangXe,
		SoLuongXe = @soLuongXe,
		ChiPhiThueBai = @chiPhiThueBai
	WHERE
		MaHangXe = @maHangXe
GO

-- Tạo SP sửa khách hàng
CREATE PROC SP_SuaKhachHang(@maKH nvarchar(10), @tenKH nvarchar(55), @cmnd nvarchar(12), @soDienThoai nvarchar(10), @maXe nvarchar(10), @maGhe nvarchar(10))
AS
	UPDATE KhachHang
	SET  
		TenKH = @tenKH,
		CMND = @cmnd,
		SoDienThoai = @soDienThoai,
		MaXe = @maXe,
		MaGhe = @maGhe
	WHERE
		MaKH = @maKH
GO

-- Tạo SP sửa nhân viên
CREATE PROC SP_SuaNhanVien(@maNV nvarchar(10), @tenNV nvarchar(55), @cmnd nvarchar(12), @ngaySinh datetime, @diaChi nvarchar(255), @queQuan nvarchar(255), @ngayBatDau datetime, @maLoaiNV nvarchar(10), @soDienThoai nvarchar(11), @luong money)
AS
	SET DATEFORMAT dmy
	UPDATE NhanVien
	SET  
		TenNV = @tenNV,
		CMND = @cmnd,
		NgaySinh = @ngaySinh,
		DiaChi = DiaChi,
		QueQuan = @queQuan,
		NgayBatDau = @ngayBatDau,
		MaLoaiNV = @maLoaiNV, 
		SoDienThoai = @soDienThoai, 
		Luong = @luong
	WHERE
		MaNV = @maNV
GO

-- Tạo SP sửa xe
CREATE PROC SP_SuaXe(@maXe nvarchar(10), @maHangXe nvarchar(10), @soXe nvarchar(15), @maLoaiXe nvarchar(10), @hanhTrinh nvarchar(255), @gia int, @gioXuatPhat datetime, @soLuongGhe int, @soLuongKhachHang int, @maNVLaiXe nvarchar(10))
AS
	SET DATEFORMAT dmy
	UPDATE Xe
	SET  
		MaHangXe = @maHangXe,
		SoXe = @soXe,
		MaLoaiXe = @maLoaiXe,
		HanhTrinh = @hanhTrinh,
		Gia = @gia,
		GioXuatPhat = @gioXuatPhat,
		SoLuongGhe = @soLuongGhe, 
		SoLuongKhachHang = @soLuongKhachHang, 
		MaNVLaiXe = @maNVLaiXe
	WHERE
		MaXe = @maXe
GO
-- Tạo SP sửa tài khoản nhân viên
CREATE PROC SP_suaTaiKhoanNhanVien(@maNV nvarchar(10), @maTK nvarchar(10), @matKhau nvarchar(55))
AS
	UPDATE TaiKhoanNhanVien
	SET  
		MaTK = @maTK,
		MatKhau = @matKhau
	WHERE
		MaNV = @maNV
GO


-- Tạo SP lấy bảng loại nhân viên
CREATE PROC SP_layBangLoaiNhanVien
AS
	SELECT * FROM LoaiNhanVien
GO
-- Tạo SP lấy bảng loại xe
CREATE PROC SP_layBangLoaiXe
AS
	SELECT * FROM LoaiXe
GO
-- Tạo SP lấy bảng hãng xe
CREATE PROC SP_layBangHangXe
AS
	SELECT * FROM HangXe
GO
-- Tạo SP lấy bảng khách hàng
CREATE PROC SP_layBangKhachHang
AS
	SELECT * FROM KhachHang
GO
-- Tạo SP lấy bảng nhân viên
CREATE PROC SP_layBangNhanVien
AS
	SELECT * FROM NhanVien
GO
-- Tạo SP lấy bảng xe
CREATE PROC SP_layBangXe
AS
	SELECT * FROM Xe
GO
-- Tạo SP lấy tài khoản nhân viên
CREATE PROC SP_layTaiKhoanNhanVien
AS
	SELECT * From TaiKhoanNhanVien
GO


-- Tạo SP xóa loại nhân viên
CREATE PROC SP_xoaKhachHang(@maNV nvarchar(10))
AS
	DELETE FROM NhanVien
	WHERE
		MaNV = @maNV
GO

-- Tạo SP xóa loại xe
CREATE PROC SP_xoaLoaiXe(@maLoaiXe nvarchar(10))
AS
	DELETE FROM LoaiXe
	WHERE
		MaLoaiXe = @maLoaiXe
GO

-- Tạo SP xóa hãng xe
CREATE PROC SP_xoaHangXe(@maHangXe nvarchar(10))
AS
	DELETE FROM HangXe
	WHERE
		MaHangXe = @maHangXe
GO

-- Tạo SP xóa khách hàng
CREATE PROC SP_xoaKhachHang(@maKH nvarchar(10))
AS
	DELETE FROM KhachHang
	WHERE
		MaKH = @maKH
GO

-- Tạo SP xóa nhân viên
CREATE PROC SP_xoaNhanVien(@maNV nvarchar(10))
AS
	DELETE FROM NhanVien
	WHERE
		MaNV = @maNV
GO

-- Tạo SP xóa xe
CREATE PROC SP_xoaXe(@maXe nvarchar(10))
AS
	DELETE FROM Xe
	WHERE
		MaXe = @maXe
GO

-- Tạo SP xóa tài khoản nhân viên
CREATE PROC SP_xoaTaiKhoanNhanVien(@maNV nvarchar(10))
AS
	DELETE FROM TaiKhoanNhanVien
	WHERE
		MaNV = @maNV
GO