USE [master]
GO
/****** Object:  Database [sozluk]    Script Date: 22.05.2019 01:47:02 ******/
CREATE DATABASE [sozluk]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sozluk', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\sozluk.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sozluk_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\sozluk_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sozluk] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sozluk].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sozluk] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sozluk] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sozluk] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sozluk] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sozluk] SET ARITHABORT OFF 
GO
ALTER DATABASE [sozluk] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sozluk] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [sozluk] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sozluk] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sozluk] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sozluk] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sozluk] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sozluk] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sozluk] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sozluk] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sozluk] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sozluk] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sozluk] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sozluk] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sozluk] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sozluk] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sozluk] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sozluk] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sozluk] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sozluk] SET  MULTI_USER 
GO
ALTER DATABASE [sozluk] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sozluk] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sozluk] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sozluk] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [sozluk]
GO
/****** Object:  Table [dbo].[Kelime]    Script Date: 22.05.2019 01:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kelime](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tKelime] [nvarchar](50) NULL,
	[iKelime] [nvarchar](50) NULL,
	[OrnekCumle] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 22.05.2019 01:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[YetkiTuru] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OgrenilenKelime]    Script Date: 22.05.2019 01:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenilenKelime](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OgrenilenId] [int] NULL,
	[OgrenenId] [int] NULL,
	[Tarih] [nvarchar](50) NULL,
	[Seviye] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Kelime] ON 

INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (1, N'gözat', N'spotted', N'She was wearing a black and white spotted dress.')
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (2, N'sonra', N'after', NULL)
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (3, N'hakkında', N'
about', N'and she needs to know about it.')
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (4, N'öğleden sonra
', N'afternoon', N'I''m gonna spend the afternoon with Grandma.')
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (5, N've', N'and', N'and I have been crying
like a little girl')
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (6, N'akşam', N'evening', N'And how was your evening?')
INSERT [dbo].[Kelime] ([id], [tKelime], [iKelime], [OrnekCumle]) VALUES (7, N'bilgisayar', N'computer', N'i have a computer')
SET IDENTITY_INSERT [dbo].[Kelime] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([id], [Isim], [Sifre], [YetkiTuru]) VALUES (1, N'serdar', N'123', 1)
INSERT [dbo].[Kullanici] ([id], [Isim], [Sifre], [YetkiTuru]) VALUES (2, N'furkan', N'123', 2)
INSERT [dbo].[Kullanici] ([id], [Isim], [Sifre], [YetkiTuru]) VALUES (3, N'serdar2', N'123', 1)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[OgrenilenKelime] ON 

INSERT [dbo].[OgrenilenKelime] ([id], [OgrenilenId], [OgrenenId], [Tarih], [Seviye]) VALUES (1, 1, 1, N'21.05.2019', 2)
INSERT [dbo].[OgrenilenKelime] ([id], [OgrenilenId], [OgrenenId], [Tarih], [Seviye]) VALUES (2, 4, 1, N'22.05.2019 01:43:50', 1)
SET IDENTITY_INSERT [dbo].[OgrenilenKelime] OFF
USE [master]
GO
ALTER DATABASE [sozluk] SET  READ_WRITE 
GO
