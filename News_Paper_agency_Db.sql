USE [Testdb]
GO

/****** Object:  Table [dbo].[Billdb]    Script Date: 19-04-2016 09:37:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Billdb](
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Week_Price] [float] NOT NULL,
	[Month_Price] [float] NOT NULL,
 CONSTRAINT [PK_Billdb] PRIMARY KEY CLUSTERED 
(
	[Customer_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [Testdb]
GO

/****** Object:  Table [dbo].[BillFormatdb]    Script Date: 19-04-2016 09:37:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BillFormatdb](
	[Customer_ID] [nchar](4) NOT NULL,
	[Customer Name] [nvarchar](50) NOT NULL,
	[Delivery Charge] [float] NOT NULL,
	[Bill Month] [nvarchar](20) NOT NULL,
	[Bill Amount] [float] NOT NULL,
	[Total Amount] [float] NOT NULL,
 CONSTRAINT [PK_BillFormatdb] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC,
	[Customer Name] ASC,
	[Bill Month] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [Testdb]
GO

/****** Object:  Table [dbo].[Billreceiveddb]    Script Date: 19-04-2016 09:37:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Billreceiveddb](
	[Customer] [nvarchar](50) NOT NULL,
	[Amount/due] [float] NOT NULL,
	[Received] [float] NOT NULL,
	[balance] [float] NOT NULL
) ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[CustomerRequiementdb]    Script Date: 19-04-2016 09:38:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerRequiementdb](
	[Customer_ID] [nchar](4) NOT NULL,
	[Product_ID] [nchar](4) NOT NULL,
	[CName] [nvarchar](25) NOT NULL,
	[Product_Name] [nvarchar](25) NOT NULL,
	[Mon_Copies] [int] NULL,
	[Tue_Copies] [int] NULL,
	[Wed_Copies] [int] NULL,
	[Thur_Copies] [int] NULL,
	[Fri_Copies] [int] NULL,
	[Sat_Copies] [int] NULL,
	[Sun_Copies] [int] NULL,
 CONSTRAINT [PK_CustomeRequiementdb] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC,
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[Customersdb]    Script Date: 19-04-2016 09:38:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customersdb](
	[Customer_ID] [nchar](4) NOT NULL,
	[Customer_Name] [nvarchar](25) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Delivery_Charge] [float] NOT NULL,
	[Start_Date] [datetime] NOT NULL,
	[End_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Customersdb] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[DailySaledb]    Script Date: 19-04-2016 09:38:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DailySaledb](
	[Product] [nvarchar](25) NOT NULL,
	[Total_Sale_Qty] [int] NOT NULL,
	[Rate] [float] NOT NULL,
	[Total_Sale_Amount] [float] NOT NULL,
	[date] [date] NOT NULL
) ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[DailyStockdb]    Script Date: 19-04-2016 09:38:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DailyStockdb](
	[NameOfProduct] [nvarchar](25) NOT NULL,
	[Rate] [float] NOT NULL,
	[Total_Quantity] [int] NOT NULL,
	[Returned] [int] NOT NULL,
	[Supplier_ID] [nchar](4) NOT NULL,
	[Total_Amount] [float] NULL
) ON [PRIMARY]

GO



USE [Testdb]
GO

/****** Object:  Table [dbo].[Logindb]    Script Date: 19-04-2016 09:39:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Logindb](
	[Users] [nchar](16) NOT NULL,
	[Password] [nchar](12) NOT NULL,
 CONSTRAINT [PK_Logindb] PRIMARY KEY CLUSTERED 
(
	[Users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[MonthlySaledb]    Script Date: 19-04-2016 09:39:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MonthlySaledb](
	[Month] [nchar](10) NOT NULL,
	[Year] [int] NOT NULL,
	[Total_Sale] [float] NOT NULL,
	[Total_Amount] [float] NOT NULL,
 CONSTRAINT [PK_MonthlySaledb] PRIMARY KEY CLUSTERED 
(
	[Month] ASC,
	[Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [Testdb]
GO

/****** Object:  Table [dbo].[Productdb]    Script Date: 19-04-2016 09:39:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productdb](
	[Product_ID] [nchar](4) NOT NULL,
	[Product_Name] [nvarchar](25) NOT NULL,
	[Language] [nvarchar](12) NOT NULL,
	[Supplier_ID] [nchar](4) NOT NULL,
	[Monday] [float] NOT NULL,
	[Tuesday] [float] NOT NULL,
	[Wednesday] [float] NOT NULL,
	[Thursday] [float] NOT NULL,
	[Friday] [float] NOT NULL,
	[Saturday] [float] NOT NULL,
	[Sunday] [float] NOT NULL,
 CONSTRAINT [PK_Productdb] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [Testdb]
GO

/****** Object:  Table [dbo].[SPGriddb]    Script Date: 19-04-2016 09:39:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SPGriddb](
	[Product] [nvarchar](25) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Supplier_ID] [nchar](4) NOT NULL
) ON [PRIMARY]

GO

USE [Testdb]
GO

/****** Object:  Table [dbo].[Supplierdb]    Script Date: 19-04-2016 09:40:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Supplierdb](
	[Supplier_ID] [nchar](4) NOT NULL,
	[Supplier_Name] [varchar](25) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[Phone_No] [char](11) NOT NULL,
 CONSTRAINT [PK_Supplierdb] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [Testdb]
GO

/****** Object:  Table [dbo].[SupplierPaymentdb]    Script Date: 19-04-2016 09:40:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SupplierPaymentdb](
	[Supplier] [nchar](4) NOT NULL,
	[Date_f] [datetime] NOT NULL,
	[Date_t] [datetime] NOT NULL,
	[Total_Amount] [float] NOT NULL,
	[Billed_Amount] [float] NOT NULL,
	[PBalance] [float] NOT NULL,
	[Total_Bill] [float] NOT NULL,
	[Amount_Paid] [float] NOT NULL
) ON [PRIMARY]

GO

