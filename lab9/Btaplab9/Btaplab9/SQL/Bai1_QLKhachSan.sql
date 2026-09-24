-- =============================================
-- LAB 09 - BÀI TẬP VỀ NHÀ 1: QUẢN LÝ KHÁCH SẠN
-- =============================================

CREATE DATABASE QLKhachSan;
GO

USE QLKhachSan;
GO

-- 1. Bảng Phong: Lưu thông tin về các phòng của khách sạn
CREATE TABLE Phong (
    MaPH NVARCHAR(10) PRIMARY KEY,
    LoaiP NVARCHAR(20) NOT NULL, -- Phòng đơn, Phòng đôi, Phòng ba
    HangP NVARCHAR(20) NOT NULL, -- Thường, VIP, Sang
    DonGia FLOAT NOT NULL,
    TinhTrang NVARCHAR(10) NOT NULL DEFAULT N'Không' -- Có, Không
);
GO

-- 2. Bảng KH: Lưu thông tin về khách hàng thuê phòng
CREATE TABLE KH (
    SoCMT NVARCHAR(20) PRIMARY KEY,
    Hoten NVARCHAR(50) NOT NULL,
    Gioitinh NVARCHAR(10) NOT NULL -- Nam, Nữ
);
GO

-- 3. Bảng ThueP: Lưu thông tin về quá trình thuê phòng của khách hàng
CREATE TABLE ThueP (
    SoCMT NVARCHAR(20) NOT NULL,
    MaPH NVARCHAR(10) NOT NULL,
    NgayDen DATETIME NOT NULL,
    NgayDi DATETIME NULL,
    TienSDDV FLOAT NULL DEFAULT 0,
    CONSTRAINT PK_ThueP PRIMARY KEY (SoCMT, MaPH, NgayDen),
    CONSTRAINT FK_ThueP_KH FOREIGN KEY (SoCMT) REFERENCES KH(SoCMT) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_ThueP_Phong FOREIGN KEY (MaPH) REFERENCES Phong(MaPH) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- =============================================
-- NHẬP DỮ LIỆU MẪU (Ít nhất 3 bản ghi cho mỗi bảng)
-- =============================================

-- Dữ liệu bảng Phong
INSERT INTO Phong (MaPH, LoaiP, HangP, DonGia, TinhTrang) VALUES
(N'P001', N'Phòng đơn', N'Thường', 200000, N'Có'),
(N'P002', N'Phòng đơn', N'Thường', 200000, N'Có'),
(N'P003', N'Phòng đơn', N'Thường', 200000, N'Không'),
(N'P004', N'Phòng đơn', N'Sang', 300000, N'Không'),
(N'P005', N'Phòng đơn', N'Sang', 300000, N'Không'),
(N'P006', N'Phòng đơn', N'VIP', 400000, N'Có'),
(N'P007', N'Phòng đôi', N'Thường', 300000, N'Có'),
(N'P008', N'Phòng ba', N'VIP', 600000, N'Không');
GO

-- Dữ liệu bảng KH
INSERT INTO KH (SoCMT, Hoten, Gioitinh) VALUES
(N'162626524', N'Đinh Gia Trường', N'Nam'),
(N'162707094', N'Bùi Thị Thảo', N'Nữ'),
(N'162707095', N'Đinh Gia Minh', N'Nam'),
(N'162709945', N'Nguyễn Thị Thu', N'Nữ'),
(N'035123456', N'Trần Văn An', N'Nam');
GO

-- Dữ liệu bảng ThueP
INSERT INTO ThueP (SoCMT, MaPH, NgayDen, NgayDi, TienSDDV) VALUES
(N'162626524', N'P007', '2023-10-21', NULL, 0),
(N'162707094', N'P001', '2023-10-21', NULL, 50000),
(N'162707095', N'P002', '2023-10-21', NULL, 0),
(N'162709945', N'P006', '2023-10-21', NULL, 100000);
GO
