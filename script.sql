create database [QLTV_Mixture]
go

USE [master]
GO
/****** Object:  Database [QLTV_Mixture]    Script Date: 4/28/2022 6:02:11 PM ******/
CREATE DATABASE [QLTV_Mixture]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV_Mixture', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV_Mixture.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTV_Mixture_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV_Mixture_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTV_Mixture] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV_Mixture].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV_Mixture] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV_Mixture] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV_Mixture] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV_Mixture] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV_Mixture] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV_Mixture] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV_Mixture] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV_Mixture] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV_Mixture] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV_Mixture] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV_Mixture] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV_Mixture', N'ON'
GO
ALTER DATABASE [QLTV_Mixture] SET QUERY_STORE = OFF
GO
USE [QLTV_Mixture]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[Type] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bo_Au]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bo_Au](
	[ID_Book] [nvarchar](50) NOT NULL,
	[ID_Author] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bo_Au] PRIMARY KEY CLUSTERED 
(
	[ID_Book] ASC,
	[ID_Author] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bo_Cate]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bo_Cate](
	[ID_Book] [nvarchar](50) NOT NULL,
	[ID_Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bo_Cate] PRIMARY KEY CLUSTERED 
(
	[ID_Book] ASC,
	[ID_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Amount] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[IDLibrian] [nvarchar](50) NOT NULL,
	[ID_Pub] [nvarchar](50) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Call_Card]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Call_Card](
	[ID] [nvarchar](50) NOT NULL,
	[ID_Library] [nvarchar](50) NULL,
	[ID_Student] [nvarchar](50) NULL,
	[Borrowing_Periods] [datetime] NULL,
	[Return_Date] [datetime] NULL,
	[Renewals] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Call_Card] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CCard_Detail]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CCard_Detail](
	[ID_Book] [nvarchar](50) NOT NULL,
	[ID_CCard] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CCard_Detail] PRIMARY KEY CLUSTERED 
(
	[ID_Book] ASC,
	[ID_CCard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librian]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librian](
	[ID] [nvarchar](50) NOT NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_Librian] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Penalty]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Penalty](
	[ID] [nvarchar](50) NOT NULL,
	[ID_Library] [nvarchar](50) NULL,
	[ID_Student] [nvarchar](50) NULL,
	[Overdue_fines] [int] NULL,
	[NumOfDay_Overdue] [int] NULL,
	[Date_Start] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishing]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishing](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Publishing] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/28/2022 6:02:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [nvarchar](50) NOT NULL,
	[Mail] [varchar](50) NULL,
	[ID_Librian] [nvarchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'admin', N'150231146241509418344146165732219051118', 1, N'Thụy Anh', N'0123456789')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'anhkhoa@gmail.com', N'150231146241509418344146165732219051118', 0, N'Anh Khoa', N'0463496346')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'badung@gmail.com', N'150231146241509418344146165732219051118', 0, N'Bá Dũng', N'0462349866')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'baoan@gmail.com', N'150231146241509418344146165732219051118', 0, N'Bảo An', N'0123512543')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'baohan@gmail.com', N'150231146241509418344146165732219051118', 0, N'Bảo Hân', N'0693485674')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'hoangkhang@gmail.com', N'150231146241509418344146165732219051118', 0, N'Hoàng Khang', N'0345986345')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'hoangluan@gmail.com', N'150231146241509418344146165732219051118', 0, N'Hoàng Luận', N'0345693566')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'minhchau@gmail.com', N'150231146241509418344146165732219051118', 0, N'Minh Châu', N'0234698276')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'minhkhanh@gmail.com', N'150231146241509418344146165732219051118', 0, N'Minh Khang', N'0934856313')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'nhathuy@gmail.com', N'150231146241509418344146165732219051118', 0, N'Nhất Huy', N'0349586345')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'nhathuy123@gmail.com', N'150231146241509418344146165732219051118', 0, N'Nhật Huy', N'0239486234')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'quocbao@gmail.com', N'150231146241509418344146165732219051118', 0, N'Quốc Bảo', N'0684576323')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'quocdat@gmail.com', N'150231146241509418344146165732219051118', 0, N'Quốc Đạt', N'0543987623')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'student', N'150231146241509418344146165732219051118', 0, N'Chí Dinh', N'0234567891')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'thaihien@gmail.com', N'150231146241509418344146165732219051118', 0, N'Thái Hiền ', N'0234875689')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'thehoang@gmail.com', N'150231146241509418344146165732219051118', 0, N'Thế Hoàng', N'0345968334')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'thuylinh@gmail.com', N'150231146241509418344146165732219051118', 0, N'Thùy Linh', N'0234523455')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'trongduc@gmail.com', N'150231146241509418344146165732219051118', 0, N'Trọng Đức', N'0634875612')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'tuankiet@gmail.com', N'150231146241509418344146165732219051118', 0, N'Tuấn Kiệt', N'0469346455')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'vancuong@gmail.com', N'150231146241509418344146165732219051118', 0, N'Văn Cường', N'0348562734')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'xuanduyen@gmail.com', N'150231146241509418344146165732219051118', 0, N'Xuân Duyên', N'0453987676')
