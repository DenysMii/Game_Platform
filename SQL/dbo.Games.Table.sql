USE [Game_Platform]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 27.02.2025 21:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[GameID] [int] IDENTITY(1,1) NOT NULL,
	[DeveloperID] [int] NOT NULL,
	[PlatformID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](4000) NOT NULL,
	[Genre] [nvarchar](20) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Games] ADD  CONSTRAINT [DF__GAMES__ReleaseDa__4222D4EF]  DEFAULT (getdate()) FOR [ReleaseDate]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Developer] FOREIGN KEY([DeveloperID])
REFERENCES [dbo].[Developers] ([DeveloperID])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Developer]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Platforms1] FOREIGN KEY([PlatformID])
REFERENCES [dbo].[Platforms] ([PlatformID])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Platforms1]
GO
