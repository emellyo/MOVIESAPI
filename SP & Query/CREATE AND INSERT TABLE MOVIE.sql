CREATE TABLE [dbo].[MOVIES](
	[ID] [integer] NOT NULL,
	[title] [varchar](100) NOT NULL,
	[description] [varchar](MAX) NOT NULL,
	[rating] [numeric](19,1) NOT NULL,
	[image] [varchar](MAX) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL
 CONSTRAINT [PK_MOVIES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO MOVIES(ID, title, description, rating, image,  created_at, updated_at) 
VALUES(1, N'Pengabdi Setan 2 Comunion', N'adalah sebuah film horor Indonesia tahun 2022 yang disutradarai dan 
ditulis oleh Joko Anwar sebagai sekuel dari film tahun 2017, Pengabdi 
Setan', 7, '', '2022-08-01 10:56:31', '2022-08-13 09:30:23')
