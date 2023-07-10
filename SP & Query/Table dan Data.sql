/****** Object:  Table [dbo].[data_nama]    Script Date: 28/03/2023 09:42:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_nama](
	[ID] [varchar](30) NOT NULL,
	[nama] [varchar](100) NOT NULL,
	[nama_pangilan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_data_nama] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_user]    Script Date: 28/03/2023 09:42:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_user](
	[USERID] [varchar](30) NOT NULL,
	[USERNAME] [varchar](30) NOT NULL,
	[nama] [varchar](100) NOT NULL,
	[nama_pangilan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_data_user] PRIMARY KEY CLUSTERED 
(
	[USERID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'ALEX001', N'Alex Maulana Firmansyah', N'Alex')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'CANDRA001', N'Candra Bagus Setyo Putro', N'Candra')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'DARWIN001', N'Darwin Rasubala', N'Darwin')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'FIDA001', N'Fida Royani', N'Fida')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'GHIFAR001', N'Moch. Ghifar Virawan', N'Ghifar')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'ZACHARY001', N'Zachary Osborn', N'Osborn')
INSERT [dbo].[data_nama] ([ID], [nama], [nama_pangilan]) VALUES (N'ZHAZHA001', N'Zhazha Quamilla', N'Zhazha')
GO
INSERT [dbo].[data_user] ([USERID], [USERNAME], [nama], [nama_pangilan]) VALUES (N'ALEX001', N'ALEX001', N'Alex Firmansyah', N'Alex')
INSERT [dbo].[data_user] ([USERID], [USERNAME], [nama], [nama_pangilan]) VALUES (N'MRX', N'MRX', N'Mister X', N'X')
GO
