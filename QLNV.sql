﻿CREATE DATABASE QUANLYNHANVIEN


CREATE TABLE NHANVIEN
(
	MANV INT IDENTITY(1,1) PRIMARY KEY,
	MAPHONG VARCHAR(6),
	MALUONG VARCHAR(8),
	HOTEN NVARCHAR(70),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(3),
	DANTOC NVARCHAR(12),
	CMND_CCCD VARCHAR(12),
	NOICAP NVARCHAR(20),
	CHUCVU NVARCHAR(25),
	MALOAINV VARCHAR(10),
	LOAIHD NVARCHAR(20),
	THOIGIAN INT,
	NGAYKY DATETIME,
	NGAYHETHAN DATETIME,
	SDT VARCHAR(10),
	HOCVAN NVARCHAR(20),
	GHICHU NVARCHAR(60)
)

CREATE TABLE LSCHINHSUA
(
	MACS INT IDENTITY(1,1) PRIMARY KEY,
	MANV INT,
	LANCS INT,
	MAPHONG VARCHAR(6),
	MALUONG VARCHAR(8),
	HOTEN NVARCHAR(70),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(3),
	DANTOC NVARCHAR(12),
	CMND_CCCD VARCHAR(12),
	NOICAP NVARCHAR(20),
	CHUCVU NVARCHAR(25),
	MALOAINV VARCHAR(10),
	LOAIHD NVARCHAR(20),
	THOIGIAN INT,
	NGAYKY DATETIME,
	NGAYHETHAN DATETIME,
	SDT VARCHAR(10),
	HOCVAN NVARCHAR(20),
	GHICHU NVARCHAR(60),
	NGAYCHINHSUA DATETIME
)

CREATE TABLE LOAINHANVIEN
(
	MALOAINV VARCHAR(10) PRIMARY KEY,
	TENLOAINV NVARCHAR(30),
	MUCLUONGCOBAN MONEY,
)

CREATE TABLE PHONGBAN
(
	MAPHONG VARCHAR(6) PRIMARY KEY,
	MABP VARCHAR(8),
	TENPHONG NVARCHAR(20),
	NGAYTHANHLAP DATETIME,
	GHICHU NVARCHAR(70)
)

CREATE TABLE BOPHAN
(
	MABP VARCHAR(8) PRIMARY KEY,
	TENBOPHAN NVARCHAR(20),
	NGAYTHANHLAP DATETIME,
	GHICHU NVARCHAR(70)
)

CREATE TABLE HOSOTHUVIEC
(
	MANVTV INT IDENTITY(1,1) PRIMARY KEY,
	HOTEN NVARCHAR(70),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(3),
	CMND_CCCD VARCHAR(12),
	NOICAP NVARCHAR(20),
	VITRITHUVIEC NVARCHAR(25),
	NGAYTV DATETIME,
	SOTHANGTV INT,
	SDT VARCHAR(10),
	HOCVAN NVARCHAR(20),
	GHICHU NVARCHAR(60)
)

CREATE TABLE BANGCHAMCONGTHUVIEC
(
	MANVTV INT,
	THANG INT,
	NAM INT,
	PRIMARY KEY (MANVTV, THANG, NAM),
	SONGAYCONG INT,
	SONGAYNGHI INT,
	SOGIOLAMTHEM INT,
	LUONGTV MONEY,
	GHICHU NVARCHAR(60)
)

CREATE TABLE BANGCHAMCONG
(
	MANV INT,
	THANG INT,
	NAM INT,
	PRIMARY KEY (MANV, THANG, NAM),
	MALUONG VARCHAR(8),
	MAKT INT,
	MAKL INT,
	SONGAYCONG INT,
	SONGAYNGHI INT,
	SOGIOLAMTHEM INT,
	GHICHU NVARCHAR(60)
)

CREATE TABLE KHENTHUONG
(
	MAKT INT PRIMARY KEY,
	TIEN MONEY,
	LYDO NVARCHAR(50)
)

CREATE TABLE KYLUAT
(
	MAKL INT PRIMARY KEY,
	TIEN MONEY,
	LYDO NVARCHAR(50)
)

CREATE TABLE BANGLUONG
(
	MALUONG VARCHAR(8) PRIMARY KEY,
	LCB MONEY,
	PHUCAPCHUCVU MONEY,
	PHUCAPKHAC MONEY,
	GHICHU NVARCHAR(80)
)

