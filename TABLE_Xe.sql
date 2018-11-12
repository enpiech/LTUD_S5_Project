CREATE DATABASE DBQuanLyBenXe
USE DBQuanLyBenXe
---tạo bảng Xe
CREATE TABLE Xe
(
	MaXe NVARCHAR(10),
	HangXE NVARCHAR(55),
	SoXe NVARCHAR(15),
	LoaiXe NVARCHAR(20),
	HanhTrinh NVARCHAR(30),
	Gia INT,
	GioXuatPhat DATETIME,
	SoGhe INT,
	SoHanhKhach INT,
	BacTai NVARCHAR(10),
	LoXe NVARCHAR(10),
	PRIMARY KEY(MaXe),
)

---thêm dữ liệu vào bảng Xe
INSERT INTO dbo.Xe (MaXe,HangXE,SoXe,LoaiXe,HanhTrinh,Gia,SoGhe,SoHanhKhach,GioXuatPhat,BacTai,LoXe)
values
('PT1','Phương Trang','68X1_12345','Xe nằm','Tphcm-Kiên Giang',1750000,30,24,'6:30','Bt_PT_1','Lx_PT_1'),
('PT2','Phương Trang','67X1_12345','Xe nằm','Tphcm-An Giang',1650000,30,24,'7:30','Bt_PT_2','Lx_PT_2'),
('PT3','Phương Trang','69X1_12345','Xe nằm','Tphcm-Cà Mau',1850000,30,24,'8:30','Bt_PT_3','Lx_PT_3'),
('PT4','Phương Trang','63X1_12345','Xe nằm','Tphcm-Tiền Giang',1350000,30,24,'6:30','Bt_PT_4','Lx_PT_4'),
('PT5','Phương Trang','95X1_12345','Xe nằm','Tphcm-Hậu Giang',1350000,30,24,'6:30','Bt_PT_5','Lx_PT_5'),
('PT6','Phương Trang','94X1_12345','Xe ngồi','Tphcm-Bạc Liêu',1550000,30,24,'6:30','Bt_PT_6','Lx_PT_6'),
('PT7','Phương Trang','66X1_12345','Xe ngồi','Tphcm-Đồng Tháp',1650000,30,24,'7:30','Bt_PT_7','Lx_PT_7'),
('PT8','Phương Trang','64X1_12345','Xe ngồi','Tphcm-Vĩnh Long',1150000,30,24,'8:30','Bt_PT_8','Lx_PT_8'),
('PT9','Phương Trang','65X1_12345','Xe ngồi','Tphcm-Cần Thơ',1050000,30,24,'9:30','Bt_PT_9','Lx_PT_9'),
('PT10','Phương Trang','71X1_12345','Xe ngồi','Tphcm-Bến Tre',1550000,30,24,'6:30','Bt_PT_10','Lx_PT_10')