USE [HoangLinhBooks]
GO
/****** Object:  User [LinhNguyen_SQLLogin_2]    Script Date: 12/29/2020 6:54:46 PM ******/
CREATE USER [LinhNguyen_SQLLogin_2] FOR LOGIN [LinhNguyen_SQLLogin_2] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [LinhNguyen_SQLLogin_2]
GO
/****** Object:  Schema [LinhNguyen_SQLLogin_2]    Script Date: 12/29/2020 6:54:46 PM ******/
CREATE SCHEMA [LinhNguyen_SQLLogin_2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/29/2020 6:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopChiTietDonHang]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopChiTietDonHang](
	[idDonHang] [int] NOT NULL,
	[idSach] [int] NOT NULL,
	[soLuong] [int] NOT NULL,
	[sachidSach] [int] NULL,
	[sachlanTaiBan] [int] NULL,
	[giaBan] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TapHopChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[idDonHang] ASC,
	[idSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopChiTietGiamGia]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopChiTietGiamGia](
	[idDonHang] [int] NOT NULL,
	[idGiamGia] [int] NOT NULL,
	[soLuong] [int] NOT NULL,
 CONSTRAINT [PK_TapHopChiTietGiamGia] PRIMARY KEY CLUSTERED 
(
	[idDonHang] ASC,
	[idGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopChiTietSach]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopChiTietSach](
	[idSach] [int] NOT NULL,
	[idTacGia] [int] NOT NULL,
	[sachidSach] [int] NULL,
	[sachlanTaiBan] [int] NULL,
 CONSTRAINT [PK_TapHopChiTietSach] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC,
	[idTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopDonHang]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopDonHang](
	[idDonHang] [int] IDENTITY(1,1) NOT NULL,
	[idKhachHang] [int] NOT NULL,
	[thoiGianDatHang] [datetime2](7) NOT NULL,
	[diaChiGiaoHang] [nvarchar](max) NOT NULL,
	[thoiGianGiaoHangDuKien] [datetime2](7) NULL,
	[phiGiaoHang] [decimal](18, 2) NULL,
	[soDienThoai] [nvarchar](max) NOT NULL,
	[VAT] [decimal](18, 2) NOT NULL,
	[tongTien] [decimal](18, 2) NOT NULL,
	[taiKhoanKhachHangidKhachHang] [int] NULL,
	[tenNguoiNhan] [nvarchar](max) NULL,
 CONSTRAINT [PK_TapHopDonHang] PRIMARY KEY CLUSTERED 
(
	[idDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopGiamGia]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopGiamGia](
	[idGiamGia] [int] IDENTITY(1,1) NOT NULL,
	[tenChuongTrinh] [nvarchar](max) NULL,
	[soTienGiam] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TapHopGiamGia] PRIMARY KEY CLUSTERED 
(
	[idGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopLoaiSach]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopLoaiSach](
	[idLoai] [int] IDENTITY(1,1) NOT NULL,
	[tenLoai] [nvarchar](max) NULL,
	[moTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_TapHopLoaiSach] PRIMARY KEY CLUSTERED 
(
	[idLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopNhaXuatBan]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopNhaXuatBan](
	[idNhaXuatBan] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](max) NOT NULL,
	[soDienThoai] [nvarchar](max) NOT NULL,
	[diaChi] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[website] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TapHopNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[idNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopSach]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopSach](
	[idSach] [int] NOT NULL,
	[lanTaiBan] [int] NOT NULL,
	[ten] [nvarchar](max) NULL,
	[idNhaXuatBan] [int] NOT NULL,
	[maLoai] [int] NOT NULL,
	[giaBan] [decimal](18, 2) NOT NULL,
	[soLuong] [int] NOT NULL,
	[moTa] [nvarchar](max) NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[trangThai] [bit] NOT NULL,
	[nhaXuatBanidNhaXuatBan] [int] NULL,
	[loaiSachidLoai] [int] NULL,
 CONSTRAINT [PK_TapHopSach] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC,
	[lanTaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopTacGia]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopTacGia](
	[idTacGia] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](max) NOT NULL,
	[gioiTinh] [int] NOT NULL,
	[namSinh] [datetime2](7) NOT NULL,
	[quocTich] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TapHopTacGia] PRIMARY KEY CLUSTERED 
(
	[idTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopTaiKhoanKhachHang]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopTaiKhoanKhachHang](
	[idKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenKhachHang] [nvarchar](max) NOT NULL,
	[ngaySinh] [datetime2](7) NOT NULL,
	[soDienThoai] [nvarchar](max) NOT NULL,
	[diaChi] [nvarchar](max) NOT NULL,
	[diemMuaHang] [int] NOT NULL,
	[taiKhoan] [nvarchar](max) NOT NULL,
	[matKhau] [nvarchar](max) NOT NULL,
	[trangThai] [bit] NOT NULL,
	[gioiTinh] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TapHopTaiKhoanKhachHang] PRIMARY KEY CLUSTERED 
(
	[idKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopTaiKhoanNhanVien]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopTaiKhoanNhanVien](
	[idNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [nvarchar](max) NULL,
	[soDienThoai] [nvarchar](max) NULL,
	[vaiTro] [nvarchar](max) NULL,
	[matKhau] [nvarchar](max) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_TapHopTaiKhoanNhanVien] PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopTrangThai]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopTrangThai](
	[idTrangThai] [int] IDENTITY(1,1) NOT NULL,
	[kieuTrangThai] [nvarchar](max) NULL,
 CONSTRAINT [PK_TapHopTrangThai] PRIMARY KEY CLUSTERED 
(
	[idTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TapHopTrangThaiDonHang]    Script Date: 12/29/2020 6:54:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TapHopTrangThaiDonHang](
	[idDonHang] [int] NOT NULL,
	[idTrangThai] [int] NOT NULL,
	[idNhanVien] [int] NULL,
	[thoiGian] [datetime2](7) NOT NULL,
	[donHangidDonHang] [int] NULL,
	[trangThaiidTrangThai] [int] NULL,
	[taiKhoanNhanVienidNhanVien] [int] NULL,
 CONSTRAINT [PK_TapHopTrangThaiDonHang] PRIMARY KEY CLUSTERED 
(
	[idDonHang] ASC,
	[idTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (1, 2, 1, NULL, NULL, CAST(41500.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (1, 3, 2, NULL, NULL, CAST(148500.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (2, 2, 1, NULL, NULL, CAST(41500.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (3, 7, 1, NULL, NULL, CAST(77000.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (4, 1, 2, NULL, NULL, CAST(331500.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (4, 3, 1, NULL, NULL, CAST(120000.00 AS Decimal(18, 2)))
INSERT [dbo].[TapHopChiTietDonHang] ([idDonHang], [idSach], [soLuong], [sachidSach], [sachlanTaiBan], [giaBan]) VALUES (4, 15, 3, NULL, NULL, CAST(127500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TapHopChiTietSach] ([idSach], [idTacGia], [sachidSach], [sachlanTaiBan]) VALUES (50, 3, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TapHopDonHang] ON 

INSERT [dbo].[TapHopDonHang] ([idDonHang], [idKhachHang], [thoiGianDatHang], [diaChiGiaoHang], [thoiGianGiaoHangDuKien], [phiGiaoHang], [soDienThoai], [VAT], [tongTien], [taiKhoanKhachHangidKhachHang], [tenNguoiNhan]) VALUES (1, 1, CAST(N'2020-12-26T21:30:20.9074697' AS DateTime2), N'212/58 Thoại Ngọc Hầu, Q.Tân Phú, Hồ Chí Minh ', CAST(N'2020-12-30T00:00:00.0000000' AS DateTime2), CAST(15000.00 AS Decimal(18, 2)), N'0969076447', CAST(33850.00 AS Decimal(18, 2)), CAST(372350.00 AS Decimal(18, 2)), 1, N'Nguyễn Hoàng Linh')
INSERT [dbo].[TapHopDonHang] ([idDonHang], [idKhachHang], [thoiGianDatHang], [diaChiGiaoHang], [thoiGianGiaoHangDuKien], [phiGiaoHang], [soDienThoai], [VAT], [tongTien], [taiKhoanKhachHangidKhachHang], [tenNguoiNhan]) VALUES (2, 1, CAST(N'2020-12-27T12:31:34.4475707' AS DateTime2), N' 212/58 Thoại Ngọc Hầu, Q.Tân Phú, Hồ Chí Minh', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), N'0969076447', CAST(4150.00 AS Decimal(18, 2)), CAST(45650.00 AS Decimal(18, 2)), 1, N'Nguyễn Hoàng Linh')
INSERT [dbo].[TapHopDonHang] ([idDonHang], [idKhachHang], [thoiGianDatHang], [diaChiGiaoHang], [thoiGianGiaoHangDuKien], [phiGiaoHang], [soDienThoai], [VAT], [tongTien], [taiKhoanKhachHangidKhachHang], [tenNguoiNhan]) VALUES (3, 1, CAST(N'2020-12-27T13:04:51.6815863' AS DateTime2), N'58 Nguyễn Sơn, Tân Phú, Hồ Chí Minh', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), N'0969076447', CAST(7700.00 AS Decimal(18, 2)), CAST(84700.00 AS Decimal(18, 2)), NULL, N'Nguyễn Hoàng Linh')
INSERT [dbo].[TapHopDonHang] ([idDonHang], [idKhachHang], [thoiGianDatHang], [diaChiGiaoHang], [thoiGianGiaoHangDuKien], [phiGiaoHang], [soDienThoai], [VAT], [tongTien], [taiKhoanKhachHangidKhachHang], [tenNguoiNhan]) VALUES (4, 1, CAST(N'2020-12-28T18:40:05.5741136' AS DateTime2), N' 100 Trường Chinh, Tân Bình, Hồ Chí Minh', CAST(N'2020-12-30T00:00:00.0000000' AS DateTime2), CAST(20000.00 AS Decimal(18, 2)), N'0977407123', CAST(116550.00 AS Decimal(18, 2)), CAST(1282050.00 AS Decimal(18, 2)), NULL, N'Nguyễn Văn An')
SET IDENTITY_INSERT [dbo].[TapHopDonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[TapHopLoaiSach] ON 

INSERT [dbo].[TapHopLoaiSach] ([idLoai], [tenLoai], [moTa]) VALUES (1, N'Tình cảm', N'abc')
INSERT [dbo].[TapHopLoaiSach] ([idLoai], [tenLoai], [moTa]) VALUES (2, N'Trinh thám', N'abc')
INSERT [dbo].[TapHopLoaiSach] ([idLoai], [tenLoai], [moTa]) VALUES (3, N'Khoa học', N'abc')
INSERT [dbo].[TapHopLoaiSach] ([idLoai], [tenLoai], [moTa]) VALUES (4, N'Lịch sử', N'Abc')
SET IDENTITY_INSERT [dbo].[TapHopLoaiSach] OFF
GO
SET IDENTITY_INSERT [dbo].[TapHopNhaXuatBan] ON 

INSERT [dbo].[TapHopNhaXuatBan] ([idNhaXuatBan], [ten], [soDienThoai], [diaChi], [email], [website]) VALUES (1, N'Phương Nam', N'0378898687', N'21 Hoàng Văn Thụ', N'phuongnam@Gmail.com', N'phuongnam.com')
INSERT [dbo].[TapHopNhaXuatBan] ([idNhaXuatBan], [ten], [soDienThoai], [diaChi], [email], [website]) VALUES (2, N'Tuổi trẻ', N'0969076447', N'25 Nguyễn Sơn', N'tuoitre@gmail.com', N'tuoitre.com')
INSERT [dbo].[TapHopNhaXuatBan] ([idNhaXuatBan], [ten], [soDienThoai], [diaChi], [email], [website]) VALUES (3, N'Fahasha', N'0977477456', N'21 Lê Trọng Tấn', N'fahasha@gmail.com', N'fahasha.com')
INSERT [dbo].[TapHopNhaXuatBan] ([idNhaXuatBan], [ten], [soDienThoai], [diaChi], [email], [website]) VALUES (4, N'sài gòn', N'0977477456', N'21 Quang Trung', N'saigon@gmail.com', N'saigonbook.com')
SET IDENTITY_INSERT [dbo].[TapHopNhaXuatBan] OFF
GO
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (1, 1, N'Việt Nam sử lược', 1, 3, CAST(331500.00 AS Decimal(18, 2)), 148, N'Đầu thế kỷ XX, giữa lúc nền học thuật nước nhà chỉ có các bộ đại tác như Đại Việt sử ký toàn thư hay Khâm định Việt sử thông giám cương mục là nguồn sử liệu chính thống nhưng chưa đáp ứng nhu cầu tìm hiểu lịch sử của phần đông dân chúng, thì Việt Nam sử lược, với tư cách là bộ thông sử chi tiết đầu tiên được viết bằng chữ quốc ngữ, đã xuất hiện và nhanh chóng thu hút sự quan tâm của độc giả lẫn giới nghiên cứu cả nước. Từ đó đến nay đã 100 năm trôi qua, tác phẩm vẫn giữ nguyên giá trị và là quyển sách vỡ lòng quen thuộc cho những ai bắt đầu tìm hiểu lịch sử Việt Nam.', N'https://salt.tikicdn.com/cache/w444/ts/product/b9/f1/24/e8e52fdef621360eabb91eb857996dda.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (2, 1, N'Đêm giáng sinh', 2, 1, CAST(41500.00 AS Decimal(18, 2)), 92, N'Cậu bé kể chuyện có một chú chó nhỏ màu nâu và một chiếc va li cũng màu nâu bí ẩn. Đi qua lớp tuyết dày đặc, cậu muốn chia sẻ một điều vô cùng quan trọng với người bạn đồng hành luôn sẵn lòng đợi mình trên đỉnh ngọn đồi cao cao. Cậu cứ thế leo lên, leo lên mãi rồi cũng tới được đỉnh đồi. Ở đó, cậu đã mở chiếc va li bí ẩn ra và tách tách… âm thanh duy nhất lúc này là giọng đọc từng trang trong cuốn sách yêu thích của cậu. ', N'https://salt.tikicdn.com/cache/w444/ts/product/cd/fa/62/7ff731839450e0fe519ecc8a99c454a2.jpg', 1, 2, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (3, 1, N'Hai số phận', 1, 1, CAST(120000.00 AS Decimal(18, 2)), 92, N'Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là "thánh kinh" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.', N'https://salt.tikicdn.com/cache/w444/ts/product/0a/fb/51/202015881b04b7c8a4b47d15cf9c049f.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (4, 1, N'Quy luật của tấm...', 2, 2, CAST(50000.00 AS Decimal(18, 2)), 98, N'“Hiện thực của cuộc đời chúng ta chính là tấm gương phản chiếu tâm hồn ta”.Quy luật của tấm gương là một cuốn sách dựa trên một câu chuyện có thật, đầy cảm động của bà mẹ Eiko 41 tuổi đã vượt qua những khó khăn trong mối quan hệ với các thành viên trong gia đình, từ đó mở được nút thắt trong việc bày tỏ lòng tin, sự biết ơn và tình yêu để tìm được hạnh phúc cho bản thân và mọi người.Từ câu chuyện của Eiko tác giả muốn gửi gắm tới độc giả một thông điệp rằng “Cuộc đời chính là tấm gương phản chiếu tâm hồn của mỗi người. Hay nói cách khác, mỗi sự việc xảy ra trong cuộc sống của mỗi người đều đồng điệu với suy nghĩ trong tâm hồn họ”. Chính vì cuộc đời phản chiếu suy nghĩ trong tâm hồn, nên mỗi người khi gặp một vấn đề nào đó cần nhìn nhận lại chính bản thân mình, thay đổi bản thân để có thể thay đổi hoàn cảnh.', N'https://salt.tikicdn.com/cache/w444/ts/product/2c/dc/21/63ae92b8087d32daa6bb29d240effb28.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (5, 1, N'Hòm thư số 110', 1, 1, CAST(127500.00 AS Decimal(18, 2)), 102, N'Ở độ tuổi 30, bận bịu trong nhịp sống thường ngày quen thuộc khiến Jin Sol lẳng lặng đem cất những rung động tình yêu xa xỉ vào góc sâu trái tim. Mục tiêu cô đề ra là “Đừng để lòng vướng bận”. Song lẽ dĩ nhiên, trời chẳng chiều lòng người, đợt cải tổ nhân sự định kỳ của đài phát thanh đã mang đến cho cô một cộng sự khó nhằn - một nhà sản xuất chương trình còn sáng tác cả thơ. Để đối phó với anh ta, dường như mọi sự phòng bị là không đủ, hoặc chỉ một cốc smoothie đã đủ…', N'https://salt.tikicdn.com/cache/w444/ts/product/d5/70/40/130ff9342df888366e478c18823d65e9.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (6, 1, N'Nghệ thuật thăng tiến', 1, 3, CAST(169000.00 AS Decimal(18, 2)), 100, N'Cuốn cẩm nang này sẽ giới thiệu những cách làm tối ưu và các kỹ năng cần thiết để xử lý hiệu quả rất nhiều thách thức trong suốt sự nghiệp của một người. Các chủ đề được sắp xếp thành 6 phần:1. Khởi động: xây dựng mạng lưới các mối quan hệ, tìm kiếm việc làm, viết sơ yếu lý lịch, ứng xử trong các cuộc phỏng vấn và bắt đầu công việc một cách suôn sẻ.2. Giao tiếp: bằng lời nói và bằng văn bản, trình bày vấn đề một cách thuyết phục và thuyết trình trực tiếp trước từng đối tượng.3. Cộng tác: giải quyết các xung đột và thách thức, tạo dựng lòng tin và thu hút sự chú ý của mọi người, xử lý các tình huống nan giải và ứng xử với các đồng nghiệp khó tính.4. Thương lượng: các kỹ năng đàm phán, thương lượng về một lời mời làm việc, yêu cầu tăng lương và nói “không” một cách thông minh.5. Mối quan hệ công việc với người quản lý: xây dựng mối quan hệ công việc với quản lý cấp trên, ứng xử với những người quản lý có cá tính, làm việc với các công ty tuyển dụng nhân sự và chuẩn bị cho bản đánh giá hiệu suất công việc.6. Tối ưu hóa thành công trong sự nghiệp: quản lý thời gian và ưu tiên công việc, cách xử lý trước những thay đổi trong công việc, tìm hiểu văn hóa doanh nghiệp nước ngoài và quản lý bản thân trong môi trường doanh nghiệp nước ngoài.', N'https://salt.tikicdn.com/cache/w444/ts/product/7e/a1/59/1ee347e4798c7e27f9473abc07c4c4e5.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (7, 1, N'Tư duy sâu', 2, 3, CAST(65000.00 AS Decimal(18, 2)), 99, N'Trong quá trình phát triển của xã hội loài người, nhân tố quyết định sự mạnh yếu của một cá thể luôn luôn thay đổi.Điểm chung lớn nhất của giới tinh hoa không phải là tài năng xuất chúng, mà là tư duy sâu. Bạn có thể lập được kế hoạch chiến lược như thế nào? Bạn có khả năng tư duy để giải quyết các vấn đề trong cuộc sống hay không? Hay bạn có thể đưa ra được những điều ấy đều cần đến một thứ vũ khí tốt nhất cho não bộ đấy là phương pháp tư duy sâu.', N'https://salt.tikicdn.com/cache/w444/ts/product/76/53/da/3598ca9c124e59cd172a612193d643bf.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (8, 1, N'Tìm bến một mơ', 1, 1, CAST(68500.00 AS Decimal(18, 2)), 100, N'"Nhạc từ đâu lạc điệu những âm thanh không âmChảy tràn trên vết thương mủ vàng bãi lầy không thậtCái đau này không phải mìnhKhông khí chảy qua tế bào này không phải mìnhMáu đập từng nhịp qua mạch hở này không phải mìnhSự sống này không dành cho mìnhDuyên cớ gì tái sinh?"', N'https://salt.tikicdn.com/cache/w444/ts/product/66/b0/17/50b6690aae5b1b438741a79de49898b7.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (9, 1, N'Kẻ nhu nhược', 1, 2, CAST(128000.00 AS Decimal(18, 2)), 100, N'Câu chuyện có tính chất truyền kỳ về Mã Đán-con trai duy nhất của lão chủ ba cửa hàng buôn gạo Mã Cạo Đầu, bản tính nhát gan; trung hậu nhưng cam chịu, nhẫn nhục; bị người xa kẻ gần gắn cho cái biệt danh là “thằng nhu nhược”. Sống trong cái vòng lẩn quẩn của hai quan niệm “nhu nhược thì sống lâu” và “kẻ không sợ chết mới có thể sống”, Mã Đán rất muốn thay đổi hình ảnh, muốn cải tạo cái tính cách nhu nhược của mình, không ngừng “luyện gan”, kết quả là mắc lừa tên ác bá trong thị trấn là Hồng Xung, phải đem ba cửa hàng gạo tổ tiên truyền lại bồi thường cho lão, chỉ một thời gian ngắn đã khuynh gia bại sản.', N'https://salt.tikicdn.com/cache/w444/ts/product/cb/df/97/f46fd97e62f845b2f344358a032ed49c.jpg', 1, 1, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (10, 1, N'Tôi là kẻ ác', 2, 2, CAST(102500.00 AS Decimal(18, 2)), 100, N'Tôi là kẻ ác của Lý Ước Nhiệt kể về câu chuyện của trấn Dã Mã, Trung Quốc những năm 1982, nổi bật nhất là câu chuyện hai gia đình Mã Vạn Lương và Hoàng Thiếu Liệt. Trên phông nền mâu thuẫn giữa hai gia đình coi bên kia là kẻ thù không đội trời chung, hình ảnh trấn Dã Mã hiện lên rõ nét với đủ mọi vấn nạn xã hội, mà vấn nạn nghiêm trọng nhất là sự vô tâm, dửng dung, ích kỉ của con người trước khổ đau, nỗi oan ức của người khác.', N'https://salt.tikicdn.com/cache/w444/ts/product/01/9e/07/a2dd06b557af74ccff7f5636ba4cb202.jpg', 1, 2, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (11, 1, N'Viên chức nhà nước', 2, 3, CAST(119500.00 AS Decimal(18, 2)), 100, N'Ngô Khởi Minh sau khi tốt nghiệp nghiên cứu sinh vào làm ở một cơ quan nhà nước được bảy năm, được đề bạt làm phó chủ nhiệm quản lý hành chính của văn phòng cấp sở. Sự thay đổi thân phận khiến cuộc sống của anh và mối quan hệ với các đồng nghiệp, lãnh đạo… đã hoàn toàn thay đổi.', N'https://salt.tikicdn.com/cache/w444/ts/product/80/b4/6b/908b7e3bec3efe5830f11e1d6ba5879d.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (12, 1, N'Ngôi nhà tranh', 4, 1, CAST(94000.00 AS Decimal(18, 2)), 100, N'Ngôi nhà tranh là tập hợp những câu chuyện đời thường, bình dị khó quên xoay quanh cuộc sống của cậu bé Tang Tang. Cậu thích chọc phá cậu bạn ngồi cùng bàn tên Lục Hạc vì cái đầu trọc lốc của cậu ta. Cậu có một thứ tình cảm ngượng ngùng không thể nói thành lời với cô bạn học Chỉ Nguyệt đến từ làng khác. Cậu ganh tị với cậu lớp trưởng Đỗ Tiểu Khang vì tính dám làm dám chịu, khiến cho Tang Tang bị bạn bè xem như “tội đồ”, nhưng sau đó Đỗ Tiểu Khang lại là người làm Tang Tang khâm phục nhất. Tang Tang là cầu nối tình yêu cho thầy giáo dạy Văn hay, thổi sao giỏi – Tưởng Nhất Luân với cô gái được dân làng xem là mỹ nhân – Bạch Tước. Nhưng chính vì cái tình hiếu thắng hay tò mò của cậu mà làm mối tình này phải gãy gánh giữa đàng. ', N'https://salt.tikicdn.com/cache/w444/ts/product/01/87/ce/c35b8b3f53e98a2ce33cd4b953ddd095.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (13, 1, N'Việt Nam sử lược', 1, 3, CAST(148500.00 AS Decimal(18, 2)), 120, N'Đầu thế kỷ XX, giữa lúc nền học thuật nước nhà chỉ có các bộ đại tác như Đại Việt sử ký toàn thư hay Khâm định Việt sử thông giám cương mục là nguồn sử liệu chính thống nhưng chưa đáp ứng nhu cầu tìm hiểu lịch sử của phần đông dân chúng, thì Việt Nam sử lược, với tư cách là bộ thông sử chi tiết đầu tiên được viết bằng chữ quốc ngữ, đã xuất hiện và nhanh chóng thu hút sự quan tâm của độc giả lẫn giới nghiên cứu cả nước. Từ đó đến nay đã 100 năm trôi qua, tác phẩm vẫn giữ nguyên giá trị và là quyển sách vỡ lòng quen thuộc cho những ai bắt đầu tìm hiểu lịch sử Việt Nam.', N'https://salt.tikicdn.com/cache/w444/ts/product/b9/f1/24/e8e52fdef621360eabb91eb857996dda.jpg', 0, NULL, NULL)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (14, 1, N'Đêm giáng sinh', 2, 1, CAST(50000.00 AS Decimal(18, 2)), 120, N'Cậu bé kể chuyện có một chú chó nhỏ màu nâu và một chiếc va li cũng màu nâu bí ẩn. Đi qua lớp tuyết dày đặc, cậu muốn chia sẻ một điều vô cùng quan trọng với người bạn đồng hành luôn sẵn lòng đợi mình trên đỉnh ngọn đồi cao cao. Cậu cứ thế leo lên, leo lên mãi rồi cũng tới được đỉnh đồi. Ở đó, cậu đã mở chiếc va li bí ẩn ra và tách tách… âm thanh duy nhất lúc này là giọng đọc từng trang trong cuốn sách yêu thích của cậu. ', N'https://salt.tikicdn.com/cache/w444/ts/product/cd/fa/62/7ff731839450e0fe519ecc8a99c454a2.jpg', 0, 2, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (15, 1, N'Hòm thư số 110', 1, 1, CAST(127500.00 AS Decimal(18, 2)), 99, N'Ở độ tuổi 30, bận bịu trong nhịp sống thường ngày quen thuộc khiến Jin Sol lẳng lặng đem cất những rung động tình yêu xa xỉ vào góc sâu trái tim. Mục tiêu cô đề ra là “Đừng để lòng vướng bận”. Song lẽ dĩ nhiên, trời chẳng chiều lòng người, đợt cải tổ nhân sự định kỳ của đài phát thanh đã mang đến cho cô một cộng sự khó nhằn - một nhà sản xuất chương trình còn sáng tác cả thơ. Để đối phó với anh ta, dường như mọi sự phòng bị là không đủ, hoặc chỉ một cốc smoothie đã đủ…', N'https://salt.tikicdn.com/cache/w444/ts/product/d5/70/40/130ff9342df888366e478c18823d65e9.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (16, 1, N'Nghệ thuật thăng tiến', 1, 3, CAST(169000.00 AS Decimal(18, 2)), 100, N'Cuốn cẩm nang này sẽ giới thiệu những cách làm tối ưu và các kỹ năng cần thiết để xử lý hiệu quả rất nhiều thách thức trong suốt sự nghiệp của một người. Các chủ đề được sắp xếp thành 6 phần:1. Khởi động: xây dựng mạng lưới các mối quan hệ, tìm kiếm việc làm, viết sơ yếu lý lịch, ứng xử trong các cuộc phỏng vấn và bắt đầu công việc một cách suôn sẻ.2. Giao tiếp: bằng lời nói và bằng văn bản, trình bày vấn đề một cách thuyết phục và thuyết trình trực tiếp trước từng đối tượng.3. Cộng tác: giải quyết các xung đột và thách thức, tạo dựng lòng tin và thu hút sự chú ý của mọi người, xử lý các tình huống nan giải và ứng xử với các đồng nghiệp khó tính.4. Thương lượng: các kỹ năng đàm phán, thương lượng về một lời mời làm việc, yêu cầu tăng lương và nói “không” một cách thông minh.5. Mối quan hệ công việc với người quản lý: xây dựng mối quan hệ công việc với quản lý cấp trên, ứng xử với những người quản lý có cá tính, làm việc với các công ty tuyển dụng nhân sự và chuẩn bị cho bản đánh giá hiệu suất công việc.6. Tối ưu hóa thành công trong sự nghiệp: quản lý thời gian và ưu tiên công việc, cách xử lý trước những thay đổi trong công việc, tìm hiểu văn hóa doanh nghiệp nước ngoài và quản lý bản thân trong môi trường doanh nghiệp nước ngoài.', N'https://salt.tikicdn.com/cache/w444/ts/product/7e/a1/59/1ee347e4798c7e27f9473abc07c4c4e5.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (17, 1, N'Tư duy sâu', 2, 3, CAST(77000.00 AS Decimal(18, 2)), 99, N'Trong quá trình phát triển của xã hội loài người, nhân tố quyết định sự mạnh yếu của một cá thể luôn luôn thay đổi.Điểm chung lớn nhất của giới tinh hoa không phải là tài năng xuất chúng, mà là tư duy sâu. Bạn có thể lập được kế hoạch chiến lược như thế nào? Bạn có khả năng tư duy để giải quyết các vấn đề trong cuộc sống hay không? Hay bạn có thể đưa ra được những điều ấy đều cần đến một thứ vũ khí tốt nhất cho não bộ đấy là phương pháp tư duy sâu.', N'https://salt.tikicdn.com/cache/w444/ts/product/76/53/da/3598ca9c124e59cd172a612193d643bf.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (18, 1, N'Tìm bến một mơ', 1, 1, CAST(68500.00 AS Decimal(18, 2)), 100, N'"Nhạc từ đâu lạc điệu những âm thanh không âmChảy tràn trên vết thương mủ vàng bãi lầy không thậtCái đau này không phải mìnhKhông khí chảy qua tế bào này không phải mìnhMáu đập từng nhịp qua mạch hở này không phải mìnhSự sống này không dành cho mìnhDuyên cớ gì tái sinh?"', N'https://salt.tikicdn.com/cache/w444/ts/product/66/b0/17/50b6690aae5b1b438741a79de49898b7.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (19, 1, N'Kẻ nhu nhược', 1, 2, CAST(128000.00 AS Decimal(18, 2)), 100, N'Câu chuyện có tính chất truyền kỳ về Mã Đán-con trai duy nhất của lão chủ ba cửa hàng buôn gạo Mã Cạo Đầu, bản tính nhát gan; trung hậu nhưng cam chịu, nhẫn nhục; bị người xa kẻ gần gắn cho cái biệt danh là “thằng nhu nhược”. Sống trong cái vòng lẩn quẩn của hai quan niệm “nhu nhược thì sống lâu” và “kẻ không sợ chết mới có thể sống”, Mã Đán rất muốn thay đổi hình ảnh, muốn cải tạo cái tính cách nhu nhược của mình, không ngừng “luyện gan”, kết quả là mắc lừa tên ác bá trong thị trấn là Hồng Xung, phải đem ba cửa hàng gạo tổ tiên truyền lại bồi thường cho lão, chỉ một thời gian ngắn đã khuynh gia bại sản.', N'https://salt.tikicdn.com/cache/w444/ts/product/cb/df/97/f46fd97e62f845b2f344358a032ed49c.jpg', 1, 1, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (20, 1, N'Tôi là kẻ ác', 2, 2, CAST(102500.00 AS Decimal(18, 2)), 100, N'Tôi là kẻ ác của Lý Ước Nhiệt kể về câu chuyện của trấn Dã Mã, Trung Quốc những năm 1982, nổi bật nhất là câu chuyện hai gia đình Mã Vạn Lương và Hoàng Thiếu Liệt. Trên phông nền mâu thuẫn giữa hai gia đình coi bên kia là kẻ thù không đội trời chung, hình ảnh trấn Dã Mã hiện lên rõ nét với đủ mọi vấn nạn xã hội, mà vấn nạn nghiêm trọng nhất là sự vô tâm, dửng dung, ích kỉ của con người trước khổ đau, nỗi oan ức của người khác.', N'https://salt.tikicdn.com/cache/w444/ts/product/01/9e/07/a2dd06b557af74ccff7f5636ba4cb202.jpg', 1, 2, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (21, 1, N'Viên chức nhà nước', 2, 3, CAST(119500.00 AS Decimal(18, 2)), 100, N'Ngô Khởi Minh sau khi tốt nghiệp nghiên cứu sinh vào làm ở một cơ quan nhà nước được bảy năm, được đề bạt làm phó chủ nhiệm quản lý hành chính của văn phòng cấp sở. Sự thay đổi thân phận khiến cuộc sống của anh và mối quan hệ với các đồng nghiệp, lãnh đạo… đã hoàn toàn thay đổi.', N'https://salt.tikicdn.com/cache/w444/ts/product/80/b4/6b/908b7e3bec3efe5830f11e1d6ba5879d.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (22, 1, N'Ngôi nhà tranh', 4, 1, CAST(94000.00 AS Decimal(18, 2)), 100, N'Ngôi nhà tranh là tập hợp những câu chuyện đời thường, bình dị khó quên xoay quanh cuộc sống của cậu bé Tang Tang. Cậu thích chọc phá cậu bạn ngồi cùng bàn tên Lục Hạc vì cái đầu trọc lốc của cậu ta. Cậu có một thứ tình cảm ngượng ngùng không thể nói thành lời với cô bạn học Chỉ Nguyệt đến từ làng khác. Cậu ganh tị với cậu lớp trưởng Đỗ Tiểu Khang vì tính dám làm dám chịu, khiến cho Tang Tang bị bạn bè xem như “tội đồ”, nhưng sau đó Đỗ Tiểu Khang lại là người làm Tang Tang khâm phục nhất. Tang Tang là cầu nối tình yêu cho thầy giáo dạy Văn hay, thổi sao giỏi – Tưởng Nhất Luân với cô gái được dân làng xem là mỹ nhân – Bạch Tước. Nhưng chính vì cái tình hiếu thắng hay tò mò của cậu mà làm mối tình này phải gãy gánh giữa đàng. ', N'https://salt.tikicdn.com/cache/w444/ts/product/01/87/ce/c35b8b3f53e98a2ce33cd4b953ddd095.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (23, 1, N'Việt Nam sử lược', 1, 3, CAST(331500.00 AS Decimal(18, 2)), 150, N'Đầu thế kỷ XX, giữa lúc nền học thuật nước nhà chỉ có các bộ đại tác như Đại Việt sử ký toàn thư hay Khâm định Việt sử thông giám cương mục là nguồn sử liệu chính thống nhưng chưa đáp ứng nhu cầu tìm hiểu lịch sử của phần đông dân chúng, thì Việt Nam sử lược, với tư cách là bộ thông sử chi tiết đầu tiên được viết bằng chữ quốc ngữ, đã xuất hiện và nhanh chóng thu hút sự quan tâm của độc giả lẫn giới nghiên cứu cả nước. Từ đó đến nay đã 100 năm trôi qua, tác phẩm vẫn giữ nguyên giá trị và là quyển sách vỡ lòng quen thuộc cho những ai bắt đầu tìm hiểu lịch sử Việt Nam.', N'https://salt.tikicdn.com/cache/w444/ts/product/b9/f1/24/e8e52fdef621360eabb91eb857996dda.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (24, 1, N'Đêm giáng sinh', 2, 1, CAST(41500.00 AS Decimal(18, 2)), 91, N'Cậu bé kể chuyện có một chú chó nhỏ màu nâu và một chiếc va li cũng màu nâu bí ẩn. Đi qua lớp tuyết dày đặc, cậu muốn chia sẻ một điều vô cùng quan trọng với người bạn đồng hành luôn sẵn lòng đợi mình trên đỉnh ngọn đồi cao cao. Cậu cứ thế leo lên, leo lên mãi rồi cũng tới được đỉnh đồi. Ở đó, cậu đã mở chiếc va li bí ẩn ra và tách tách… âm thanh duy nhất lúc này là giọng đọc từng trang trong cuốn sách yêu thích của cậu. ', N'https://salt.tikicdn.com/cache/w444/ts/product/cd/fa/62/7ff731839450e0fe519ecc8a99c454a2.jpg', 1, 2, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (25, 1, N'Hai số phận', 1, 1, CAST(148500.00 AS Decimal(18, 2)), 93, N'Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là "thánh kinh" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.', N'https://salt.tikicdn.com/cache/w444/ts/product/0a/fb/51/202015881b04b7c8a4b47d15cf9c049f.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (26, 1, N'Quy luật của tấm...', 2, 2, CAST(50000.00 AS Decimal(18, 2)), 98, N'“Hiện thực của cuộc đời chúng ta chính là tấm gương phản chiếu tâm hồn ta”.Quy luật của tấm gương là một cuốn sách dựa trên một câu chuyện có thật, đầy cảm động của bà mẹ Eiko 41 tuổi đã vượt qua những khó khăn trong mối quan hệ với các thành viên trong gia đình, từ đó mở được nút thắt trong việc bày tỏ lòng tin, sự biết ơn và tình yêu để tìm được hạnh phúc cho bản thân và mọi người.Từ câu chuyện của Eiko tác giả muốn gửi gắm tới độc giả một thông điệp rằng “Cuộc đời chính là tấm gương phản chiếu tâm hồn của mỗi người. Hay nói cách khác, mỗi sự việc xảy ra trong cuộc sống của mỗi người đều đồng điệu với suy nghĩ trong tâm hồn họ”. Chính vì cuộc đời phản chiếu suy nghĩ trong tâm hồn, nên mỗi người khi gặp một vấn đề nào đó cần nhìn nhận lại chính bản thân mình, thay đổi bản thân để có thể thay đổi hoàn cảnh.', N'https://salt.tikicdn.com/cache/w444/ts/product/2c/dc/21/63ae92b8087d32daa6bb29d240effb28.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (27, 1, N'Kẻ nhu nhược', 1, 2, CAST(128000.00 AS Decimal(18, 2)), 100, N'Câu chuyện có tính chất truyền kỳ về Mã Đán-con trai duy nhất của lão chủ ba cửa hàng buôn gạo Mã Cạo Đầu, bản tính nhát gan; trung hậu nhưng cam chịu, nhẫn nhục; bị người xa kẻ gần gắn cho cái biệt danh là “thằng nhu nhược”. Sống trong cái vòng lẩn quẩn của hai quan niệm “nhu nhược thì sống lâu” và “kẻ không sợ chết mới có thể sống”, Mã Đán rất muốn thay đổi hình ảnh, muốn cải tạo cái tính cách nhu nhược của mình, không ngừng “luyện gan”, kết quả là mắc lừa tên ác bá trong thị trấn là Hồng Xung, phải đem ba cửa hàng gạo tổ tiên truyền lại bồi thường cho lão, chỉ một thời gian ngắn đã khuynh gia bại sản.', N'https://salt.tikicdn.com/cache/w444/ts/product/cb/df/97/f46fd97e62f845b2f344358a032ed49c.jpg', 1, 1, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (28, 1, N'Tôi là kẻ ác', 2, 2, CAST(102500.00 AS Decimal(18, 2)), 100, N'Tôi là kẻ ác của Lý Ước Nhiệt kể về câu chuyện của trấn Dã Mã, Trung Quốc những năm 1982, nổi bật nhất là câu chuyện hai gia đình Mã Vạn Lương và Hoàng Thiếu Liệt. Trên phông nền mâu thuẫn giữa hai gia đình coi bên kia là kẻ thù không đội trời chung, hình ảnh trấn Dã Mã hiện lên rõ nét với đủ mọi vấn nạn xã hội, mà vấn nạn nghiêm trọng nhất là sự vô tâm, dửng dung, ích kỉ của con người trước khổ đau, nỗi oan ức của người khác.', N'https://salt.tikicdn.com/cache/w444/ts/product/01/9e/07/a2dd06b557af74ccff7f5636ba4cb202.jpg', 1, 2, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (29, 1, N'Viên chức nhà nước', 2, 3, CAST(119500.00 AS Decimal(18, 2)), 100, N'Ngô Khởi Minh sau khi tốt nghiệp nghiên cứu sinh vào làm ở một cơ quan nhà nước được bảy năm, được đề bạt làm phó chủ nhiệm quản lý hành chính của văn phòng cấp sở. Sự thay đổi thân phận khiến cuộc sống của anh và mối quan hệ với các đồng nghiệp, lãnh đạo… đã hoàn toàn thay đổi.', N'https://salt.tikicdn.com/cache/w444/ts/product/80/b4/6b/908b7e3bec3efe5830f11e1d6ba5879d.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (30, 1, N'Ngôi nhà tranh', 4, 1, CAST(94000.00 AS Decimal(18, 2)), 100, N'Ngôi nhà tranh là tập hợp những câu chuyện đời thường, bình dị khó quên xoay quanh cuộc sống của cậu bé Tang Tang. Cậu thích chọc phá cậu bạn ngồi cùng bàn tên Lục Hạc vì cái đầu trọc lốc của cậu ta. Cậu có một thứ tình cảm ngượng ngùng không thể nói thành lời với cô bạn học Chỉ Nguyệt đến từ làng khác. Cậu ganh tị với cậu lớp trưởng Đỗ Tiểu Khang vì tính dám làm dám chịu, khiến cho Tang Tang bị bạn bè xem như “tội đồ”, nhưng sau đó Đỗ Tiểu Khang lại là người làm Tang Tang khâm phục nhất. Tang Tang là cầu nối tình yêu cho thầy giáo dạy Văn hay, thổi sao giỏi – Tưởng Nhất Luân với cô gái được dân làng xem là mỹ nhân – Bạch Tước. Nhưng chính vì cái tình hiếu thắng hay tò mò của cậu mà làm mối tình này phải gãy gánh giữa đàng. ', N'https://salt.tikicdn.com/cache/w444/ts/product/01/87/ce/c35b8b3f53e98a2ce33cd4b953ddd095.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (31, 1, N'Việt Nam sử lược', 1, 3, CAST(331500.00 AS Decimal(18, 2)), 150, N'Đầu thế kỷ XX, giữa lúc nền học thuật nước nhà chỉ có các bộ đại tác như Đại Việt sử ký toàn thư hay Khâm định Việt sử thông giám cương mục là nguồn sử liệu chính thống nhưng chưa đáp ứng nhu cầu tìm hiểu lịch sử của phần đông dân chúng, thì Việt Nam sử lược, với tư cách là bộ thông sử chi tiết đầu tiên được viết bằng chữ quốc ngữ, đã xuất hiện và nhanh chóng thu hút sự quan tâm của độc giả lẫn giới nghiên cứu cả nước. Từ đó đến nay đã 100 năm trôi qua, tác phẩm vẫn giữ nguyên giá trị và là quyển sách vỡ lòng quen thuộc cho những ai bắt đầu tìm hiểu lịch sử Việt Nam.', N'https://salt.tikicdn.com/cache/w444/ts/product/b9/f1/24/e8e52fdef621360eabb91eb857996dda.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (32, 1, N'Đêm giáng sinh', 2, 1, CAST(41500.00 AS Decimal(18, 2)), 91, N'Cậu bé kể chuyện có một chú chó nhỏ màu nâu và một chiếc va li cũng màu nâu bí ẩn. Đi qua lớp tuyết dày đặc, cậu muốn chia sẻ một điều vô cùng quan trọng với người bạn đồng hành luôn sẵn lòng đợi mình trên đỉnh ngọn đồi cao cao. Cậu cứ thế leo lên, leo lên mãi rồi cũng tới được đỉnh đồi. Ở đó, cậu đã mở chiếc va li bí ẩn ra và tách tách… âm thanh duy nhất lúc này là giọng đọc từng trang trong cuốn sách yêu thích của cậu. ', N'https://salt.tikicdn.com/cache/w444/ts/product/cd/fa/62/7ff731839450e0fe519ecc8a99c454a2.jpg', 1, 2, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (33, 1, N'Hai số phận', 1, 1, CAST(148500.00 AS Decimal(18, 2)), 93, N'Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là "thánh kinh" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.', N'https://salt.tikicdn.com/cache/w444/ts/product/0a/fb/51/202015881b04b7c8a4b47d15cf9c049f.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (34, 1, N'Quy luật của tấm...', 2, 2, CAST(50000.00 AS Decimal(18, 2)), 98, N'“Hiện thực của cuộc đời chúng ta chính là tấm gương phản chiếu tâm hồn ta”.Quy luật của tấm gương là một cuốn sách dựa trên một câu chuyện có thật, đầy cảm động của bà mẹ Eiko 41 tuổi đã vượt qua những khó khăn trong mối quan hệ với các thành viên trong gia đình, từ đó mở được nút thắt trong việc bày tỏ lòng tin, sự biết ơn và tình yêu để tìm được hạnh phúc cho bản thân và mọi người.Từ câu chuyện của Eiko tác giả muốn gửi gắm tới độc giả một thông điệp rằng “Cuộc đời chính là tấm gương phản chiếu tâm hồn của mỗi người. Hay nói cách khác, mỗi sự việc xảy ra trong cuộc sống của mỗi người đều đồng điệu với suy nghĩ trong tâm hồn họ”. Chính vì cuộc đời phản chiếu suy nghĩ trong tâm hồn, nên mỗi người khi gặp một vấn đề nào đó cần nhìn nhận lại chính bản thân mình, thay đổi bản thân để có thể thay đổi hoàn cảnh.', N'https://salt.tikicdn.com/cache/w444/ts/product/2c/dc/21/63ae92b8087d32daa6bb29d240effb28.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (35, 1, N'Hòm thư số 110', 1, 1, CAST(127500.00 AS Decimal(18, 2)), 102, N'Ở độ tuổi 30, bận bịu trong nhịp sống thường ngày quen thuộc khiến Jin Sol lẳng lặng đem cất những rung động tình yêu xa xỉ vào góc sâu trái tim. Mục tiêu cô đề ra là “Đừng để lòng vướng bận”. Song lẽ dĩ nhiên, trời chẳng chiều lòng người, đợt cải tổ nhân sự định kỳ của đài phát thanh đã mang đến cho cô một cộng sự khó nhằn - một nhà sản xuất chương trình còn sáng tác cả thơ. Để đối phó với anh ta, dường như mọi sự phòng bị là không đủ, hoặc chỉ một cốc smoothie đã đủ…', N'https://salt.tikicdn.com/cache/w444/ts/product/d5/70/40/130ff9342df888366e478c18823d65e9.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (36, 1, N'Nghệ thuật thăng tiến', 1, 3, CAST(169000.00 AS Decimal(18, 2)), 100, N'Cuốn cẩm nang này sẽ giới thiệu những cách làm tối ưu và các kỹ năng cần thiết để xử lý hiệu quả rất nhiều thách thức trong suốt sự nghiệp của một người. Các chủ đề được sắp xếp thành 6 phần:1. Khởi động: xây dựng mạng lưới các mối quan hệ, tìm kiếm việc làm, viết sơ yếu lý lịch, ứng xử trong các cuộc phỏng vấn và bắt đầu công việc một cách suôn sẻ.2. Giao tiếp: bằng lời nói và bằng văn bản, trình bày vấn đề một cách thuyết phục và thuyết trình trực tiếp trước từng đối tượng.3. Cộng tác: giải quyết các xung đột và thách thức, tạo dựng lòng tin và thu hút sự chú ý của mọi người, xử lý các tình huống nan giải và ứng xử với các đồng nghiệp khó tính.4. Thương lượng: các kỹ năng đàm phán, thương lượng về một lời mời làm việc, yêu cầu tăng lương và nói “không” một cách thông minh.5. Mối quan hệ công việc với người quản lý: xây dựng mối quan hệ công việc với quản lý cấp trên, ứng xử với những người quản lý có cá tính, làm việc với các công ty tuyển dụng nhân sự và chuẩn bị cho bản đánh giá hiệu suất công việc.6. Tối ưu hóa thành công trong sự nghiệp: quản lý thời gian và ưu tiên công việc, cách xử lý trước những thay đổi trong công việc, tìm hiểu văn hóa doanh nghiệp nước ngoài và quản lý bản thân trong môi trường doanh nghiệp nước ngoài.', N'https://salt.tikicdn.com/cache/w444/ts/product/7e/a1/59/1ee347e4798c7e27f9473abc07c4c4e5.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (37, 1, N'Tư duy sâu', 2, 3, CAST(77000.00 AS Decimal(18, 2)), 99, N'Trong quá trình phát triển của xã hội loài người, nhân tố quyết định sự mạnh yếu của một cá thể luôn luôn thay đổi.Điểm chung lớn nhất của giới tinh hoa không phải là tài năng xuất chúng, mà là tư duy sâu. Bạn có thể lập được kế hoạch chiến lược như thế nào? Bạn có khả năng tư duy để giải quyết các vấn đề trong cuộc sống hay không? Hay bạn có thể đưa ra được những điều ấy đều cần đến một thứ vũ khí tốt nhất cho não bộ đấy là phương pháp tư duy sâu.', N'https://salt.tikicdn.com/cache/w444/ts/product/76/53/da/3598ca9c124e59cd172a612193d643bf.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (38, 1, N'Tìm bến một mơ', 1, 1, CAST(68500.00 AS Decimal(18, 2)), 100, N'"Nhạc từ đâu lạc điệu những âm thanh không âmChảy tràn trên vết thương mủ vàng bãi lầy không thậtCái đau này không phải mìnhKhông khí chảy qua tế bào này không phải mìnhMáu đập từng nhịp qua mạch hở này không phải mìnhSự sống này không dành cho mìnhDuyên cớ gì tái sinh?"', N'https://salt.tikicdn.com/cache/w444/ts/product/66/b0/17/50b6690aae5b1b438741a79de49898b7.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (39, 1, N'Ngôi nhà tranh', 4, 1, CAST(94000.00 AS Decimal(18, 2)), 100, N'Ngôi nhà tranh là tập hợp những câu chuyện đời thường, bình dị khó quên xoay quanh cuộc sống của cậu bé Tang Tang. Cậu thích chọc phá cậu bạn ngồi cùng bàn tên Lục Hạc vì cái đầu trọc lốc của cậu ta. Cậu có một thứ tình cảm ngượng ngùng không thể nói thành lời với cô bạn học Chỉ Nguyệt đến từ làng khác. Cậu ganh tị với cậu lớp trưởng Đỗ Tiểu Khang vì tính dám làm dám chịu, khiến cho Tang Tang bị bạn bè xem như “tội đồ”, nhưng sau đó Đỗ Tiểu Khang lại là người làm Tang Tang khâm phục nhất. Tang Tang là cầu nối tình yêu cho thầy giáo dạy Văn hay, thổi sao giỏi – Tưởng Nhất Luân với cô gái được dân làng xem là mỹ nhân – Bạch Tước. Nhưng chính vì cái tình hiếu thắng hay tò mò của cậu mà làm mối tình này phải gãy gánh giữa đàng. ', N'https://salt.tikicdn.com/cache/w444/ts/product/01/87/ce/c35b8b3f53e98a2ce33cd4b953ddd095.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (40, 1, N'Viên chức nhà nước', 2, 3, CAST(119500.00 AS Decimal(18, 2)), 100, N'Ngô Khởi Minh sau khi tốt nghiệp nghiên cứu sinh vào làm ở một cơ quan nhà nước được bảy năm, được đề bạt làm phó chủ nhiệm quản lý hành chính của văn phòng cấp sở. Sự thay đổi thân phận khiến cuộc sống của anh và mối quan hệ với các đồng nghiệp, lãnh đạo… đã hoàn toàn thay đổi.', N'https://salt.tikicdn.com/cache/w444/ts/product/80/b4/6b/908b7e3bec3efe5830f11e1d6ba5879d.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (41, 1, N'Tôi là kẻ ác', 2, 2, CAST(102500.00 AS Decimal(18, 2)), 100, N'Tôi là kẻ ác của Lý Ước Nhiệt kể về câu chuyện của trấn Dã Mã, Trung Quốc những năm 1982, nổi bật nhất là câu chuyện hai gia đình Mã Vạn Lương và Hoàng Thiếu Liệt. Trên phông nền mâu thuẫn giữa hai gia đình coi bên kia là kẻ thù không đội trời chung, hình ảnh trấn Dã Mã hiện lên rõ nét với đủ mọi vấn nạn xã hội, mà vấn nạn nghiêm trọng nhất là sự vô tâm, dửng dung, ích kỉ của con người trước khổ đau, nỗi oan ức của người khác.', N'https://salt.tikicdn.com/cache/w444/ts/product/01/9e/07/a2dd06b557af74ccff7f5636ba4cb202.jpg', 1, 2, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (42, 1, N'Kẻ nhu nhược', 1, 2, CAST(128000.00 AS Decimal(18, 2)), 100, N'Câu chuyện có tính chất truyền kỳ về Mã Đán-con trai duy nhất của lão chủ ba cửa hàng buôn gạo Mã Cạo Đầu, bản tính nhát gan; trung hậu nhưng cam chịu, nhẫn nhục; bị người xa kẻ gần gắn cho cái biệt danh là “thằng nhu nhược”. Sống trong cái vòng lẩn quẩn của hai quan niệm “nhu nhược thì sống lâu” và “kẻ không sợ chết mới có thể sống”, Mã Đán rất muốn thay đổi hình ảnh, muốn cải tạo cái tính cách nhu nhược của mình, không ngừng “luyện gan”, kết quả là mắc lừa tên ác bá trong thị trấn là Hồng Xung, phải đem ba cửa hàng gạo tổ tiên truyền lại bồi thường cho lão, chỉ một thời gian ngắn đã khuynh gia bại sản.', N'https://salt.tikicdn.com/cache/w444/ts/product/cb/df/97/f46fd97e62f845b2f344358a032ed49c.jpg', 1, 1, 2)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (43, 1, N'Tìm bến một mơ', 1, 1, CAST(68500.00 AS Decimal(18, 2)), 100, N'"Nhạc từ đâu lạc điệu những âm thanh không âmChảy tràn trên vết thương mủ vàng bãi lầy không thậtCái đau này không phải mìnhKhông khí chảy qua tế bào này không phải mìnhMáu đập từng nhịp qua mạch hở này không phải mìnhSự sống này không dành cho mìnhDuyên cớ gì tái sinh?"', N'https://salt.tikicdn.com/cache/w444/ts/product/66/b0/17/50b6690aae5b1b438741a79de49898b7.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (44, 1, N'Tư duy sâu', 2, 3, CAST(77000.00 AS Decimal(18, 2)), 99, N'Trong quá trình phát triển của xã hội loài người, nhân tố quyết định sự mạnh yếu của một cá thể luôn luôn thay đổi.Điểm chung lớn nhất của giới tinh hoa không phải là tài năng xuất chúng, mà là tư duy sâu. Bạn có thể lập được kế hoạch chiến lược như thế nào? Bạn có khả năng tư duy để giải quyết các vấn đề trong cuộc sống hay không? Hay bạn có thể đưa ra được những điều ấy đều cần đến một thứ vũ khí tốt nhất cho não bộ đấy là phương pháp tư duy sâu.', N'https://salt.tikicdn.com/cache/w444/ts/product/76/53/da/3598ca9c124e59cd172a612193d643bf.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (45, 1, N'Nghệ thuật thăng tiến', 1, 3, CAST(169000.00 AS Decimal(18, 2)), 100, N'Cuốn cẩm nang này sẽ giới thiệu những cách làm tối ưu và các kỹ năng cần thiết để xử lý hiệu quả rất nhiều thách thức trong suốt sự nghiệp của một người. Các chủ đề được sắp xếp thành 6 phần:1. Khởi động: xây dựng mạng lưới các mối quan hệ, tìm kiếm việc làm, viết sơ yếu lý lịch, ứng xử trong các cuộc phỏng vấn và bắt đầu công việc một cách suôn sẻ.2. Giao tiếp: bằng lời nói và bằng văn bản, trình bày vấn đề một cách thuyết phục và thuyết trình trực tiếp trước từng đối tượng.3. Cộng tác: giải quyết các xung đột và thách thức, tạo dựng lòng tin và thu hút sự chú ý của mọi người, xử lý các tình huống nan giải và ứng xử với các đồng nghiệp khó tính.4. Thương lượng: các kỹ năng đàm phán, thương lượng về một lời mời làm việc, yêu cầu tăng lương và nói “không” một cách thông minh.5. Mối quan hệ công việc với người quản lý: xây dựng mối quan hệ công việc với quản lý cấp trên, ứng xử với những người quản lý có cá tính, làm việc với các công ty tuyển dụng nhân sự và chuẩn bị cho bản đánh giá hiệu suất công việc.6. Tối ưu hóa thành công trong sự nghiệp: quản lý thời gian và ưu tiên công việc, cách xử lý trước những thay đổi trong công việc, tìm hiểu văn hóa doanh nghiệp nước ngoài và quản lý bản thân trong môi trường doanh nghiệp nước ngoài.', N'https://salt.tikicdn.com/cache/w444/ts/product/7e/a1/59/1ee347e4798c7e27f9473abc07c4c4e5.jpg', 1, 1, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (46, 1, N'Hòm thư số 110', 1, 1, CAST(127500.00 AS Decimal(18, 2)), 102, N'Ở độ tuổi 30, bận bịu trong nhịp sống thường ngày quen thuộc khiến Jin Sol lẳng lặng đem cất những rung động tình yêu xa xỉ vào góc sâu trái tim. Mục tiêu cô đề ra là “Đừng để lòng vướng bận”. Song lẽ dĩ nhiên, trời chẳng chiều lòng người, đợt cải tổ nhân sự định kỳ của đài phát thanh đã mang đến cho cô một cộng sự khó nhằn - một nhà sản xuất chương trình còn sáng tác cả thơ. Để đối phó với anh ta, dường như mọi sự phòng bị là không đủ, hoặc chỉ một cốc smoothie đã đủ…', N'https://salt.tikicdn.com/cache/w444/ts/product/d5/70/40/130ff9342df888366e478c18823d65e9.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (47, 1, N'Quy luật của tấm...', 2, 2, CAST(50000.00 AS Decimal(18, 2)), 98, N'“Hiện thực của cuộc đời chúng ta chính là tấm gương phản chiếu tâm hồn ta”.Quy luật của tấm gương là một cuốn sách dựa trên một câu chuyện có thật, đầy cảm động của bà mẹ Eiko 41 tuổi đã vượt qua những khó khăn trong mối quan hệ với các thành viên trong gia đình, từ đó mở được nút thắt trong việc bày tỏ lòng tin, sự biết ơn và tình yêu để tìm được hạnh phúc cho bản thân và mọi người.Từ câu chuyện của Eiko tác giả muốn gửi gắm tới độc giả một thông điệp rằng “Cuộc đời chính là tấm gương phản chiếu tâm hồn của mỗi người. Hay nói cách khác, mỗi sự việc xảy ra trong cuộc sống của mỗi người đều đồng điệu với suy nghĩ trong tâm hồn họ”. Chính vì cuộc đời phản chiếu suy nghĩ trong tâm hồn, nên mỗi người khi gặp một vấn đề nào đó cần nhìn nhận lại chính bản thân mình, thay đổi bản thân để có thể thay đổi hoàn cảnh.', N'https://salt.tikicdn.com/cache/w444/ts/product/2c/dc/21/63ae92b8087d32daa6bb29d240effb28.jpg', 1, 2, 3)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (48, 1, N'Hai số phận', 1, 1, CAST(148500.00 AS Decimal(18, 2)), 93, N'Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là "thánh kinh" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.', N'https://salt.tikicdn.com/cache/w444/ts/product/0a/fb/51/202015881b04b7c8a4b47d15cf9c049f.jpg', 1, 1, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (49, 1, N'Đêm giáng sinh', 2, 1, CAST(41500.00 AS Decimal(18, 2)), 91, N'Cậu bé kể chuyện có một chú chó nhỏ màu nâu và một chiếc va li cũng màu nâu bí ẩn. Đi qua lớp tuyết dày đặc, cậu muốn chia sẻ một điều vô cùng quan trọng với người bạn đồng hành luôn sẵn lòng đợi mình trên đỉnh ngọn đồi cao cao. Cậu cứ thế leo lên, leo lên mãi rồi cũng tới được đỉnh đồi. Ở đó, cậu đã mở chiếc va li bí ẩn ra và tách tách… âm thanh duy nhất lúc này là giọng đọc từng trang trong cuốn sách yêu thích của cậu. ', N'https://salt.tikicdn.com/cache/w444/ts/product/cd/fa/62/7ff731839450e0fe519ecc8a99c454a2.jpg', 1, 2, 1)
INSERT [dbo].[TapHopSach] ([idSach], [lanTaiBan], [ten], [idNhaXuatBan], [maLoai], [giaBan], [soLuong], [moTa], [hinhAnh], [trangThai], [nhaXuatBanidNhaXuatBan], [loaiSachidLoai]) VALUES (50, 1, N'Việt Nam sử lược', 1, 3, CAST(331500.00 AS Decimal(18, 2)), 150, N'Đầu thế kỷ XX, giữa lúc nền học thuật nước nhà chỉ có các bộ đại tác như Đại Việt sử ký toàn thư hay Khâm định Việt sử thông giám cương mục là nguồn sử liệu chính thống nhưng chưa đáp ứng nhu cầu tìm hiểu lịch sử của phần đông dân chúng, thì Việt Nam sử lược, với tư cách là bộ thông sử chi tiết đầu tiên được viết bằng chữ quốc ngữ, đã xuất hiện và nhanh chóng thu hút sự quan tâm của độc giả lẫn giới nghiên cứu cả nước. Từ đó đến nay đã 100 năm trôi qua, tác phẩm vẫn giữ nguyên giá trị và là quyển sách vỡ lòng quen thuộc cho những ai bắt đầu tìm hiểu lịch sử Việt Nam.', N'https://salt.tikicdn.com/cache/w444/ts/product/b9/f1/24/e8e52fdef621360eabb91eb857996dda.jpg', 1, 1, 3)
GO
SET IDENTITY_INSERT [dbo].[TapHopTacGia] ON 

INSERT [dbo].[TapHopTacGia] ([idTacGia], [ten], [gioiTinh], [namSinh], [quocTich]) VALUES (1, N'Huỳnh Xuân Quỳnh', 1, CAST(N'1945-12-15T00:00:00.0000000' AS DateTime2), N'Việt Nam')
INSERT [dbo].[TapHopTacGia] ([idTacGia], [ten], [gioiTinh], [namSinh], [quocTich]) VALUES (2, N'Tố Hữu', 0, CAST(N'1960-12-16T00:00:00.0000000' AS DateTime2), N'Việt Nam')
INSERT [dbo].[TapHopTacGia] ([idTacGia], [ten], [gioiTinh], [namSinh], [quocTich]) VALUES (3, N'Văn Cao', 0, CAST(N'1970-12-10T00:00:00.0000000' AS DateTime2), N'Việt Nam')
SET IDENTITY_INSERT [dbo].[TapHopTacGia] OFF
GO
SET IDENTITY_INSERT [dbo].[TapHopTaiKhoanKhachHang] ON 

INSERT [dbo].[TapHopTaiKhoanKhachHang] ([idKhachHang], [tenKhachHang], [ngaySinh], [soDienThoai], [diaChi], [diemMuaHang], [taiKhoan], [matKhau], [trangThai], [gioiTinh]) VALUES (1, N'Nguyễn Hoàng Linh', CAST(N'1997-01-06T00:00:00.0000000' AS DateTime2), N'0969076447', N'212/58 Thoại Ngọc Hầu', 3, N'HoangLinh', N'A906449D5769FA7361D7ECC6AA3F6D28', 1, N'Nam')
INSERT [dbo].[TapHopTaiKhoanKhachHang] ([idKhachHang], [tenKhachHang], [ngaySinh], [soDienThoai], [diaChi], [diemMuaHang], [taiKhoan], [matKhau], [trangThai], [gioiTinh]) VALUES (2, N'Nguyễn Văn An', CAST(N'1991-11-11T00:00:00.0000000' AS DateTime2), N'0977407123', N'212/58 Thoại Ngọc Hầu', 0, N'vanan', N'A906449D5769FA7361D7ECC6AA3F6D28', 1, N'Nam')
SET IDENTITY_INSERT [dbo].[TapHopTaiKhoanKhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[TapHopTaiKhoanNhanVien] ON 

INSERT [dbo].[TapHopTaiKhoanNhanVien] ([idNhanVien], [tenNhanVien], [soDienThoai], [vaiTro], [matKhau], [trangThai]) VALUES (1, N'Hoàng Linh', N'0969076447', N'quản lý', N'202CB962AC59075B964B07152D234B70', 1)
INSERT [dbo].[TapHopTaiKhoanNhanVien] ([idNhanVien], [tenNhanVien], [soDienThoai], [vaiTro], [matKhau], [trangThai]) VALUES (2, N'Nguyễn Hoàng Phúc', N'0378898686', N'nhân viên', N'202CB962AC59075B964B07152D234B70', 1)
SET IDENTITY_INSERT [dbo].[TapHopTaiKhoanNhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[TapHopTrangThai] ON 

INSERT [dbo].[TapHopTrangThai] ([idTrangThai], [kieuTrangThai]) VALUES (1, N'Đang xử lý')
INSERT [dbo].[TapHopTrangThai] ([idTrangThai], [kieuTrangThai]) VALUES (2, N'Đã tiếp nhận')
INSERT [dbo].[TapHopTrangThai] ([idTrangThai], [kieuTrangThai]) VALUES (3, N'Chuyển giao hàng')
INSERT [dbo].[TapHopTrangThai] ([idTrangThai], [kieuTrangThai]) VALUES (4, N'Đã thanh toán')
INSERT [dbo].[TapHopTrangThai] ([idTrangThai], [kieuTrangThai]) VALUES (5, N'Hủy')
SET IDENTITY_INSERT [dbo].[TapHopTrangThai] OFF
GO
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (1, 1, 0, CAST(N'2020-12-26T21:30:21.2009786' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (1, 3, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (1, 4, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (2, 1, 0, CAST(N'2020-12-27T12:31:36.2749802' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (2, 2, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (2, 5, 0, CAST(N'2020-12-28T19:00:16.6422500' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (3, 1, 0, CAST(N'2020-12-27T13:04:53.0887427' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (4, 1, 0, CAST(N'2020-12-28T18:40:05.8150863' AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[TapHopTrangThaiDonHang] ([idDonHang], [idTrangThai], [idNhanVien], [thoiGian], [donHangidDonHang], [trangThaiidTrangThai], [taiKhoanNhanVienidNhanVien]) VALUES (4, 3, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
ALTER TABLE [dbo].[TapHopNhaXuatBan] ADD  DEFAULT (N'') FOR [ten]
GO
ALTER TABLE [dbo].[TapHopNhaXuatBan] ADD  DEFAULT (N'') FOR [soDienThoai]
GO
ALTER TABLE [dbo].[TapHopNhaXuatBan] ADD  DEFAULT (N'') FOR [diaChi]
GO
ALTER TABLE [dbo].[TapHopNhaXuatBan] ADD  DEFAULT (N'') FOR [email]
GO
ALTER TABLE [dbo].[TapHopNhaXuatBan] ADD  DEFAULT (N'') FOR [website]
GO
ALTER TABLE [dbo].[TapHopTacGia] ADD  DEFAULT (N'') FOR [ten]
GO
ALTER TABLE [dbo].[TapHopTacGia] ADD  DEFAULT ((0)) FOR [gioiTinh]
GO
ALTER TABLE [dbo].[TapHopTacGia] ADD  DEFAULT (N'') FOR [quocTich]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [tenKhachHang]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [soDienThoai]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [diaChi]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [taiKhoan]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [matKhau]
GO
ALTER TABLE [dbo].[TapHopTaiKhoanKhachHang] ADD  DEFAULT (N'') FOR [gioiTinh]
GO
ALTER TABLE [dbo].[TapHopChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietDonHang_TapHopDonHang_idDonHang] FOREIGN KEY([idDonHang])
REFERENCES [dbo].[TapHopDonHang] ([idDonHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TapHopChiTietDonHang] CHECK CONSTRAINT [FK_TapHopChiTietDonHang_TapHopDonHang_idDonHang]
GO
ALTER TABLE [dbo].[TapHopChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietDonHang_TapHopSach_sachidSach_sachlanTaiBan] FOREIGN KEY([sachidSach], [sachlanTaiBan])
REFERENCES [dbo].[TapHopSach] ([idSach], [lanTaiBan])
GO
ALTER TABLE [dbo].[TapHopChiTietDonHang] CHECK CONSTRAINT [FK_TapHopChiTietDonHang_TapHopSach_sachidSach_sachlanTaiBan]
GO
ALTER TABLE [dbo].[TapHopChiTietGiamGia]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietGiamGia_TapHopDonHang_idDonHang] FOREIGN KEY([idDonHang])
REFERENCES [dbo].[TapHopDonHang] ([idDonHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TapHopChiTietGiamGia] CHECK CONSTRAINT [FK_TapHopChiTietGiamGia_TapHopDonHang_idDonHang]
GO
ALTER TABLE [dbo].[TapHopChiTietGiamGia]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietGiamGia_TapHopGiamGia_idGiamGia] FOREIGN KEY([idGiamGia])
REFERENCES [dbo].[TapHopGiamGia] ([idGiamGia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TapHopChiTietGiamGia] CHECK CONSTRAINT [FK_TapHopChiTietGiamGia_TapHopGiamGia_idGiamGia]
GO
ALTER TABLE [dbo].[TapHopChiTietSach]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietSach_TapHopSach_sachidSach_sachlanTaiBan] FOREIGN KEY([sachidSach], [sachlanTaiBan])
REFERENCES [dbo].[TapHopSach] ([idSach], [lanTaiBan])
GO
ALTER TABLE [dbo].[TapHopChiTietSach] CHECK CONSTRAINT [FK_TapHopChiTietSach_TapHopSach_sachidSach_sachlanTaiBan]
GO
ALTER TABLE [dbo].[TapHopChiTietSach]  WITH CHECK ADD  CONSTRAINT [FK_TapHopChiTietSach_TapHopTacGia_idTacGia] FOREIGN KEY([idTacGia])
REFERENCES [dbo].[TapHopTacGia] ([idTacGia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TapHopChiTietSach] CHECK CONSTRAINT [FK_TapHopChiTietSach_TapHopTacGia_idTacGia]
GO
ALTER TABLE [dbo].[TapHopDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopDonHang_TapHopTaiKhoanKhachHang_taiKhoanKhachHangidKhachHang] FOREIGN KEY([taiKhoanKhachHangidKhachHang])
REFERENCES [dbo].[TapHopTaiKhoanKhachHang] ([idKhachHang])
GO
ALTER TABLE [dbo].[TapHopDonHang] CHECK CONSTRAINT [FK_TapHopDonHang_TapHopTaiKhoanKhachHang_taiKhoanKhachHangidKhachHang]
GO
ALTER TABLE [dbo].[TapHopSach]  WITH CHECK ADD  CONSTRAINT [FK_TapHopSach_TapHopLoaiSach_loaiSachidLoai] FOREIGN KEY([loaiSachidLoai])
REFERENCES [dbo].[TapHopLoaiSach] ([idLoai])
GO
ALTER TABLE [dbo].[TapHopSach] CHECK CONSTRAINT [FK_TapHopSach_TapHopLoaiSach_loaiSachidLoai]
GO
ALTER TABLE [dbo].[TapHopSach]  WITH CHECK ADD  CONSTRAINT [FK_TapHopSach_TapHopNhaXuatBan_nhaXuatBanidNhaXuatBan] FOREIGN KEY([nhaXuatBanidNhaXuatBan])
REFERENCES [dbo].[TapHopNhaXuatBan] ([idNhaXuatBan])
GO
ALTER TABLE [dbo].[TapHopSach] CHECK CONSTRAINT [FK_TapHopSach_TapHopNhaXuatBan_nhaXuatBanidNhaXuatBan]
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopDonHang_donHangidDonHang] FOREIGN KEY([donHangidDonHang])
REFERENCES [dbo].[TapHopDonHang] ([idDonHang])
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang] CHECK CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopDonHang_donHangidDonHang]
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopTaiKhoanNhanVien_taiKhoanNhanVienidNhanVien] FOREIGN KEY([taiKhoanNhanVienidNhanVien])
REFERENCES [dbo].[TapHopTaiKhoanNhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang] CHECK CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopTaiKhoanNhanVien_taiKhoanNhanVienidNhanVien]
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang]  WITH CHECK ADD  CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopTrangThai_trangThaiidTrangThai] FOREIGN KEY([trangThaiidTrangThai])
REFERENCES [dbo].[TapHopTrangThai] ([idTrangThai])
GO
ALTER TABLE [dbo].[TapHopTrangThaiDonHang] CHECK CONSTRAINT [FK_TapHopTrangThaiDonHang_TapHopTrangThai_trangThaiidTrangThai]
GO