CREATE TABLE THAYDOIBANGLUONG
(
	MANV INT,
	MALUONG VARCHAR(8),
	MALUONGMOI VARCHAR(8),
	PRIMARY KEY (MANV, MALUONG, MALUONGMOI),
	NGAYSUA DATETIME,
	LYDO NVARCHAR(70)
)

CREATE TABLE SOBH
(
	MABH INT IDENTITY(1,1) PRIMARY KEY,
	MANV INT,
	NGAYCAPSO DATETIME,
	NOICAPSO NVARCHAR(20),
	GHICHU NVARCHAR(70),
)

CREATE TABLE SOTHAISAN
(
	MATS INT IDENTITY(1,1) PRIMARY KEY,
	MANV INT,
	NGAYVESOM DATETIME,
	NGAYNGHISINH DATETIME,
	NGAYLAMTROLAI DATETIME,
	TROCAPCTY MONEY,
	GHICHU NVARCHAR(70)
)

CREATE TABLE NVTHOIVIEC
(
	MANV INT PRIMARY KEY,
	HOTEN NVARCHAR(70),
	CMND_CCCD VARCHAR(12),
	NGAYTHOIVIEC DATETIME,
	LYDO NVARCHAR(50)
)

CREATE TABLE TAIKHOAN
(
	MATK INT IDENTITY(1,1) PRIMARY KEY,
	MALOAITK INT,
	TENCHUTAIKHOAN NVARCHAR(20),
	TENDANGNHAP VARCHAR(20),
	MATKHAU VARCHAR(90),
)

CREATE TABLE PHANLOAITAIKHOAN
(
	MALOAITK INT IDENTITY(1,1) PRIMARY KEY,
	TENLOAITK NVARCHAR(20),
	QUYENHAN NVARCHAR(50)
)

CREATE TABLE THAMSO
(
	MATHAMSO VARCHAR(4),
	TENTHAMSO NVARCHAR(20),
	GIATRI FLOAT
)

ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_TAIKHOAN_MALOAITK FOREIGN KEY (MALOAITK) REFERENCES PHANLOAITAIKHOAN(MALOAITK)

ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIEN_MALOAINV FOREIGN KEY (MALOAINV) REFERENCES LOAINHANVIEN(MALOAINV)
ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIEN_MAPHONG FOREIGN KEY (MAPHONG) REFERENCES PHONGBAN(MAPHONG)
ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIEN_MALUONG  FOREIGN KEY (MALUONG) REFERENCES BANGLUONG(MALUONG)

ALTER TABLE LSCHINHSUA ADD CONSTRAINT FK_LSCHINHSUA_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE PHONGBAN ADD CONSTRAINT FK_PHONGBAN_MABP FOREIGN KEY (MABP) REFERENCES BOPHAN(MABP)

ALTER TABLE BANGCHAMCONGTHUVIEC ADD CONSTRAINT FK_BANGCHAMCONGTHUVIEC_MANVTV FOREIGN KEY (MANVTV) REFERENCES HOSOTHUVIEC(MANVTV)

ALTER TABLE BANGCHAMCONG ADD CONSTRAINT FK_BANGCHAMCONG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
ALTER TABLE BANGCHAMCONG ADD CONSTRAINT FK_BANGCHAMCONG_MALUONG FOREIGN KEY (MALUONG) REFERENCES BANGLUONG(MALUONG)
ALTER TABLE BANGCHAMCONG ADD CONSTRAINT FK_BANGCHAMCONG_MAKT FOREIGN KEY (MAKT) REFERENCES KHENTHUONG(MAKT)
ALTER TABLE BANGCHAMCONG ADD CONSTRAINT FK_BANGCHAMCONG_MAKL FOREIGN KEY (MAKL) REFERENCES KYLUAT(MAKL)

ALTER TABLE THAYDOIBANGLUONG ADD CONSTRAINT FK_THAYDOIBANGLUONG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
ALTER TABLE THAYDOIBANGLUONG ADD CONSTRAINT FK_THAYDOIBANGLUONG_MALUONG FOREIGN KEY (MALUONG) REFERENCES BANGLUONG(MALUONG)
ALTER TABLE THAYDOIBANGLUONG ADD CONSTRAINT FK_THAYDOIBANGLUONG_MALUONGMOI FOREIGN KEY (MALUONGMOI) REFERENCES BANGLUONG(MALUONG)

