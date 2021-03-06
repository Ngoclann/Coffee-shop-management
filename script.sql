USE [master]
GO
/****** Object:  Database [CoffeeShopManagement]    Script Date: 11/19/2020 8:51:24 AM ******/
CREATE DATABASE [CoffeeShopManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShopManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CoffeeShopManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShopManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CoffeeShopManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CoffeeShopManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShopManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShopManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShopManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShopManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CoffeeShopManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShopManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [CoffeeShopManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShopManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShopManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShopManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShopManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShopManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CoffeeShopManagement', N'ON'
GO
ALTER DATABASE [CoffeeShopManagement] SET QUERY_STORE = OFF
GO
USE [CoffeeShopManagement]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryCode] [nvarchar](50) NOT NULL,
	[categoryName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerCode] [nvarchar](50) NOT NULL,
	[customerName] [nvarchar](50) NULL,
	[AddressName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[customerCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[materialCode] [nvarchar](50) NOT NULL,
	[materialName] [nvarchar](50) NULL,
	[price] [money] NULL,
	[providerCode] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[materialCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productCode] [nvarchar](50) NOT NULL,
	[productName] [nvarchar](50) NULL,
	[categoryCode] [nvarchar](50) NULL,
	[purchasePrice] [money] NULL,
	[sellPrice] [money] NULL,
	[quantity] [int] NULL,
	[image] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[productCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[providerCode] [nvarchar](50) NOT NULL,
	[providerName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[providerCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[purchaseCode] [nvarchar](50) NOT NULL,
	[materialCode] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[price] [money] NULL,
	[amount] [money] NULL,
	[discount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[purchaseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[code] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NULL,
	[staffCode] [nvarchar](50) NULL,
	[providerCode] [nvarchar](50) NULL,
	[amount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellDetail]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellDetail](
	[sellCode] [nvarchar](50) NOT NULL,
	[productCode] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[amount] [money] NULL,
	[discount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[sellCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellOrder]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellOrder](
	[code] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NULL,
	[staffCode] [nvarchar](50) NULL,
	[customerCode] [nvarchar](50) NULL,
	[amount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[staffCode] [nvarchar](50) NOT NULL,
	[staffName] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[sex] [nvarchar](20) NULL,
	[dob] [nvarchar](50) NULL,
	[phoneNumber] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[staffCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/19/2020 8:51:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C01', N'Cà Phê Việt Nam')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C010', N'Cà Phê Gói')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C011', N'Merchandise')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C02', N'Cà Phê Máy')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C03', N'Cold Brew')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C04', N'Trà Trái Cây')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C05', N'Trà Sữa Macchiato')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C06', N'Cà Phê Đá Xay')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C07', N'Thức Uống Trái Cây')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C08', N'Match - Socola')
INSERT [dbo].[Category] ([categoryCode], [categoryName]) VALUES (N'C09', N'Bánh & Snack')
INSERT [dbo].[Customers] ([customerCode], [customerName], [AddressName], [PhoneNumber]) VALUES (N'CC01', N'Nguyen Chuong', N'Thanh Chuong, Nghe An', N'0916878445')
INSERT [dbo].[Customers] ([customerCode], [customerName], [AddressName], [PhoneNumber]) VALUES (N'CC02', N'Manh Hung', N'Thai Hoa, Nghe An', N'0926873445')
INSERT [dbo].[Customers] ([customerCode], [customerName], [AddressName], [PhoneNumber]) VALUES (N'CC03', N'Andrew Vu', N'Thach Hoa, Ha Noi', N'0976877445')
INSERT [dbo].[Customers] ([customerCode], [customerName], [AddressName], [PhoneNumber]) VALUES (N'CC04', N'Tra My', N'Quoc Oai, Ha Noi', N'0932865445')
INSERT [dbo].[Customers] ([customerCode], [customerName], [AddressName], [PhoneNumber]) VALUES (N'CC05', N'Khanh Thanh', N'Ba Vi, Ha Noi', N'0916875545')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC01', N'Sugar', 190.0000, N'PC01')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC02', N'Milk', 170.0000, N'PC01')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC03', N'Tea', 200.0000, N'PC02')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC04', N'Syrup', 160.0000, N'PC01')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC05', N'Chocolate', 175.0000, N'PC02')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC06', N'Ice-Cream', 100.0000, N'PC03')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC07', N'Matcha', 210.0000, N'PC04')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC08', N'Sauces', 215.0000, N'PC06')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC09', N'Tiramisu', 150.0000, N'PC05')
INSERT [dbo].[Materials] ([materialCode], [materialName], [price], [providerCode]) VALUES (N'MC10', N'Cacao', 185.0000, N'PC07')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P01', N'Coffesua', N'C01', 16000.0000, 32000.0000, 101, N'p1.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P02', N'Cà Phê Đen', N'C01', 16000.0000, 32000.0000, 20, N'p2.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P03', N'Cà Phê Sữa', N'C01', 16000.0000, 32000.0000, 30, N'p3.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P04', N'Americano', N'C02', 14000.0000, 39000.0000, 40, N'p4.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P05', N'Cappuccino', N'C02', 22000.0000, 45000.0000, 100, N'p5.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P06', N'Caramel Macchiato', N'C02', 27000.0000, 55000.0000, 60, N'p6.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P07', N'Espresso', N'C02', 17000.0000, 35000.0000, 70, N'p7.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P08', N'Latte', N'C02', 22000.0000, 45000.0000, 80, N'p8.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P09', N'Mocha', N'C02', 24000.0000, 49000.0000, 90, N'p9.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P10', N'Cold Brew Truyền Thống', N'C03', 22000.0000, 45000.0000, 10, N'p10.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P11', N'Cold Brew Cam Vàng', N'C03', 25000.0000, 50000.0000, 20, N'p11jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P12', N'Cold Brew Sữa Tươi Macchiato', N'C03', 25000.0000, 50000.0000, 30, N'p12.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P123', N'Coffe goi', N'C010', 100.0000, 120.0000, 12, N'p10.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P13', N'Cold Brew Phúc Bồn Tử', N'C03', 25000.0000, 50000.0000, 40, N'p13.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P14', N'Cold Brew Sữa Tươi', N'C03', 25000.0000, 50000.0000, 50, N'p14.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P15', N'Trà Oolong Vải', N'C04', 22000.0000, 45000.0000, 60, N'p15.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P16', N'Trà Oolong Hạt Sen', N'C04', 22000.0000, 45000.0000, 70, N'p16.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P17', N'Trà Đào Cam Sả', N'C04', 22000.0000, 45000.0000, 80, N'p17.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P18', N'Trà Oolong Bưởi Mật Ong', N'C04', 25000.0000, 50000.0000, 90, N'p18.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P19', N'Trà Oolong Phúc Bồn Tử', N'C04', 25000.0000, 50000.0000, 10, N'p19.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P20', N'Trà Lài Macchiato', N'C05', 21000.0000, 42000.0000, 20, N'p20.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P21', N'Trà Đen Macchiato', N'C05', 21000.0000, 42000.0000, 30, N'p21.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P22', N'Trà Sữa Mắc Ca Trân Châu Trắng', N'C05', 22000.0000, 45000.0000, 40, N'p22.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P23', N'Trà Matcha Macchiato', N'C05', 22000.0000, 45000.0000, 50, N'p23.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P24', N'Trà Xoài Macchiato', N'C05', 27000.0000, 55000.0000, 60, N'p24.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P25', N'Trà Cà Phê Đá Xay', N'C06', 29000.0000, 59000.0000, 70, N'p25.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P26', N'Cà Phê Đá Xay', N'C06', 29000.0000, 59000.0000, 80, N'p26.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P27', N'Chanh Sả Đá Xay', N'C07', 25000.0000, 49000.0000, 90, N'p27.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P28', N'Phúc Bồn Tử Cam Đá Xay', N'C07', 30000.0000, 59000.0000, 10, N'p28.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P29', N'Sinh Tố Cam Xoài', N'C07', 30000.0000, 59000.0000, 20, N'p29.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P30', N'Sinh Tố Việt Quất', N'C07', 30000.0000, 59000.0000, 30, N'p30.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P31', N'Socola Đá', N'C08', 30000.0000, 59000.0000, 30, N'p31.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P32', N'Socola Đá Xay', N'C08', 30000.0000, 59000.0000, 30, N'p32.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P33', N'Matcha Đá Xay', N'C08', 30000.0000, 59000.0000, 30, N'p33.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P34', N'Matcha Latte', N'C08', 30000.0000, 59000.0000, 30, N'p34.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P35', N'Bánh Bông Lan Trứng Muối', N'C09', 15000.0000, 29000.0000, 30, N'p35.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P36', N'Bánh Gấu Chocolate', N'C09', 20000.0000, 39000.0000, 30, N'p36.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P37', N'Bánh Matcha', N'C09', 15000.0000, 29000.0000, 30, N'p37.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P38', N'Bánh Mì Chà Bông Phô Mai', N'C09', 16000.0000, 32000.0000, 30, N'p38.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P39', N'Bánh Passion Cheese', N'C09', 15000.0000, 29000.0000, 30, N'p39.jpg')
INSERT [dbo].[Products] ([productCode], [productName], [categoryCode], [purchasePrice], [sellPrice], [quantity], [image]) VALUES (N'P40', N'Bánh Tiramisu', N'C09', 15000.0000, 29000.0000, 30, N'p40.jpg')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC01', N'Coffee Bean', N'Brazil', N'0916854643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC02', N'Ba Vi Milk', N'Ba Vi, Ha Noi', N'0912154643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC03', N'Phuc Long Tea', N'China', N'0916854643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC04', N'Syrup', N'Singapore', N'0926854643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC05', N'Chocolate Provider', N'Belgium', N'0936854643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC06', N'Ice-Cream Prodivder', N'American', N'0916844643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC07', N'Matcha Japan', N'Thai Nguyen', N'0916854643')
INSERT [dbo].[Providers] ([providerCode], [providerName], [Address], [PhoneNumber]) VALUES (N'PC08', N'Sauces For EveryOne', N'Tan Phu, TP Ho Chi Minh', N'0966654643')
INSERT [dbo].[staff] ([staffCode], [staffName], [address], [sex], [dob], [phoneNumber]) VALUES (N'S01', N'Peter', N'Hogwart Street', N'Male', N'2000-11-11', N'123321123')
INSERT [dbo].[staff] ([staffCode], [staffName], [address], [sex], [dob], [phoneNumber]) VALUES (N'S02', N'John', N'Washington', N'Female', N'1988-01-11', N'123333333')
INSERT [dbo].[staff] ([staffCode], [staffName], [address], [sex], [dob], [phoneNumber]) VALUES (N'S03', N'Linda', N'New York', N'Female', N'1999-03-03', N'1123456789')
INSERT [dbo].[staff] ([staffCode], [staffName], [address], [sex], [dob], [phoneNumber]) VALUES (N'S04', N'Wibu', N'DomF xx', N'Female', N'Thursday, November 12, 2020', N'121212212')
INSERT [dbo].[Users] ([Username], [Password]) VALUES (N'admin', N'admin')
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([providerCode])
REFERENCES [dbo].[Providers] ([providerCode])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([categoryCode])
REFERENCES [dbo].[Category] ([categoryCode])
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD FOREIGN KEY([materialCode])
REFERENCES [dbo].[Materials] ([materialCode])
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD FOREIGN KEY([purchaseCode])
REFERENCES [dbo].[PurchaseOrder] ([code])
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD FOREIGN KEY([providerCode])
REFERENCES [dbo].[Providers] ([providerCode])
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD FOREIGN KEY([staffCode])
REFERENCES [dbo].[staff] ([staffCode])
GO
ALTER TABLE [dbo].[SellDetail]  WITH CHECK ADD FOREIGN KEY([sellCode])
REFERENCES [dbo].[SellOrder] ([code])
GO
ALTER TABLE [dbo].[SellDetail]  WITH CHECK ADD FOREIGN KEY([productCode])
REFERENCES [dbo].[Products] ([productCode])
GO
ALTER TABLE [dbo].[SellOrder]  WITH CHECK ADD FOREIGN KEY([customerCode])
REFERENCES [dbo].[Customers] ([customerCode])
GO
ALTER TABLE [dbo].[SellOrder]  WITH CHECK ADD FOREIGN KEY([staffCode])
REFERENCES [dbo].[staff] ([staffCode])
GO
USE [master]
GO
ALTER DATABASE [CoffeeShopManagement] SET  READ_WRITE 
GO


insert into PurchaseOrder values ('PO01','20/10/2020','S01','PC01','2000')
insert into PurchaseOrder values ('PO02','20/11/2020','S02','PC02','2500')
insert into PurchaseOrder values ('PO03','19/08/2020','S01','PC03','1000')
insert into PurchaseOrder values ('PO04','16/07/2020','S01','PC04','2050')
insert into PurchaseOrder values ('PO05','06/05/2020','S02','PC05','3000')
insert into PurchaseOrder values ('PO06','23/06/2020','S01','PC06','1000')
insert into PurchaseOrder values ('PO07','28/09/2020','S01','PC01','2100')
insert into PurchaseOrder values ('PO08','27/01/2020','S04','PC03','3500')
insert into PurchaseOrder values ('PO09','22/12/2020','S01','PC02','5000')
insert into PurchaseOrder values ('PO10','26/11/2020','S01','PC01','4000')
insert into PurchaseOrder values ('PO11','24/05/2020','S02','PC04','1500')
insert into PurchaseOrder values ('PO12','25/10/2020','S04','PC01','4500')
insert into PurchaseOrder values ('PO13','21/09/2020','S03','PC01','2400')
insert into PurchaseOrder values ('PO14','22/10/2020','S02','PC01','3500')
insert into PurchaseOrder values ('PO15','01/10/2020','S01','PC01','6000')


insert into PurchaseDetail values ('PO01','MC01','3','1500','20','5')
insert into PurchaseDetail values ('PO02','MC02','5','1700','25','10')
insert into PurchaseDetail values ('PO03','MC01','1','1800','20','5')
insert into PurchaseDetail values ('PO04','MC03','1','1100','20','10')
insert into PurchaseDetail values ('PO05','MC01','2','1200','20','5')
insert into PurchaseDetail values ('PO06','MC04','1','1300','30','5')
insert into PurchaseDetail values ('PO07','MC04','1','1400','20','5')
insert into PurchaseDetail values ('PO08','MC01','3','1900','35','5')
insert into PurchaseDetail values ('PO09','MC05','5','1100','35','10')
insert into PurchaseDetail values ('PO10','MC01','4','2500','20','5')
insert into PurchaseDetail values ('PO11','MC05','4','2500','20','5')
insert into PurchaseDetail values ('PO12','MC06','4','3500','30','10')
insert into PurchaseDetail values ('PO13','MC01','2','1900','20','5')
insert into PurchaseDetail values ('PO14','MC07','2','1900','35','5')
insert into PurchaseDetail values ('PO15','MC07','1','1400','20','10')


insert into SellOrder values ('SO01','06/06/2020','S01','CC01','50')
insert into SellOrder values ('SO02','07/07/2020','S01','CC03','55')
insert into SellOrder values ('SO03','07/06/2020','S02','CC02','50')
insert into SellOrder values ('SO04','08/04/2020','S01','CC04','40')
insert into SellOrder values ('SO05','08/06/2020','S02','CC05','50')
insert into SellOrder values ('SO06','09/05/2020','S03','CC02','30')
insert into SellOrder values ('SO07','09/06/2020','S03','CC01','50')
insert into SellOrder values ('SO08','09/07/2020','S03','CC04','20')
insert into SellOrder values ('SO09','10/06/2020','S01','CC01','50')
insert into SellOrder values ('SO10','06/10/2020','S04','CC04','30')
insert into SellOrder values ('SO11','11/06/2020','S01','CC04','50')
insert into SellOrder values ('SO12','06/11/2020','S01','CC01','20')
insert into SellOrder values ('SO13','06/06/2020','S04','CC05','50')
insert into SellOrder values ('SO14','12/02/2020','S04','CC05','20')
insert into SellOrder values ('SO15','06/06/2020','S04','CC01','50')


insert into SellDetail values ('SO01','P01','7','10','6')
insert into SellDetail values ('SO02','P01','7','20','5')
insert into SellDetail values ('SO03','P02','8','15','10')
insert into SellDetail values ('SO04','P01','8','20','10')
insert into SellDetail values ('SO05','P02','7','20','6')
insert into SellDetail values ('SO06','P04','6','25','6')
insert into SellDetail values ('SO07','P04','4','30','5')
insert into SellDetail values ('SO08','P01','4','30','5')
insert into SellDetail values ('SO09','P02','5','20','5')
insert into SellDetail values ('SO10','P03','1','30','10')
insert into SellDetail values ('SO11','P04','1','20','15')
insert into SellDetail values ('SO12','P06','5','25','5')
insert into SellDetail values ('SO13','P07','3','20','6')
insert into SellDetail values ('SO14','P09','3','20','20')
insert into SellDetail values ('SO15','P10','2','25','15')