USE [master]
GO
/****** Object:  Database [chvlxdDataBase]    Script Date: 12/28/2022 3:58:06 PM ******/
CREATE DATABASE [chvlxdDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'chvlxdDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\chvlxdDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'chvlxdDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\chvlxdDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [chvlxdDataBase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chvlxdDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chvlxdDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chvlxdDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chvlxdDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chvlxdDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chvlxdDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [chvlxdDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [chvlxdDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chvlxdDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chvlxdDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chvlxdDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [chvlxdDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [chvlxdDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [chvlxdDataBase] SET QUERY_STORE = OFF
GO
USE [chvlxdDataBase]
GO
/****** Object:  Table [dbo].[CTBCC]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTBCC](
	[MaNV] [varchar](50) NULL,
	[TenNV] [varchar](50) NULL,
	[MaBCC] [varchar](50) NULL,
	[NgayCC] [varchar](50) NOT NULL,
	[GioVao] [varchar](50) NULL,
	[GioRa] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [varchar](50) NULL,
	[MaSP] [varchar](50) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MaPN] [varchar](50) NULL,
	[MaSP] [varchar](50) NULL,
	[MaNCC] [varchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaSP] [varchar](50) NOT NULL,
	[Daban] [int] NULL,
	[Danhap] [int] NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLBCC]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLBCC](
	[MaBCC] [varchar](50) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NULL,
 CONSTRAINT [PK_QLBCC_1] PRIMARY KEY CLUSTERED 
(
	[MaBCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLCV]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLCV](
	[MaCV] [varchar](50) NOT NULL,
	[TenCV] [varchar](50) NULL,
	[HSL] [float] NULL,
 CONSTRAINT [PK_QLCV] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLHD]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLHD](
	[MaHD] [varchar](50) NOT NULL,
	[MaKH] [varchar](50) NULL,
	[NgayLap] [varchar](50) NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_QLHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLKH]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLKH](
	[MaKH] [varchar](50) NOT NULL,
	[TenKH] [varchar](50) NULL,
	[GT] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[DC] [varchar](50) NOT NULL,
 CONSTRAINT [PK_QLKH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLLoaiSP]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLLoaiSP](
	[MaLSP] [varchar](50) NOT NULL,
	[TenLSP] [varchar](50) NULL,
 CONSTRAINT [PK_QLLoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLNCC]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNCC](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [varchar](50) NULL,
	[DiaChi] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
 CONSTRAINT [PK_QLNCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLNV]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNV](
	[MaNV] [varchar](50) NOT NULL,
	[TenNV] [varchar](50) NULL,
	[GT] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[MaCV] [varchar](50) NULL,
 CONSTRAINT [PK_QLNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLPN]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLPN](
	[MaPN] [varchar](50) NOT NULL,
	[NgayNhap] [varchar](50) NULL,
	[MaNV] [varchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_QLPN] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLSP]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLSP](
	[MaSP] [varchar](50) NOT NULL,
	[TenSP] [varchar](50) NULL,
	[MaLSP] [varchar](50) NULL,
	[MaNCC] [varchar](50) NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_QLSP] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLTK]    Script Date: 12/28/2022 3:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLTK](
	[TK] [varchar](50) NOT NULL,
	[MK] [varchar](50) NULL,
	[VT] [int] NULL,
	[MaNV] [varchar](50) NULL,
 CONSTRAINT [PK_QLTK] PRIMARY KEY CLUSTERED 
(
	[TK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B02', N'23/10/2022', N'15:24.19', N'15:24.34')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV02', N'kk', N'B02', N'20/10/2022', N'21:12.46', N'21:13.22')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B02', N'27/10/2022', N'16:31.19', N'16:31.37')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B06', N'27/5/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B06', N'23/5/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B06', N'29/5/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B07', N'27/4/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B07', N'22/4/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B07', N'21/4/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B07', N'16/4/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B08', N'27/3/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B08', N'23/3/2022', N'19:22.53', N'20:57.42')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B011', N'11/11/2022', N'8:2.34', N'8:2.37')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV02', N'khai', N'B011', N'11/11/2022', N'8:22.12', N'8:22.17')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B011', N'16/11/2022', N'0:32.16', N'0:32.22')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV01', N'Khanh', N'B01', N'20/9/2022', N'22:21.50', N'22:21.56')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV02', N'kk', N'B02', N'27/10/2022', N'19:47.36', N'19:47.38')
INSERT [dbo].[CTBCC] ([MaNV], [TenNV], [MaBCC], [NgayCC], [GioVao], [GioRa]) VALUES (N'NV03', N'nhan vien 3', N'B02', N'27/10/2022', N'19:55.47', N'19:55.52')
GO
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD1', N'SP01', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD1', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD2', N'SP01', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD2', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD3', N'SP01', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD3', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD4', N'SP06', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD4', N'SP03', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD4', N'SP08', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD6', N'SP04', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD6', N'SP02', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD6', N'SP08', 9)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD7', N'SP03', 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD6', N'SP07', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD7', N'SP06', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD7', N'SP05', 8)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD10', N'SP14', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD10', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD10', N'SP15', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD10', N'SP05', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD11', N'SP16', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD11', N'SP20', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD11', N'SP18', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD11', N'SP06', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD11', N'SP03', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD12', N'SP18', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD12', N'SP17', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD12', N'SP20', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD12', N'SP14', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD13', N'SP19', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD4', N'SP09', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP03', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP07', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP12', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP11', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP10', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD5', N'SP04', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD7', N'SP12', 12)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD6', N'SP03', 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD8', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD8', N'SP11', 15)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD8', N'SP07', 3)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD8', N'SP04', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD9', N'SP02', 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD9', N'SP08', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD9', N'SP11', 20)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD9', N'SP09', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD10', N'SP13', 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD13', N'SP13', 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD13', N'SP15', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD13', N'SP18', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD13', N'SP07', 8)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD14', N'SP17', 5)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD14', N'SP16', 4)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD14', N'SP13', 6)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong]) VALUES (N'HD15', N'SP12', 4)
GO
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN01', N'SP01', N'NCC01', 11, 950000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN01', N'SP02', N'NCC02', 16, 900000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN02', N'SP01', N'NCC01', 20, 950000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN03', N'SP19', N'NCC04', 200, 11000000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN03', N'SP14', N'NCC05', 50, 7500000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN03', N'SP09', N'NCC06', 40, 200000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN02', N'SP17', N'NCC04', 10, 450000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN02', N'SP13', N'NCC12', 6, 690000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN02', N'SP03', N'NCC01', 2, 180000)
INSERT [dbo].[CTPN] ([MaPN], [MaSP], [MaNCC], [SoLuong], [DonGia]) VALUES (N'PN03', N'SP01', N'NCC01', 20, 1900000)
GO
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B01', 9, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B011', 11, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B02', 10, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B03', 8, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B04', 7, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B05', 6, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B06', 5, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B07', 4, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B08', 3, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B09', 2, 2022)
INSERT [dbo].[QLBCC] ([MaBCC], [Thang], [Nam]) VALUES (N'B10', 1, 2022)
GO
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV01', N'Chu tich', 9)
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV02', N'Pho chu tich', 8)
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV03', N'Truong phong', 7)
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV04', N'Pho phong', 6)
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV05', N'Nhan vien', 5)
INSERT [dbo].[QLCV] ([MaCV], [TenCV], [HSL]) VALUES (N'CV06', N'Tho ho', 4)
GO
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD1', N'KH01', N'1/11/2022', 380000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD10', N'KH08', N'10/11/2022', 1290000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD11', N'KH09', N'10/11/2022', 1190000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD12', N'KH10', N'10/11/2022', 1020000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD13', N'KH11', N'10/11/2022', 1450000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD14', N'KH12', N'10/11/2022', 1785000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD15', N'KH10', N'16/11/2022', 140000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD16', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD17', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD18', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD19', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD2', N'KH01', N'2/11/2022', 465000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD20', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD21', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD22', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD23', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD24', NULL, NULL, NULL)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD3', N'KH01', N'2/11/2022', 465000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD4', N'KH02', N'10/11/2022', 780000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD5', N'KH03', N'10/11/2022', 1598000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD6', N'KH04', N'10/11/2022', 1400000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD7', N'KH05', N'10/11/2022', 1470000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD8', N'KH06', N'10/11/2022', 1425000)
INSERT [dbo].[QLHD] ([MaHD], [MaKH], [NgayLap], [ThanhTien]) VALUES (N'HD9', N'KH07', N'10/11/2022', 1390000)
GO
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH01', N' anh', N'nam', N'1', N'ha noi')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH02', N'vu duc dam', N'nam', N'352', N'ha noi')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH03', N'nguyen phu trong', N'nam', N'786', N'ha noi')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH04', N' kim ngan', N'nu', N'742', N'da nang')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH05', N'xyz ', N'nam', N'247', N'ha noi')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH06', N'jack ma', N'nam', N'790', N'hai phong')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH07', N'lee min ho', N'nam', N'578', N'dong nai')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH08', N'ton ngo khong', N'nam', N'563', N'Tp.HCM')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH09', N'putin', N'nam', N'234', N'ha giang')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH10', N'son tung mtp', N'nam', N'683', N'thai binh')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH11', N'thuy tien', N'nu', N'795', N'sai gon')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH12', N'le quyen', N'nu', N'478', N'ca mau')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH13', N'obama', N'nam', N'787', N'ha noi')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH14', N'doan chi binh', N'nam', N'674', N'quang ninh')
INSERT [dbo].[QLKH] ([MaKH], [TenKH], [GT], [SDT], [DC]) VALUES (N'KH15', N'cu trong xoay', N'nam', N'342', N'ha noi')
GO
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'BT', N'be tong')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'CT', N'cot lieu xay dung')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'DC', N'dung cu xay dung')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'DD', N'day dien')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'GD', N'gach, da op lat')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'GX', N'gach xay')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'KXD', N'kinh xay dung')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'ON', N'ong nhua')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'OTN', N'ong cap thoat nuoc')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'SON', N'son tuong')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'TB', N'thiet bi thi cong')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'TH', N'thep')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'VLX', N'vat lieu xay')
INSERT [dbo].[QLLoaiSP] ([MaLSP], [TenLSP]) VALUES (N'XM', N'xi mang')
GO
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC01', N'Hoa binh', N'ha noi', N'11')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC02', N'Phuc an', N'ha noi', N'22')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC03', N'Adal Home', N'Tp.HCM', N'33')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC04', N'Thien Tan', N'ha noi', N'44')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC05', N'Song phuong', N'ha noi', N'55')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC06', N'NewLand', N'ha noi', N'66')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC07', N'Vina Built', N'Tp.HCM', N'77')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC08', N'Dat hoang anh', N'vung tau', N'73')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC09', N'An nhien phat', N'Tp.HCM', N'52')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC10', N'Cam uyen', N'Quang ngai', N'72')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC11', N'Manh dung', N'Thai nguyen', N'85')
INSERT [dbo].[QLNCC] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC12', N'Nha xanh', N'Binh duong', N'96')
GO
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV01', N'anh', N'Nam', N'113', N'CV01')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV02', N'khai', N'nam', N'112', N'CV04')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV03', N'huy', N'nam', N'111', N'CV05')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV04', N'ngoc anh', N'nu', N'341', N'CV02')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV05', N'duc anh', N'nam', N'342', N'CV06')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV06', N'nhan vien 6', N'nu', N'343', N'CV03')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV07', N'nhan vien 7', N'nu', N'344', N'CV05')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV08', N'nhan vien 8', N'nam', N'451', N'CV05')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV09', N'nhan vien 9', N'nam', N'455', N'CV06')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV10', N'nhan vien 10', N'nam', N'929', N'CV03')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV11', N'nhan vien 11', N'nam', N'453', N'CV03')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV12', N'nhan vien 12', N'nu', N'457', N'CV04')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV13', N'nhan vien 13', N'nam', N'458', N'CV06')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV14', N'nhan vien 14', N'nam', N'459', N'CV06')
INSERT [dbo].[QLNV] ([MaNV], [TenNV], [GT], [SDT], [MaCV]) VALUES (N'NV15', N'nhan vien 15', N'nam', N'68', N'CV06')
GO
INSERT [dbo].[QLPN] ([MaPN], [NgayNhap], [MaNV], [TongTien]) VALUES (N'PN01', N'7/11/2022', N'NV01', 2485000)
INSERT [dbo].[QLPN] ([MaPN], [NgayNhap], [MaNV], [TongTien]) VALUES (N'PN02', N'8/11/2022', N'NV06', 3910000)
INSERT [dbo].[QLPN] ([MaPN], [NgayNhap], [MaNV], [TongTien]) VALUES (N'PN03', N'10/11/2022', N'NV07', 22400000)
GO
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP01', N'xi mang chinfon', N'XM', N'NCC01', 95000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP02', N'xi mang pa', N'XM', N'NCC02', 90000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP03', N'da op lat binh dien', N'GD', N'NCC06', 90000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP04', N'thep pomina', N'TH', N'NCC03', 70000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP05', N'thep viet-nhat', N'TH', N'NCC07', 80000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP06', N'gach xay tuynel', N'GX', N'NCC04', 80000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP07', N'gach xay dong tam', N'GX', N'NCC05', 85000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP08', N'day dien cadivi', N'DD', N'NCC09', 30000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP09', N'ong thoat nuoc binh minh', N'OTN', N'NCC11', 50000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP10', N'ong D27', N'OTN', N'NCC10', 40000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP11', N'ong D168', N'OTN', N'NCC10', 38000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP12', N'ong D42', N'OTN', N'NCC10', 35000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP13', N'dan giao', N'TB', N'NCC12', 230000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP14', N'coppha sat', N'TB', N'NCC12', 150000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP15', N'son jontun', N'SON', N'NCC12', 40000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP16', N'son dulux', N'SON', N'NCC12', 45000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP17', N'ong nhua tien phong', N'ON', N'NCC08', 45000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP18', N'ong nhua pvc', N'ON', N'NCC08', 30000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP19', N'kinh van hoa', N'KXD', N'NCC05', 55000)
INSERT [dbo].[QLSP] ([MaSP], [TenSP], [MaLSP], [MaNCC], [Gia]) VALUES (N'SP20', N'kinh van bong', N'KXD', N'NCC05', 60000)
GO
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'1', N'1234567', 1, N'NV15')
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'ad', N'1233210', 0, N'NV01')
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'ad1', N'1234567', 0, N'NV13')
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'admin', N'123', 1, N'NV01')
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'nv1', N'1', 0, N'NV09')
INSERT [dbo].[QLTK] ([TK], [MK], [VT], [MaNV]) VALUES (N'nv2', N'1', 0, N'NV02')
GO
ALTER TABLE [dbo].[CTBCC]  WITH CHECK ADD  CONSTRAINT [FK_CTBCC_QLBCC] FOREIGN KEY([MaBCC])
REFERENCES [dbo].[QLBCC] ([MaBCC])
GO
ALTER TABLE [dbo].[CTBCC] CHECK CONSTRAINT [FK_CTBCC_QLBCC]
GO
ALTER TABLE [dbo].[CTBCC]  WITH CHECK ADD  CONSTRAINT [FK_CTBCC_QLNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[QLNV] ([MaNV])
GO
ALTER TABLE [dbo].[CTBCC] CHECK CONSTRAINT [FK_CTBCC_QLNV]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_QLHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[QLHD] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_QLHD]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_QLSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[QLSP] ([MaSP])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_QLSP]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_QLNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[QLNCC] ([MaNCC])
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_QLNCC]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_QLPN] FOREIGN KEY([MaPN])
REFERENCES [dbo].[QLPN] ([MaPN])
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_QLPN]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_QLSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[QLSP] ([MaSP])
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_QLSP]
GO
ALTER TABLE [dbo].[QLHD]  WITH CHECK ADD  CONSTRAINT [FK_QLHD_QLKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[QLKH] ([MaKH])
GO
ALTER TABLE [dbo].[QLHD] CHECK CONSTRAINT [FK_QLHD_QLKH]
GO
ALTER TABLE [dbo].[QLNV]  WITH CHECK ADD  CONSTRAINT [FK_QLNV_QLCV] FOREIGN KEY([MaCV])
REFERENCES [dbo].[QLCV] ([MaCV])
GO
ALTER TABLE [dbo].[QLNV] CHECK CONSTRAINT [FK_QLNV_QLCV]
GO
ALTER TABLE [dbo].[QLPN]  WITH CHECK ADD  CONSTRAINT [FK_QLPN_QLNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[QLNV] ([MaNV])
GO
ALTER TABLE [dbo].[QLPN] CHECK CONSTRAINT [FK_QLPN_QLNV]
GO
ALTER TABLE [dbo].[QLSP]  WITH CHECK ADD  CONSTRAINT [FK_QLSP_QLLoaiSP] FOREIGN KEY([MaLSP])
REFERENCES [dbo].[QLLoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[QLSP] CHECK CONSTRAINT [FK_QLSP_QLLoaiSP]
GO
ALTER TABLE [dbo].[QLSP]  WITH CHECK ADD  CONSTRAINT [FK_QLSP_QLNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[QLNCC] ([MaNCC])
GO
ALTER TABLE [dbo].[QLSP] CHECK CONSTRAINT [FK_QLSP_QLNCC]
GO
ALTER TABLE [dbo].[QLTK]  WITH CHECK ADD  CONSTRAINT [FK_QLTK_QLNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[QLNV] ([MaNV])
GO
ALTER TABLE [dbo].[QLTK] CHECK CONSTRAINT [FK_QLTK_QLNV]
GO
USE [master]
GO
ALTER DATABASE [chvlxdDataBase] SET  READ_WRITE 
GO
