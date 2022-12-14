USE [master]
GO
/****** Object:  Database [STOCK_MANAGEMENT]    Script Date: 6/4/2022 11:37:13 PM ******/
CREATE DATABASE [STOCK_MANAGEMENT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STOCK_MANAGEMENT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\STOCK_MANAGEMENT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'STOCK_MANAGEMENT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\STOCK_MANAGEMENT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STOCK_MANAGEMENT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ARITHABORT OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET  MULTI_USER 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET QUERY_STORE = OFF
GO
USE [STOCK_MANAGEMENT]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[phone] [varchar](15) NOT NULL,
	[address] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[order_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[price] [int] NOT NULL,
	[description] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_order]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_order](
	[product_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplying]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplying](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplying_product]    Script Date: 6/4/2022 11:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplying_product](
	[supplying_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [username], [password], [name], [phone], [address]) VALUES (1, N'a', N'a', N'a', N'0123456789', N'a')
INSERT [dbo].[customer] ([id], [username], [password], [name], [phone], [address]) VALUES (2, N'b', N'b', N'b', N'0123456789', N'b')
INSERT [dbo].[customer] ([id], [username], [password], [name], [phone], [address]) VALUES (3, N'c', N'c', N'c', N'0123456789', N'c')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[order] ON 

INSERT [dbo].[order] ([id], [customer_id], [order_at]) VALUES (1, 1, CAST(N'2022-06-04T01:57:30.553' AS DateTime))
INSERT [dbo].[order] ([id], [customer_id], [order_at]) VALUES (2, 2, CAST(N'2022-06-04T01:57:30.553' AS DateTime))
INSERT [dbo].[order] ([id], [customer_id], [order_at]) VALUES (3, 3, CAST(N'2022-06-04T01:57:30.553' AS DateTime))
SET IDENTITY_INSERT [dbo].[order] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name], [price], [description]) VALUES (1, N'Iphone X', 100000, N'Iphone X')
INSERT [dbo].[product] ([id], [name], [price], [description]) VALUES (2, N'Samsung S10', 80000, N'Samsung S10')
INSERT [dbo].[product] ([id], [name], [price], [description]) VALUES (3, N'Xiaomi Mi8', 60000, N'Xiaomi Mi8')
SET IDENTITY_INSERT [dbo].[product] OFF
GO
INSERT [dbo].[product_order] ([product_id], [order_id], [quantity]) VALUES (1, 1, 10)
INSERT [dbo].[product_order] ([product_id], [order_id], [quantity]) VALUES (2, 1, 20)
INSERT [dbo].[product_order] ([product_id], [order_id], [quantity]) VALUES (3, 1, 30)
INSERT [dbo].[product_order] ([product_id], [order_id], [quantity]) VALUES (1, 2, 40)
INSERT [dbo].[product_order] ([product_id], [order_id], [quantity]) VALUES (2, 2, 50)
GO
SET IDENTITY_INSERT [dbo].[supplying] ON 

INSERT [dbo].[supplying] ([id], [order_at]) VALUES (9, CAST(N'2022-06-04T23:00:59.887' AS DateTime))
INSERT [dbo].[supplying] ([id], [order_at]) VALUES (10, CAST(N'2022-06-04T23:01:53.987' AS DateTime))
INSERT [dbo].[supplying] ([id], [order_at]) VALUES (11, CAST(N'2022-06-04T23:02:34.703' AS DateTime))
INSERT [dbo].[supplying] ([id], [order_at]) VALUES (12, CAST(N'2022-06-04T23:03:27.760' AS DateTime))
INSERT [dbo].[supplying] ([id], [order_at]) VALUES (13, CAST(N'2022-06-04T23:04:15.287' AS DateTime))
SET IDENTITY_INSERT [dbo].[supplying] OFF
GO
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (10, 1, 4)
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (10, 2, 6)
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (10, 3, 9)
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (13, 1, 4)
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (13, 2, 6)
INSERT [dbo].[supplying_product] ([supplying_id], [product_id], [quantity]) VALUES (13, 3, 8)
GO
ALTER TABLE [dbo].[order] ADD  DEFAULT (getdate()) FOR [order_at]
GO
ALTER TABLE [dbo].[supplying] ADD  DEFAULT (getdate()) FOR [order_at]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [fk_order_customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [fk_order_customer]
GO
ALTER TABLE [dbo].[product_order]  WITH CHECK ADD  CONSTRAINT [fk_order_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[product_order] CHECK CONSTRAINT [fk_order_product]
GO
ALTER TABLE [dbo].[product_order]  WITH CHECK ADD  CONSTRAINT [fk_product_order] FOREIGN KEY([order_id])
REFERENCES [dbo].[order] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[product_order] CHECK CONSTRAINT [fk_product_order]
GO
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [fk_stock_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [fk_stock_product]
GO
ALTER TABLE [dbo].[supplying_product]  WITH CHECK ADD  CONSTRAINT [fk_product_supplying] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[supplying_product] CHECK CONSTRAINT [fk_product_supplying]
GO
ALTER TABLE [dbo].[supplying_product]  WITH CHECK ADD  CONSTRAINT [fk_supplying_product] FOREIGN KEY([supplying_id])
REFERENCES [dbo].[supplying] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[supplying_product] CHECK CONSTRAINT [fk_supplying_product]
GO
USE [master]
GO
ALTER DATABASE [STOCK_MANAGEMENT] SET  READ_WRITE 
GO
