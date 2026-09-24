-- =============================================
-- LAB 09 - BÀI TẬP VỀ NHÀ 2: QUẢN LÝ ĐIỂM
-- =============================================

CREATE DATABASE QLDiem;
GO

USE QLDiem;
GO

-- 1. Bảng tblKhoa
CREATE TABLE tblKhoa (
    Makhoa NVARCHAR(10) PRIMARY KEY,
    Tenkhoa NVARCHAR(50) NOT NULL
);
GO

-- 2. Bảng tblSinhVien
CREATE TABLE tblSinhVien (
    MaSV NVARCHAR(10) PRIMARY KEY,
    Hoten NVARCHAR(50) NOT NULL,
    Ngaysinh DATETIME NULL,
    Noisinh NVARCHAR(50) NULL,
    Gioitinh NVARCHAR(10) NULL,
    Diachi NVARCHAR(100) NULL,
    Makhoa NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_SinhVien_Khoa FOREIGN KEY (Makhoa) REFERENCES tblKhoa(Makhoa) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 3. Bảng tblMonHoc
CREATE TABLE tblMonHoc (
    Mamon NVARCHAR(10) PRIMARY KEY,
    Tenmon NVARCHAR(50) NOT NULL,
    Makhoa NVARCHAR(10) NOT NULL,
    Sohocphan INT NOT NULL,
    Giaovien NVARCHAR(50) NULL,
    CONSTRAINT FK_MonHoc_Khoa FOREIGN KEY (Makhoa) REFERENCES tblKhoa(Makhoa) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 4. Bảng tblDiem
CREATE TABLE tblDiem (
    Mamon NVARCHAR(10) NOT NULL,
    MaSV NVARCHAR(10) NOT NULL,
    Diem FLOAT NULL,
    CONSTRAINT PK_Diem PRIMARY KEY (Mamon, MaSV),
    CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (Mamon) REFERENCES tblMonHoc(Mamon) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Diem_SinhVien FOREIGN KEY (MaSV) REFERENCES tblSinhVien(MaSV) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- =============================================
-- NHẬP DỮ LIỆU MẪU (5 đến 10 dòng mỗi bảng)
-- =============================================

-- Dữ liệu bảng tblKhoa
INSERT INTO tblKhoa (Makhoa, Tenkhoa) VALUES
(N'K01', N'Công nghệ thông tin'),
(N'K02', N'Kinh tế & Quản trị'),
(N'K03', N'Điện tử viễn thông'),
(N'K04', N'Cơ khí chế tạo'),
(N'K05', N'Ngoại ngữ');
GO

-- Dữ liệu bảng tblSinhVien
INSERT INTO tblSinhVien (MaSV, Hoten, Ngaysinh, Noisinh, Gioitinh, Diachi, Makhoa) VALUES
(N'SV01', N'Bùi Thị Thảo', '1985-07-07', N'Hà Nội', N'Nữ', N'Cầu Giấy, Hà Nội', N'K01'),
(N'SV02', N'Trần Tuấn Anh', '1984-06-05', N'Nam Định', N'Nam', N'Giao Thủy, Nam Định', N'K01'),
(N'SV03', N'Nguyễn Thị Mai', '1982-04-03', N'Hải Phòng', N'Nữ', N'Lê Chân, Hải Phòng', N'K01'),
(N'SV04', N'Trần Thị Yến', '1982-02-03', N'Hà Nam', N'Nữ', N'Phủ Lý, Hà Nam', N'K02'),
(N'SV05', N'Bùi Thanh Mai', '2003-03-03', N'Nghệ An', N'Nữ', N'Vinh, Nghệ An', N'K03'),
(N'SV06', N'Phạm Văn Nam', '2002-11-12', N'Hà Nội', N'Nam', N'Đống Đa, Hà Nội', N'K01'),
(N'SV07', N'Lê Hoàng Long', '2001-09-15', N'Thái Bình', N'Nam', N'Đông Hưng, Thái Bình', N'K02');
GO

-- Dữ liệu bảng tblMonHoc
INSERT INTO tblMonHoc (Mamon, Tenmon, Makhoa, Sohocphan, Giaovien) VALUES
(N'M01', N'Lập trình C# .NET', N'K01', 3, N'ThS. Nguyễn Văn A'),
(N'M02', N'Cơ sở dữ liệu SQL', N'K01', 3, N'TS. Lê Thị B'),
(N'M03', N'Cấu trúc dữ liệu', N'K01', 4, N'ThS. Trần Văn C'),
(N'M04', N'Quản trị học', N'K02', 3, N'PGS. Hoàng Văn D'),
(N'M05', N'Tiếng Anh chuyên ngành', N'K05', 2, N'ThS. Vũ Thị E'),
(N'M06', N'Kỹ thuật số', N'K03', 3, N'TS. Bùi Minh F');
GO

-- Dữ liệu bảng tblDiem
INSERT INTO tblDiem (Mamon, MaSV, Diem) VALUES
(N'M02', N'SV01', 3.0),
(N'M01', N'SV01', 9.0),
(N'M04', N'SV01', 3.0),
(N'M04', N'SV02', 2.0),
(N'M02', N'SV02', 9.0),
(N'M02', N'SV03', 8.0),
(N'M02', N'SV04', 6.0),
(N'M04', N'SV04', 8.0),
(N'M01', N'SV05', 5.0),
(N'M01', N'SV06', 8.5);
GO
