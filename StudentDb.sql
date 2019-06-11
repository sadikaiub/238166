--CREATE DATABASE StudentDb
USE [StudentDb]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/11/2019 11:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (100, N'Sadik', 23)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (101, N'Shibly', 23)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (102, N'Shaheen', 25)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (103, N'Ashraful', 20)
SET IDENTITY_INSERT [dbo].[Students] OFF