ALTER TABLE SOBH ADD CONSTRAINT FK_SOBH_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE SOTHAISAN ADD CONSTRAINT FK_SOTHAISAN_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE NVTHOIVIEC ADD CONSTRAINT FK_NVTHOIVIEC_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)

SET DATEFORMAT DMY

INSERT INTO PHANLOAITAIKHOAN(TENLOAITK, QUYENHAN) VALUES ('Quản trị viên', 'mọi thứ')
INSERT INTO TAIKHOAN(MALOAITK, TENCHUTAIKHOAN, TENDANGNHAP, MATKHAU) VALUES (1,'ADMIN', 'ADMIN', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b')

INSERT INTO NHANVIEN(HOTEN, NGAYSINH, GIOITINH, DANTOC, CMND_CCCD, NOICAP, CHUCVU, LOAIHD, THOIGIAN, NGAYKY, NGAYHETHAN, SDT, HOCVAN, GHICHU) VALUES ('NGB', '05/11/2002', N'Nam', N'King', '1', 'BD', N'Boss', N'Dài hạn', '4', '01/01/2023', '01/01/2027', '0123456789', N'Master', N'GHICHU')
INSERT INTO NHANVIEN(HOTEN, NGAYSINH, GIOITINH, DANTOC, CMND_CCCD, NOICAP, CHUCVU, LOAIHD, THOIGIAN, NGAYKY, NGAYHETHAN, SDT, HOCVAN, GHICHU) VALUES ('NHGH', '08/11/2002', N'Nam', N'King', '2', 'BD', N'Boss', N'Dài hạn', '4', '01/01/2023', '01/01/2027', '0987654321', N'Master', N'GHICHU')

INSERT INTO PHONGBAN(MAPHONG, MABP, TENPHONG, NGAYTHANHLAP) VALUES ('IT01', 'IT', N'CNTT 01', '05/01/2022')
INSERT INTO PHONGBAN(MAPHONG, MABP, TENPHONG, NGAYTHANHLAP) VALUES ('IT02', 'IT', N'CNTT 02', '05/01/2022')
INSERT INTO PHONGBAN(MAPHONG, MABP, TENPHONG, NGAYTHANHLAP) VALUES ('DS01', 'DS', N'Thiết kế 01', '05/01/2022')
INSERT INTO PHONGBAN(MAPHONG, MABP, TENPHONG, NGAYTHANHLAP) VALUES ('DS02', 'DS', N'Thiết kế 02', '05/01/2022')

INSERT INTO BOPHAN(MABP, TENBOPHAN, NGAYTHANHLAP) VALUES ('IT', N'CNTT', '01/01/2022')
INSERT INTO BOPHAN(MABP, TENBOPHAN, NGAYTHANHLAP) VALUES ('DS', N'Thiết kế', '01/01/2022')

INSERT INTO LOAINHANVIEN(MALOAINV, TENLOAINV, MUCLUONGCOBAN) VALUES ('NV', N'Nhân viên quèn', 15000000)
INSERT INTO LOAINHANVIEN(MALOAINV, TENLOAINV, MUCLUONGCOBAN) VALUES ('TP', N'Trưởng phòng', 25000000)
INSERT INTO LOAINHANVIEN(MALOAINV, TENLOAINV, MUCLUONGCOBAN) VALUES ('BS', N'Boss', 50000000)

INSERT INTO BANGLUONG(MALUONG, LCB, PHUCAPCHUCVU, PHUCAPKHAC) VALUES ('Luong01', 15000000, 1000000, 1000000)
INSERT INTO BANGLUONG(MALUONG, LCB, PHUCAPCHUCVU, PHUCAPKHAC) VALUES ('Luong02', 50000000, 10000000, 10000000)

CREATE FUNCTION [dbo].[fChuyenCoDauThanhKhongDau](@inputVar NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END

SELECT dbo.fChuyenCoDauThanhKhongDau(HOTEN) FROM NHANVIEN

SELECT * FROM NHANVIEN WHERE dbo.fChuyenCoDauThanhKhongDau(HOTEN) LIKE N'%u%'

select (CASE WHEN min(THOIGIAN) >= 1 THEN min(THOIGIAN) ELSE 0 END) 'THOIGIAN'
from NHANVIEN where NOICAP = 'BD'

SELECT (CASE WHEN MAX(LANCS) >= 1 THEN MAX(LANCS) ELSE 0 END) 'LANCSGANNHAT' FROM LSCHINHSUA WHERE MANV = '1'

delete from LSCHINHSUA