CREATE TABLE [dbo].[MOVIES](
	[ID] [varchar](30) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[rating] [INT] NOT NULL,
	[image] [varchar] (MAX) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL
 CONSTRAINT [PK_data_movie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
