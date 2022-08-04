USE [master]
GO
/****** Object:  Database [DATN]    Script Date: 7/19/2022 3:04:59 PM ******/
CREATE DATABASE [DATN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DATN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DATN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DATN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DATN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DATN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DATN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DATN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DATN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DATN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DATN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DATN] SET ARITHABORT OFF 
GO
ALTER DATABASE [DATN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DATN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DATN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DATN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DATN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DATN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DATN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DATN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DATN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DATN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DATN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DATN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DATN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DATN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DATN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DATN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DATN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DATN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DATN] SET  MULTI_USER 
GO
ALTER DATABASE [DATN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DATN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DATN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DATN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DATN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DATN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DATN] SET QUERY_STORE = OFF
GO
USE [DATN]
GO
/****** Object:  Table [dbo].[CVE]    Script Date: 7/19/2022 3:04:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CVE](
	[MaCVE] [nchar](20) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayPhatHien] [date] NULL,
	[MucDo] [nchar](20) NULL,
 CONSTRAINT [PK_CVE] PRIMARY KEY CLUSTERED 
(
	[MaCVE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAYTINH]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAYTINH](
	[MaMT] [int] IDENTITY(1,1) NOT NULL,
	[TenMT] [nchar](50) NULL,
	[MAC] [nchar](30) NULL,
	[IP] [nchar](15) NULL,
	[HDH] [nvarchar](max) NULL,
	[DaCapNhat] [bit] NULL,
 CONSTRAINT [PK_MAYTINH] PRIMARY KEY CLUSTERED 
(
	[MaMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MT_PM]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MT_PM](
	[MaMT] [int] NOT NULL,
	[MaPB] [int] NOT NULL,
	[LaHDH] [bit] NULL,
 CONSTRAINT [PK_MT_PM] PRIMARY KEY CLUSTERED 
(
	[MaMT] ASC,
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PB_CVE]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PB_CVE](
	[MaPB] [int] NOT NULL,
	[MaCVE] [nchar](20) NOT NULL,
 CONSTRAINT [PK_PB_CVE] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC,
	[MaCVE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANMEM]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANMEM](
	[MaPM] [int] IDENTITY(1,1) NOT NULL,
	[TenPhanMem] [nvarchar](max) NULL,
	[PhienBanMoiNhat] [nchar](50) NULL,
	[NhaPhatHanh] [nvarchar](50) NULL,
	[NgayPhatHanh] [date] NULL,
 CONSTRAINT [PK_PHANMEM] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIENBAN]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIENBAN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPM] [int] NULL,
	[TenPhienBan] [nchar](50) NULL,
	[NgayPhatHanh] [date] NULL,
 CONSTRAINT [PK_PHIENBAN] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 7/19/2022 3:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[id] [nchar](10) NOT NULL,
	[username] [nchar](20) NULL,
	[password] [nchar](10) NULL,
	[author] [nchar](10) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MT_PM]  WITH CHECK ADD  CONSTRAINT [FK_MT_PM_MAYTINH] FOREIGN KEY([MaMT])
REFERENCES [dbo].[MAYTINH] ([MaMT])
GO
ALTER TABLE [dbo].[MT_PM] CHECK CONSTRAINT [FK_MT_PM_MAYTINH]
GO
ALTER TABLE [dbo].[MT_PM]  WITH CHECK ADD  CONSTRAINT [FK_MT_PM_PHIENBAN] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHIENBAN] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MT_PM] CHECK CONSTRAINT [FK_MT_PM_PHIENBAN]
GO
ALTER TABLE [dbo].[PB_CVE]  WITH CHECK ADD  CONSTRAINT [FK_PB_CVE_CVE] FOREIGN KEY([MaCVE])
REFERENCES [dbo].[CVE] ([MaCVE])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PB_CVE] CHECK CONSTRAINT [FK_PB_CVE_CVE]
GO
ALTER TABLE [dbo].[PB_CVE]  WITH CHECK ADD  CONSTRAINT [FK_PB_CVE_PHIENBAN] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHIENBAN] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PB_CVE] CHECK CONSTRAINT [FK_PB_CVE_PHIENBAN]
GO
ALTER TABLE [dbo].[PHIENBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIENBAN_PHANMEM] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHANMEM] ([MaPM])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PHIENBAN] CHECK CONSTRAINT [FK_PHIENBAN_PHANMEM]
GO
USE [master]
GO
ALTER DATABASE [DATN] SET  READ_WRITE 
GO
