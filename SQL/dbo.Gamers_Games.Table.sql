USE [Game_Platform]
GO
/****** Object:  Table [dbo].[Gamers_Games]    Script Date: 27.02.2025 21:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gamers_Games](
	[GamerID] [int] NOT NULL,
	[GameID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gamers_Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Gamers_Gamers] FOREIGN KEY([GamerID])
REFERENCES [dbo].[Gamers] ([GamerID])
GO
ALTER TABLE [dbo].[Gamers_Games] CHECK CONSTRAINT [FK_Games_Gamers_Gamers]
GO
ALTER TABLE [dbo].[Gamers_Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Gamers_Games] FOREIGN KEY([GameID])
REFERENCES [dbo].[Games] ([GameID])
GO
ALTER TABLE [dbo].[Gamers_Games] CHECK CONSTRAINT [FK_Games_Gamers_Games]
GO