INSERT [dbo].[Account] ([Email], [Password], [Type], [Name], [Phone]) VALUES (N'yennhi@gmail.com', N'150231146241509418344146165732219051118', 0, N'Yến Nhi', N'0943587234')
GO
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU001', N'Nguyễn Nhật Ánh')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU002', N'Dan Brown')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU003', N'Reki Kawahara')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU004', N'Hector Malot')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU005', N'Hạ Vũ')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU006', N'Sir Arthur Conan Doyle')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU007', N'J.K. Rowling')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU008', N'Nguyễn Trường Thanh')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU009', N'Hans Christian Andersen')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU010', N'Fresh Quả Quả')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU011', N'Franklin Patrick Herbert')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU012', N'Fujiko Fujio')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU013', N'C.S.Lewis')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU014', N'Charles Dickens')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU015', N'Bộ giáo dục và đào tạo')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU016', N'Nguyễn Du')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU017', N'CHRISTINE HÀ')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU018', N'Ernest Hemingway')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU019', N'Hạ Vũ')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU020', N'J.R.R. Tolkien')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU021', N'Shinkai Makoto')
INSERT [dbo].[Author] ([ID], [Name]) VALUES (N'AU022', N'Yukito Ayatsuji')
GO
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO001', N'AU001')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO002', N'AU002')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO003', N'AU002')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO004', N'AU003')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO005', N'AU004')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO006', N'AU005')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO007', N'AU006')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO008', N'AU007')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO009', N'AU008')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO010', N'AU009')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO011', N'AU010')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO012', N'AU011')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO013', N'AU012')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO014', N'AU012')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO015', N'AU013')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO016', N'AU014')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO017', N'AU003')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO018', N'AU015')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO019', N'AU015')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO020', N'AU016')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO021', N'AU017')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO022', N'AU018')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO023', N'AU005')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO024', N'AU020')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO025', N'AU020')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO026', N'AU020')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO027', N'AU020')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO028', N'AU021')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO029', N'AU022')
INSERT [dbo].[Bo_Au] ([ID_Book], [ID_Author]) VALUES (N'BO030', N'AU012')
GO
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO001', N'CA001')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO001', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO001', N'CA003')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO002', N'CA003')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO002', N'CA004')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO002', N'CA005')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO002', N'CA006')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO002', N'CA007')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO003', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO003', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO003', N'CA009')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO003', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO004', N'CA003')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO004', N'CA011')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO005', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO006', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO006', N'CA012')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO007', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO007', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO007', N'CA013')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO007', N'CA014')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO007', N'CA015')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO008', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO008', N'CA014')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO009', N'CA018')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO010', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO011', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO011', N'CA013')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO011', N'CA015')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO011', N'CA017')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO012', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO012', N'CA012')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO012', N'CA015')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO012', N'CA017')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO012', N'CA019')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO013', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO013', N'CA014')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO014', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO014', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO014', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO015', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO015', N'CA013')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO016', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO017', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO017', N'CA016')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO017', N'CA020')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO018', N'CA018')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO019', N'CA018')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO020', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO021', N'CA021')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO022', N'CA010')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO022', N'CA022')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO023', N'CA006')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO024', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO024', N'CA023')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO025', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO025', N'CA023')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO026', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO026', N'CA023')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO027', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO027', N'CA008')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO027', N'CA009')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO027', N'CA016')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO028', N'CA012')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO029', N'CA024')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO029', N'CA025')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO030', N'CA002')
INSERT [dbo].[Bo_Cate] ([ID_Book], [ID_Category]) VALUES (N'BO030', N'CA023')
GO
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO001', N'Kính Vạn Hoa - Trọn bộ', 2, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO002', N'Thiên thần và ác quỷ', 2, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO003', N'Pháo đài số 00', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO004', N'Sword Art Online: Aincrad - Tập 1', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO005', N'Không Gia Đình', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO006', N'Anh Chính Là Thanh Xuân Của Em', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO007', N'Sherlock Holmes - Trọn bộ', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO008', N'Harry Potter Combo', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO009', N'Giải Tích 1', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO010', N'Truyện cổ Andersen', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO011', N'Hoa Thiên Cốt - Trọn bộ', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO012', N'Xứ Cát', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO013', N'Doraemon: Chú khủng long của Nobita', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO014', N'Doraemon: Vương quốc trên mây', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO015', N'Narnia - Trọn bộ', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO016', N'Oliver Tiwst', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO017', N'Sword Art Online: Aincrad - Tập 2', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO018', N'Bộ sách giáo khoa lớp 9', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO019', N'Bộ vở bài tập lớp 9', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO020', N'Truyện Kiều', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO021', N'Nấu ăn bằng cả trái tim', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO022', N'Ông Già Và Biển Cả', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO023', N'Hôm Nay Tôi Thất Tình', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO024', N'Chúa tể những chiếc nhẫn: Đoàn hộ nhẫn', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO025', N'Chúa tể những chiếc nhẫn: Hai tòa tháp', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO026', N'Chúa tể những chiếc nhẫn: Nhà vua trở về', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO027', N'Anh Chàng Hobbit (Tái Bản 2014)', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO028', N'Khu Vườn Ngôn Từ', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO029', N'Another - Trọn bộ 2 tập', 1, 1, N'LB001', NULL)
INSERT [dbo].[Book] ([ID], [Name], [Amount], [Status], [IDLibrian], [ID_Pub]) VALUES (N'BO030', N'Doraemon: Nobita và chuyến phiêu lưu vào xứ quỷ', 1, 1, N'LB001', NULL)
GO
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC001', N'LB001', N'ST001', CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'2022-03-12T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC002', N'LB001', N'ST005', CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'2022-03-12T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC003', N'LB001', N'ST018', CAST(N'2022-03-12T00:00:00.000' AS DateTime), CAST(N'2022-03-19T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC004', N'LB001', N'ST011', CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'2022-03-25T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC005', N'LB001', N'ST016', CAST(N'2022-03-19T00:00:00.000' AS DateTime), CAST(N'2022-03-26T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC006', N'LB001', N'ST014', CAST(N'2022-03-22T00:00:00.000' AS DateTime), CAST(N'2022-04-04T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC007', N'LB001', N'ST013', CAST(N'2022-03-23T00:00:00.000' AS DateTime), CAST(N'2022-04-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC008', N'LB001', N'ST002', CAST(N'2022-04-28T00:00:00.000' AS DateTime), CAST(N'2022-05-12T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC009', N'LB001', N'ST003', CAST(N'2022-04-28T00:00:00.000' AS DateTime), CAST(N'2022-05-05T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Call_Card] ([ID], [ID_Library], [ID_Student], [Borrowing_Periods], [Return_Date], [Renewals], [Status]) VALUES (N'CC010', N'LB001', N'ST004', CAST(N'2022-04-28T00:00:00.000' AS DateTime), CAST(N'2022-05-05T00:00:00.000' AS DateTime), 0, 0)
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA001', N'Học trò')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA002', N'Thiếu Nhi')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA003', N'Sách văn học')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA004', N'Huyền huyễn')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA005', N'Tu tiên')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA006', N'Ngôn tình')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA007', N'Ngược')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA008', N'Kỳ ảo')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA009', N'Sử thi')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA010', N'Tiểu thuyết')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA011', N'Thơ')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA012', N'Lãng mạng')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA013', N'Trinh thám')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA014', N'Hư cấu')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA015', N'Giả tưởng')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA016', N'Huyền huyễn')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA017', N'Khoa học')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA018', N'Sách giáo khoa')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA019', N'Game')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA020', N'Xuyên không')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA021', N'Đời thường')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA022', N'Viễn tưởng')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA023', N'Truyện tranh')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA024', N'Kinh dị')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (N'CA025', N'Siêu năng lực')
GO
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO001', N'CC008')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO001', N'CC009')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO002', N'CC001')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO003', N'CC004')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO004', N'CC010')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO007', N'CC002')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO015', N'CC003')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO022', N'CC007')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO024', N'CC006')
INSERT [dbo].[CCard_Detail] ([ID_Book], [ID_CCard]) VALUES (N'BO028', N'CC005')
GO
INSERT [dbo].[Librian] ([ID], [Mail]) VALUES (N'LB001', N'admin')
GO
INSERT [dbo].[Penalty] ([ID], [ID_Library], [ID_Student], [Overdue_fines], [NumOfDay_Overdue], [Date_Start]) VALUES (N'PC002', N'LB001', N'ST001', 47000, 47, CAST(N'2022-04-28T00:00:00.000' AS DateTime))
INSERT [dbo].[Penalty] ([ID], [ID_Library], [ID_Student], [Overdue_fines], [NumOfDay_Overdue], [Date_Start]) VALUES (N'PC003', N'LB001', N'ST011', 34000, 34, CAST(N'2022-04-28T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB001', N'Văn học', N'20 Đ. Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Thành phố Hồ Chí Minh')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB002', N'Lao động', N'175 P. Giảng Võ, Chợ Dừa, Đống Đa, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB003', N'Hồng Đức', N'Số 65, phố Tràng Thi, Phường Hàng Bông, Quận Hoàn Kiếm, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB004', N'Phụ nữ', N'39 P. Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB005', N'Kim Đồng', N'55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB006', N'Hà Nội', N'4 P. Tống Duy Tân, Hàng Bông, Hoàn Kiếm, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB007', N'Hội Nhà Văn', N' 65, Nguyễn Du, quận Hai Bà Trưng, Hà Nội')
INSERT [dbo].[Publishing] ([ID], [Name], [Address]) VALUES (N'NXB008', N'Bộ giáo dục và đào tạo', N'Số 81 Trần Hưng Đạo, quận Hoàn Kiếm, thành phố Hà Nội')
GO
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST001', N'baoan@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST002', N'thuylinh@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST003', N'quocbao@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST004', N'minhchau@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST005', N'vancuong@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST006', N'quocdat@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST007', N'hoangluan@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST008', N'trongduc@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST009', N'badung@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST010', N'xuanduyen@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST011', N'baohan@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST012', N'thaihien@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST013', N'thehoang@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST014', N'yennhi@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST015', N'nhathuy@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST016', N'nhathuy123@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST017', N'hoangkhang@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST018', N'minhkhanh@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST019', N'anhkhoa@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST020', N'tuankiet@gmail.com', N'LB001')
INSERT [dbo].[Student] ([ID], [Mail], [ID_Librian]) VALUES (N'ST021', N'student', N'LB001')
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Amount]  DEFAULT ((1)) FOR [Amount]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Bo_Au]  WITH CHECK ADD  CONSTRAINT [FK_Bo_Au_Author] FOREIGN KEY([ID_Author])
REFERENCES [dbo].[Author] ([ID])
GO
ALTER TABLE [dbo].[Bo_Au] CHECK CONSTRAINT [FK_Bo_Au_Author]
GO
ALTER TABLE [dbo].[Bo_Au]  WITH CHECK ADD  CONSTRAINT [FK_Bo_Au_Book] FOREIGN KEY([ID_Book])
REFERENCES [dbo].[Book] ([ID])
GO
ALTER TABLE [dbo].[Bo_Au] CHECK CONSTRAINT [FK_Bo_Au_Book]
GO
ALTER TABLE [dbo].[Bo_Cate]  WITH CHECK ADD  CONSTRAINT [FK_Bo_Cate_Book] FOREIGN KEY([ID_Book])
REFERENCES [dbo].[Book] ([ID])
GO
ALTER TABLE [dbo].[Bo_Cate] CHECK CONSTRAINT [FK_Bo_Cate_Book]
GO
ALTER TABLE [dbo].[Bo_Cate]  WITH CHECK ADD  CONSTRAINT [FK_Bo_Cate_Category] FOREIGN KEY([ID_Category])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Bo_Cate] CHECK CONSTRAINT [FK_Bo_Cate_Category]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Pub] FOREIGN KEY([ID_Pub])
REFERENCES [dbo].[Publishing] ([ID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Pub]
GO
ALTER TABLE [dbo].[CCard_Detail]  WITH CHECK ADD  CONSTRAINT [FK_CCard_Detail_Book] FOREIGN KEY([ID_Book])
REFERENCES [dbo].[Book] ([ID])
GO
ALTER TABLE [dbo].[CCard_Detail] CHECK CONSTRAINT [FK_CCard_Detail_Book]
GO
ALTER TABLE [dbo].[CCard_Detail]  WITH CHECK ADD  CONSTRAINT [FK_CCard_Detail_Call_Card] FOREIGN KEY([ID_CCard])
REFERENCES [dbo].[Call_Card] ([ID])
GO
ALTER TABLE [dbo].[CCard_Detail] CHECK CONSTRAINT [FK_CCard_Detail_Call_Card]
GO
USE [master]
GO
ALTER DATABASE [QLTV_Mixture] SET  READ_WRITE 
GO
