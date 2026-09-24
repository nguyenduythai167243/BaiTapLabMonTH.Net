-- =============================================
-- LAB 09 - BÀI TẬP VỀ NHÀ 4: QUẢN LÝ DỰ ÁN (QLDA)
-- =============================================

CREATE DATABASE QLDA;
GO

USE QLDA;
GO

-- 1. Bảng Dự án
CREATE TABLE DUAN (
    Mada NVARCHAR(10) PRIMARY KEY,
    Tenda NVARCHAR(100) NOT NULL,
    Congviecda NVARCHAR(200) NULL,
    Songayda INT NOT NULL
);
GO

-- 2. Bảng Nhân viên
CREATE TABLE NHANVIEN (
    Manv NVARCHAR(10) PRIMARY KEY,
    Hoten NVARCHAR(50) NOT NULL,
    SoCMTND NVARCHAR(20) NOT NULL,
    Ngaysinh DATETIME NULL,
    Gioitinh NVARCHAR(10) NULL,
    Diachi NVARCHAR(150) NULL
);
GO

-- 3. Bảng Chuyên môn
CREATE TABLE CHUYENMON (
    Manv NVARCHAR(10) NOT NULL,
    Chuyenmon NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_CHUYENMON PRIMARY KEY (Manv, Chuyenmon),
    CONSTRAINT FK_CM_NV FOREIGN KEY (Manv) REFERENCES NHANVIEN(Manv) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 4. Bảng Trình độ
CREATE TABLE TRINHDO (
    Manv NVARCHAR(10) NOT NULL,
    Trinhdo NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_TRINHDO PRIMARY KEY (Manv, Trinhdo),
    CONSTRAINT FK_TD_NV FOREIGN KEY (Manv) REFERENCES NHANVIEN(Manv) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- 5. Bảng Nhân viên - Dự án
CREATE TABLE NHANVIEN_DUAN (
    Manv NVARCHAR(10) NOT NULL,
    Mada NVARCHAR(10) NOT NULL,
    Ngaybd DATETIME NOT NULL,
    Ngaykt DATETIME NULL,
    CONSTRAINT PK_NHANVIEN_DUAN PRIMARY KEY (Manv, Mada),
    CONSTRAINT FK_NVDA_NV FOREIGN KEY (Manv) REFERENCES NHANVIEN(Manv) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_NVDA_DA FOREIGN KEY (Mada) REFERENCES DUAN(Mada) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- =============================================
-- NHẬP DỮ LIỆU MẪU (Ít nhất 3 bản ghi cho mỗi bảng)
-- =============================================

-- DUAN
INSERT INTO DUAN (Mada, Tenda, Congviecda, Songayda) VALUES
(N'DA01', N'Hệ thống AI nhận diện khuôn mặt', N'Nghiên cứu thị giác máy tính và triển khai API', 180),
(N'DA02', N'Xây dựng cổng dịch vụ công trực tuyến', N'Phát triển ứng dụng Web và bảo mật', 120),
(N'DA03', N'Ứng dụng IoT giám sát môi trường', N'Thu thập dữ liệu cảm biến và phân tích đám mây', 90);
GO

-- NHANVIEN
INSERT INTO NHANVIEN (Manv, Hoten, SoCMTND, Ngaysinh, Gioitinh, Diachi) VALUES
(N'NV01', N'Đặng Văn Hùng', N'001090012345', '1990-05-12', N'Nam', N'Ba Đình, Hà Nội'),
(N'NV02', N'Nguyễn Thu Trang', N'001192004567', '1992-08-25', N'Nữ', N'Cầu Giấy, Hà Nội'),
(N'NV03', N'Vũ Quốc Tuấn', N'001088009876', '1988-11-03', N'Nam', N'Hà Đông, Hà Nội');
GO

-- CHUYENMON
INSERT INTO CHUYENMON (Manv, Chuyenmon) VALUES
(N'NV01', N'Trí tuệ nhân tạo (AI/ML)'),
(N'NV02', N'Lập trình .NET & CSDL'),
(N'NV03', N'Kỹ thuật IoT & Nhúng');
GO

-- TRINHDO
INSERT INTO TRINHDO (Manv, Trinhdo) VALUES
(N'NV01', N'Tiến sĩ CNTT'),
(N'NV02', N'Thạc sĩ Kỹ thuật phần mềm'),
(N'NV03', N'Kỹ sư Điện tử viễn thông');
GO

-- NHANVIEN_DUAN
INSERT INTO NHANVIEN_DUAN (Manv, Mada, Ngaybd, Ngaykt) VALUES
(N'NV01', N'DA01', '2023-01-15', '2023-07-15'),
(N'NV02', N'DA02', '2023-03-01', '2023-07-01'),
(N'NV03', N'DA03', '2023-05-10', NULL);
GO
