USE [master]
GO
/****** Object:  Database [Veteriner_MVCAPI_Projesi]    Script Date: 8.12.2022 14:39:25 ******/
CREATE DATABASE [Veteriner_MVCAPI_Projesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veteriner_MVCAPI_Projesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Veteriner_MVCAPI_Projesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veteriner_MVCAPI_Projesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Veteriner_MVCAPI_Projesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veteriner_MVCAPI_Projesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET  MULTI_USER 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET QUERY_STORE = OFF
GO
USE [Veteriner_MVCAPI_Projesi]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 8.12.2022 14:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[Uid1] [int] IDENTITY(1,1) NOT NULL,
	[Name1] [varchar](50) NULL,
	[UserId] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[isActive] [bit] NULL,
	[Role] [int] NULL,
	[Createdon] [datetime] NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[Uid1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veteriner_Calisan]    Script Date: 8.12.2022 14:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veteriner_Calisan](
	[CalisanNo] [int] IDENTITY(1,1) NOT NULL,
	[CalisanAdi] [varchar](50) NULL,
	[Yas] [int] NULL,
	[Telefon] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[SubeNo] [int] NULL,
 CONSTRAINT [PK_Veteriner_Calisan] PRIMARY KEY CLUSTERED 
(
	[CalisanNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veteriner_Hizmet]    Script Date: 8.12.2022 14:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veteriner_Hizmet](
	[HizmetNo] [int] IDENTITY(1,1) NOT NULL,
	[HizmetAdi] [varchar](50) NULL,
	[HizmetAmaci] [varchar](50) NULL,
	[Fiyat] [int] NULL,
	[CalisanNo] [int] NULL,
 CONSTRAINT [PK_Veteriner_Hizmet] PRIMARY KEY CLUSTERED 
(
	[HizmetNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veteriner_Sube]    Script Date: 8.12.2022 14:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veteriner_Sube](
	[SubeNo] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [varchar](50) NULL,
	[CalisanSayisi] [int] NULL,
	[HizmetSayisi] [int] NULL,
 CONSTRAINT [PK_Veteriner_Sube] PRIMARY KEY CLUSTERED 
(
	[SubeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veteriner_Urun]    Script Date: 8.12.2022 14:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veteriner_Urun](
	[UrunNo] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [varchar](50) NULL,
	[UrunFiyat] [int] NULL,
	[KullanimAmaci] [varchar](50) NULL,
	[HizmetNo] [int] NULL,
 CONSTRAINT [PK_Veteriner_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserMaster] ON 

INSERT [dbo].[UserMaster] ([Uid1], [Name1], [UserId], [Password], [isActive], [Role], [Createdon]) VALUES (1, N'Admin', N'Admin', N'12345', 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[UserMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[Veteriner_Calisan] ON 

INSERT [dbo].[Veteriner_Calisan] ([CalisanNo], [CalisanAdi], [Yas], [Telefon], [Mail], [SubeNo]) VALUES (1, N'Ali Lale', 30, N'5346781234', N'al@gmail.com', 1)
INSERT [dbo].[Veteriner_Calisan] ([CalisanNo], [CalisanAdi], [Yas], [Telefon], [Mail], [SubeNo]) VALUES (2, N'Pelin Kaymak', 30, N'5461224567', N'pk@gmail.com', 2)
INSERT [dbo].[Veteriner_Calisan] ([CalisanNo], [CalisanAdi], [Yas], [Telefon], [Mail], [SubeNo]) VALUES (8, N'a', 1, N'q', N'q', 1)
SET IDENTITY_INSERT [dbo].[Veteriner_Calisan] OFF
GO
SET IDENTITY_INSERT [dbo].[Veteriner_Hizmet] ON 

INSERT [dbo].[Veteriner_Hizmet] ([HizmetNo], [HizmetAdi], [HizmetAmaci], [Fiyat], [CalisanNo]) VALUES (1, N'Çip Taktırma', N'Kimlik', 50, 1)
INSERT [dbo].[Veteriner_Hizmet] ([HizmetNo], [HizmetAdi], [HizmetAmaci], [Fiyat], [CalisanNo]) VALUES (2, N'Kısırlaştırma', N'Doğum Kontrol', 200, 1)
SET IDENTITY_INSERT [dbo].[Veteriner_Hizmet] OFF
GO
SET IDENTITY_INSERT [dbo].[Veteriner_Sube] ON 

INSERT [dbo].[Veteriner_Sube] ([SubeNo], [SubeAdi], [CalisanSayisi], [HizmetSayisi]) VALUES (1, N'Kurtköy', 10, 20)
INSERT [dbo].[Veteriner_Sube] ([SubeNo], [SubeAdi], [CalisanSayisi], [HizmetSayisi]) VALUES (2, N'Yenişehir', 10, 20)
INSERT [dbo].[Veteriner_Sube] ([SubeNo], [SubeAdi], [CalisanSayisi], [HizmetSayisi]) VALUES (3, N'Üsküdar', 10, 15)
SET IDENTITY_INSERT [dbo].[Veteriner_Sube] OFF
GO
SET IDENTITY_INSERT [dbo].[Veteriner_Urun] ON 

INSERT [dbo].[Veteriner_Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimAmaci], [HizmetNo]) VALUES (1, N'Çip', 100, N'Kimlik', 1)
INSERT [dbo].[Veteriner_Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimAmaci], [HizmetNo]) VALUES (2, N'Neşter', 40, N'Kesmek', 2)
SET IDENTITY_INSERT [dbo].[Veteriner_Urun] OFF
GO
ALTER TABLE [dbo].[Veteriner_Calisan]  WITH CHECK ADD  CONSTRAINT [FK_Veteriner_Calisan_Veteriner_Sube] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[Veteriner_Sube] ([SubeNo])
GO
ALTER TABLE [dbo].[Veteriner_Calisan] CHECK CONSTRAINT [FK_Veteriner_Calisan_Veteriner_Sube]
GO
ALTER TABLE [dbo].[Veteriner_Hizmet]  WITH CHECK ADD  CONSTRAINT [FK_Veteriner_Hizmet_Veteriner_Calisan] FOREIGN KEY([CalisanNo])
REFERENCES [dbo].[Veteriner_Calisan] ([CalisanNo])
GO
ALTER TABLE [dbo].[Veteriner_Hizmet] CHECK CONSTRAINT [FK_Veteriner_Hizmet_Veteriner_Calisan]
GO
ALTER TABLE [dbo].[Veteriner_Urun]  WITH CHECK ADD  CONSTRAINT [FK_Veteriner_Urun_Veteriner_Hizmet] FOREIGN KEY([HizmetNo])
REFERENCES [dbo].[Veteriner_Hizmet] ([HizmetNo])
GO
ALTER TABLE [dbo].[Veteriner_Urun] CHECK CONSTRAINT [FK_Veteriner_Urun_Veteriner_Hizmet]
GO
USE [master]
GO
ALTER DATABASE [Veteriner_MVCAPI_Projesi] SET  READ_WRITE 
GO
