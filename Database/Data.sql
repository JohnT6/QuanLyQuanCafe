USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 20/03/2025 10:52:36 CH ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  User [Genzo]    Script Date: 20/03/2025 10:52:36 CH ******/
CREATE USER [Genzo] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [nvarchar](10) NOT NULL,
	[TenBan] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCT] [nvarchar](10) NOT NULL,
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaThucPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [nvarchar](10) NOT NULL,
	[TenDanhMuc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaBan] [nvarchar](10) NOT NULL,
	[TongTien] [float] NOT NULL,
	[NgayCheckIn] [date] NOT NULL,
	[NgayCheckOut] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[ChucVu] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](100) NOT NULL,
	[TenHienThi] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[LoaiTaiKhoan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucPham]    Script Date: 20/03/2025 10:52:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucPham](
	[MaThucPham] [nvarchar](10) NOT NULL,
	[TenThucPham] [nvarchar](100) NOT NULL,
	[MaDanhMuc] [nvarchar](10) NOT NULL,
	[Gia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThucPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B001', N'Bàn 1', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B002', N'Bàn 2', N'Có người')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B003', N'Bàn 3', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B004', N'Bàn 4', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B005', N'Bàn 5', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B006', N'Bàn 6', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'B007', N'Bàn 7', N'Trống')
GO
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT001', N'HD001', N'TP001', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT002', N'HD001', N'TP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT003', N'HD002', N'TP003', 3)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT004', N'HD002', N'TP005', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT005', N'HD003', N'TP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT006', N'HD004', N'TP004', 4)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT007', N'HD005', N'TP007', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT008', N'HD005', N'TP001', 3)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT226404', N'HD018275', N'TP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT323522', N'HD393421', N'TP004', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT412458', N'HD601947', N'TP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT437131', N'HD601947', N'TP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT524765', N'HD393421', N'TP006', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT543582', N'HD393421', N'TP001', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT546651', N'HD846673', N'TP001', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT915603', N'HD846673', N'TP004', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT925215', N'HD601947', N'TP006', 7)
INSERT [dbo].[ChiTietHoaDon] ([MaCT], [MaHoaDon], [MaThucPham], [SoLuong]) VALUES (N'CT945998', N'HD601947', N'TP004', 1)
GO
INSERT [dbo].[DanhMuc] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM001', N'Đồ uống')
INSERT [dbo].[DanhMuc] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM002', N'Món ăn nhanh')
INSERT [dbo].[DanhMuc] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM003', N'Món tráng miệng')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD001', N'B001', 150000, CAST(N'2025-03-18' AS Date), CAST(N'2025-03-18' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD002', N'B002', 200000, CAST(N'2025-03-18' AS Date), CAST(N'2025-03-18' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD003', N'B003', 180000, CAST(N'2025-03-17' AS Date), CAST(N'2025-03-17' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD004', N'B004', 220000, CAST(N'2025-03-18' AS Date), CAST(N'2025-03-18' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD005', N'B005', 250000, CAST(N'2025-03-16' AS Date), CAST(N'2025-03-16' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD018275', N'B002', 0, CAST(N'2025-03-20' AS Date), NULL)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD393421', N'B001', 224000, CAST(N'2025-03-20' AS Date), CAST(N'2025-03-20' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD601947', N'B003', 598000, CAST(N'2025-03-19' AS Date), CAST(N'2025-03-20' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaBan], [TongTien], [NgayCheckIn], [NgayCheckOut]) VALUES (N'HD846673', N'B002', 39000, CAST(N'2025-03-20' AS Date), CAST(N'2025-03-20' AS Date))
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [SoDienThoai], [Email], [DiaChi], [GioiTinh]) VALUES (N'NV001', N'Nguyen Van A', N'QuanLy', N'0901234567', N'a.nguyen@email.com', N'123 Le Loi, TP.HCM', N'Nam')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [SoDienThoai], [Email], [DiaChi], [GioiTinh]) VALUES (N'NV002', N'Tran Thi B', N'Nhan vien', N'0912345678', N'b.tran@email.com', N'456 Nguyen Trai, TP.HCM', N'Nu')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [SoDienThoai], [Email], [DiaChi], [GioiTinh]) VALUES (N'NV003', N'Le Van C', N'Nhan vien', N'0933456789', N'c.le@email.com', N'789 Tran Hung Dao, TP.HCM', N'Nam')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [SoDienThoai], [Email], [DiaChi], [GioiTinh]) VALUES (N'NV004', N'Pham Thi D', N'Nhan vien', N'0944567890', N'd.pham@email.com', N'123 Ly Thuong Kiet, TP.HCM', N'Nu')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [SoDienThoai], [Email], [DiaChi], [GioiTinh]) VALUES (N'NV005', N'Hoang Van E', N'Nhan vien', N'0955678901', N'e.hoang@email.com', N'456 Cach Mang Thang 8, TP.HCM', N'Nam')
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'admin', N'Admin', N'admin3620', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'levi', N'Levi', N'BiMatNgonTayVaMat', 0)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'staff', N'staff', N'1', 0)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'Trần Phước Thành', N'Thành', N'1', 0)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'TranNgocQuynh', N'Quynh', N'ConGa', 0)
GO
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP001', N'Trá Sữa Phúc Long', N'DM001', 45000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP002', N'Cà Phê Sữa Đá', N'DM001', 39000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP003', N'Sinh Tố Xoài', N'DM001', 55000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP004', N'Bánh Mì Gà Xé', N'DM002', 49000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP005', N'Bánh Croissant', N'DM002', 35000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP006', N'Bánh Tiramisu', N'DM003', 65000)
INSERT [dbo].[ThucPham] ([MaThucPham], [TenThucPham], [MaDanhMuc], [Gia]) VALUES (N'TP007', N'Bánh Cheesecake', N'DM003', 70000)
GO
ALTER TABLE [dbo].[Ban] ADD  DEFAULT (N'Bàn chưa có tên') FOR [TenBan]
GO
ALTER TABLE [dbo].[Ban] ADD  DEFAULT (N'Trống') FOR [TrangThai]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[DanhMuc] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenDanhMuc]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT (N'Genzo') FOR [TenHienThi]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [MatKhau]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[ThucPham] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenThucPham]
GO
ALTER TABLE [dbo].[ThucPham] ADD  DEFAULT ((0)) FOR [Gia]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaThucPham])
REFERENCES [dbo].[ThucPham] ([MaThucPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[ThucPham]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
