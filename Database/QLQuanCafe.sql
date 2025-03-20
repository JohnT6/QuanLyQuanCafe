CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE Ban
(
	MaBan nvarchar(10) PRIMARY KEY,
	TenBan NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người 
)
GO

CREATE TABLE TaiKhoan
(
	TenTaiKhoan NVARCHAR(100) PRIMARY KEY,	
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Genzo',
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE DanhMuc
(
	MaDanhMuc nvarchar(10) PRIMARY KEY,
	TenDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE ThucPham
(
	MaThucPham nvarchar(10) PRIMARY KEY,
	TenThucPham NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	MaDanhMuc nvarchar(10) NOT NULL,
	Gia FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc)
)
GO

CREATE TABLE HoaDon (
    MaHoaDon NVARCHAR(10) PRIMARY KEY,       -- Mã hóa đơn
    MaBan NVARCHAR(10) NOT NULL,             -- Bàn được sử dụng
    TongTien FLOAT NOT NULL DEFAULT 0,       -- Tổng tiền
    NgayCheckIn DATE NOT NULL  default GETDATE(),               -- Ngày check-in
    NgayCheckOut DATE,                       -- Ngày check-out (có thể NULL nếu chưa thanh toán)
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan) -- Liên kết với bảng Ban
);


CREATE TABLE ChiTietHoaDon
(
	MaCT nvarchar(10) PRIMARY KEY,
	MaHoaDon nvarchar(10) NOT NULL,
	MaThucPham nvarchar(10) NOT NULL,
	SoLuong INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (MaHoaDon) REFERENCES dbo.HoaDon(MaHoaDon),
	FOREIGN KEY (MaThucPham) REFERENCES dbo.ThucPham(MaThucPham)
)
GO

CREATE TABLE NhanVien (
    MaNhanVien nvarchar(10) PRIMARY KEY, 
    TenNhanVien NVARCHAR(100) NOT NULL, 
    ChucVu NVARCHAR(50) NULL, 
    SoDienThoai NVARCHAR(15) NULL, 
    Email NVARCHAR(100) NULL, 
    DiaChi NVARCHAR(255) NULL, 
    GioiTinh NVARCHAR(10) NULL 
);
GO

INSERT INTO dbo.TaiKhoan
        ( TenTaiKhoan ,
          TenHienThi ,
          MatKhau ,
          LoaiTaiKhoan
        )
VALUES  ( N'admin' , -- UserName - nvarchar(100)
          N'Admin' , -- DisplayName - nvarchar(100)
          N'admin3620' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.TaiKhoan
        ( TenTaiKhoan ,
          TenHienThi ,
          MatKhau ,
          LoaiTaiKhoan
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

INSERT INTO dbo.NhanVien (MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, Email, DiaChi, GioiTinh)
VALUES 
('NV001', 'Nguyen Van A', 'QuanLy', '0901234567', 'a.nguyen@email.com', '123 Le Loi, TP.HCM', 'Nam'),
('NV002', 'Tran Thi B', 'Nhan vien', '0912345678', 'b.tran@email.com', '456 Nguyen Trai, TP.HCM', 'Nu'),
('NV003', 'Le Van C', 'Nhan vien', '0933456789', 'c.le@email.com', '789 Tran Hung Dao, TP.HCM', 'Nam'),
('NV004', 'Pham Thi D', 'Nhan vien', '0944567890', 'd.pham@email.com', '123 Ly Thuong Kiet, TP.HCM', 'Nu'),
('NV005', 'Hoang Van E', 'Nhan vien', '0955678901', 'e.hoang@email.com', '456 Cach Mang Thang 8, TP.HCM', 'Nam');
GO

INSERT INTO dbo.Ban (MaBan, TenBan, TrangThai)
VALUES 
('B001', N'Bàn 1', N'Trống'),
('B002', N'Bàn 2', N'Có người'),
('B003', N'Bàn 3', N'Trống'),
('B004', N'Bàn 4', N'Trống'),
('B005', N'Bàn 5', N'Có người'),
('B006', N'Bàn 6', N'Trống');
GO

INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc)
VALUES 
('DM001', N'Đồ uống'),
('DM002', N'Món ăn nhanh'),
('DM003', N'Món tráng miệng');
GO

INSERT INTO ThucPham (MaThucPham, TenThucPham, MaDanhMuc, Gia)
VALUES
('TP001', N'Trá Sữa Phúc Long', 'DM001', 45000), -- Đồ uống
('TP002', N'Cà Phê Sữa Đá', 'DM001', 39000),     -- Đồ uống
('TP003', N'Sinh Tố Xoài', 'DM001', 55000),      -- Đồ uống
('TP004', N'Bánh Mì Gà Xé', 'DM002', 49000),     -- Món ăn nhanh
('TP005', N'Bánh Croissant', 'DM002', 35000),    -- Món ăn nhanh
('TP006', N'Bánh Tiramisu', 'DM003', 65000),     -- Món tráng miệng
('TP007', N'Bánh Cheesecake', 'DM003', 70000);   -- Món tráng miệng
GO

INSERT INTO HoaDon (MaHoaDon, NgayCheckIn, NgayCheckOut, MaBan, TongTien)
VALUES
('HD001', '2025-03-18', '2025-03-18', 'B001', 150000),
('HD002', '2025-03-18', '2025-03-18', 'B002', 200000),
('HD003', '2025-03-17', '2025-03-17', 'B003', 180000),
('HD004', '2025-03-18', '2025-03-18', 'B004', 220000),
('HD005', '2025-03-16', '2025-03-16', 'B005', 250000);
GO

INSERT INTO ChiTietHoaDon (MaCT, MaHoaDon, MaThucPham, SoLuong)
VALUES
('CT001', 'HD001', 'TP001', 2), -- Hóa đơn HD001, món TP001, số lượng 2
('CT002', 'HD001', 'TP002', 1), -- Hóa đơn HD001, món TP002, số lượng 1
('CT003', 'HD002', 'TP003', 3), -- Hóa đơn HD002, món TP003, số lượng 3
('CT004', 'HD002', 'TP005', 2), -- Hóa đơn HD002, món TP005, số lượng 2
('CT005', 'HD003', 'TP006', 1), -- Hóa đơn HD003, món TP006, số lượng 1
('CT006', 'HD004', 'TP004', 4), -- Hóa đơn HD004, món TP004, số lượng 4
('CT007', 'HD005', 'TP007', 1), -- Hóa đơn HD005, món TP007, số lượng 1
('CT008', 'HD005', 'TP001', 3); -- Hóa đơn HD005, món TP001, số lượng 3
GO

