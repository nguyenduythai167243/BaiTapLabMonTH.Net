-- =============================================
-- LAB 09 - BÀI TẬP VỀ NHÀ 3: QUẢN LÝ KINH DOANH (QLKD)
-- =============================================

CREATE DATABASE QLKD;
GO

USE QLKD;
GO

-- 1. Bảng Nhà cung cấp
CREATE TABLE NCC (
    Mancc NVARCHAR(10) PRIMARY KEY,
    Tenncc NVARCHAR(100) NOT NULL,
    DiachiNCC NVARCHAR(150) NULL
);
GO

-- 2. Bảng Khách hàng
CREATE TABLE KHACH (
    Makh NVARCHAR(10) PRIMARY KEY,
    Tenkh NVARCHAR(50) NOT NULL,
    Diachikh NVARCHAR(150) NULL
);
GO

-- 3. Bảng Hàng
CREATE TABLE HANG (
    Mahang NVARCHAR(10) PRIMARY KEY,
    Tenhang NVARCHAR(100) NOT NULL,
    DVT NVARCHAR(20) NOT NULL
);
GO

-- 4. Bảng Hóa đơn mua
CREATE TABLE HDMUA (
    SoHD NVARCHAR(20) PRIMARY KEY,
    Ngaymua DATETIME NOT NULL,
    Mancc NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_HDMUA_NCC FOREIGN KEY (Mancc) REFERENCES NCC(Mancc) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 5. Bảng Chi tiết hóa đơn mua
CREATE TABLE CHITIETMUA (
    SoHD NVARCHAR(20) NOT NULL,
    Mahang NVARCHAR(10) NOT NULL,
    Soluongmua INT NOT NULL,
    Dongiamua FLOAT NOT NULL,
    CONSTRAINT PK_CHITIETMUA PRIMARY KEY (SoHD, Mahang),
    CONSTRAINT FK_CTM_HDMUA FOREIGN KEY (SoHD) REFERENCES HDMUA(SoHD) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CTM_HANG FOREIGN KEY (Mahang) REFERENCES HANG(Mahang) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 6. Bảng Hóa đơn bán
CREATE TABLE HDBAN (
    SoHDB NVARCHAR(20) PRIMARY KEY,
    Ngayban DATETIME NOT NULL,
    Makh NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_HDBAN_KHACH FOREIGN KEY (Makh) REFERENCES KHACH(Makh) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 7. Bảng Chi tiết hóa đơn bán
CREATE TABLE CHITIETBAN (
    SoHDB NVARCHAR(20) NOT NULL,
    Mahang NVARCHAR(10) NOT NULL,
    Soluongban INT NOT NULL,
    Dongiaban FLOAT NOT NULL,
    CONSTRAINT PK_CHITIETBAN PRIMARY KEY (SoHDB, Mahang),
    CONSTRAINT FK_CTB_HDBAN FOREIGN KEY (SoHDB) REFERENCES HDBAN(SoHDB) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CTB_HANG FOREIGN KEY (Mahang) REFERENCES HANG(Mahang) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- =============================================
-- NHẬP DỮ LIỆU MẪU (Ít nhất 3 bản ghi cho mỗi bảng)
-- =============================================

-- NCC
INSERT INTO NCC (Mancc, Tenncc, DiachiNCC) VALUES
(N'NCC01', N'Công ty Điện Máy Sony VN', N'Hai Bà Trưng, Hà Nội'),
(N'NCC02', N'Tập đoàn Điện Lạnh Panasonic', N'Quận 1, TP Hồ Chí Minh'),
(N'NCC03', N'Công ty Phân Phối LG Electronics', N'Hải Châu, Đà Nẵng');
GO

-- KHACH
INSERT INTO KHACH (Makh, Tenkh, Diachikh) VALUES
(N'KH01', N'Nguyễn Văn Bình', N'Hoàn Kiếm, Hà Nội'),
(N'KH02', N'Trần Thị Hoa', N'Đống Đa, Hà Nội'),
(N'KH03', N'Lê Minh Tuấn', N'Cầu Giấy, Hà Nội');
GO

-- HANG
INSERT INTO HANG (Mahang, Tenhang, DVT) VALUES
(N'H01', N'Tivi Sony Bravia 55 inch', N'Chiếc'),
(N'H02', N'Tủ lạnh Panasonic Inverter', N'Chiếc'),
(N'H03', N'Máy giặt LG TurboWash', N'Chiếc'),
(N'H04', N'Điều hòa Daikin 12000 BTU', N'Bộ');
GO

-- HDMUA
INSERT INTO HDMUA (SoHD, Ngaymua, Mancc) VALUES
(N'HDM01', '2023-08-10', N'NCC01'),
(N'HDM02', '2023-08-15', N'NCC02'),
(N'HDM03', '2023-09-01', N'NCC03');
GO

-- CHITIETMUA
INSERT INTO CHITIETMUA (SoHD, Mahang, Soluongmua, Dongiamua) VALUES
(N'HDM01', N'H01', 10, 12000000),
(N'HDM02', N'H02', 15, 8500000),
(N'HDM03', N'H03', 20, 7200000);
GO

-- HDBAN
INSERT INTO HDBAN (SoHDB, Ngayban, Makh) VALUES
(N'HDB01', '2023-09-10', N'KH01'),
(N'HDB02', '2023-09-12', N'KH02'),
(N'HDB03', '2023-09-15', N'KH03');
GO

-- CHITIETBAN
INSERT INTO CHITIETBAN (SoHDB, Mahang, Soluongban, Dongiaban) VALUES
(N'HDB01', N'H01', 1, 14500000),
(N'HDB02', N'H02', 2, 10000000),
(N'HDB03', N'H03', 1, 8900000);
GO
