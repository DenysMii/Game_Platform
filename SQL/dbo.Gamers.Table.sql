USE [Game_Platform]
GO
/****** Object:  Table [dbo].[Gamers]    Script Date: 27.02.2025 21:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gamers](
	[GamerID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RegisterDate] [date] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[GamerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gamers] ADD  CONSTRAINT [DF_Gamers_RegisterDate]  DEFAULT (getdate()) FOR [RegisterDate]
GO
