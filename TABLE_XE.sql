
CREATE TABLE XE
(
	MA_XE NVARCHAR(10) PRIMARY KEY,
	HANG_XE NVARCHAR(55),
	SO_XE NVARCHAR(15),
	LOAI_XE NVARCHAR(20),
	HANH_TRINH NVARCHAR(30),
	GIA INT,
	GIOXUATPHAT DATETIME,
	SO_GHE INT,
	SO_HANH_KHACH INT,
	BAC_TAI NVARCHAR(10),
	LO_XE NVARCHAR(10),
)

DROP TABLE XE

insert into XE (MA_XE,HANG_XE, SO_XE, LOAI_XE, HANH_TRINH, GIA, SO_GHE, SO_HANH_KHACH, GIOXUATPHAT, BAC_TAI, LO_XE)
values('PT1','Phương Trang','68X1_12345','xe nằm','tphcm-Kiên Giang',1750000,30,24,'6:30','BT_PT_1','LX_PT_1'),
('PT2','Phương Trang','67X1_12345','xe nằm','tphcm-An Giang',1650000,30,24,'7:30','BT_PT_2','LX_PT_2'),
('PT3','Phương Trang','69X1_12345','xe nằm','tphcm-Cà Mau',1850000,30,24,'8:30','BT_PT_3','LX_PT_3'),
('PT4','Phương Trang','63X1_12345','xe nằm','tphcm-Tiền Giang',1350000,30,24,'6:30','BT_PT_4','LX_PT_4'),
('PT5','Phương Trang','95X1_12345','xe nằm','tphcm-Hậu Giang',1350000,30,24,'6:30','BT_PT_5','LX_PT_5'),
('PT6','Phương Trang','94X1_12345','xe ngồi','tphcm-Bạc Liêu',1550000,30,24,'6:30','BT_PT_6','LX_PT_6'),
('PT7','Phương Trang','66X1_12345','xe ngồi','tphcm-Đồng Tháp',1650000,30,24,'7:30','BT_PT_7','LX_PT_7'),
('PT8','Phương Trang','64X1_12345','xe ngồi','tphcm-Vĩnh Long',1150000,30,24,'8:30','BT_PT_8','LX_PT_8'),
('PT9','Phương Trang','65X1_12345','xe ngồi','tphcm-Cần Thơ',1050000,30,24,'9:30','BT_PT_9','LX_PT_9'),
('PT10','Phương Trang','71X1_12345','xe ngồi','tphcm-Bến Tre',1550000,30,24,'6:30','BT_PT_10','LX_PT_10')
truncate table XE