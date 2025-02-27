USE [Game_Platform]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 27.02.2025 21:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[GameID] [int] NOT NULL,
	[GamerID] [int] NOT NULL,
	[Rating] [tinyint] NOT NULL,
	[ReviewText] [nvarchar](4000) NOT NULL,
	[ReviewDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reviews] ADD  CONSTRAINT [DF__Reviews__ReviewD__5441852A]  DEFAULT (getdate()) FOR [ReviewDate]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK__Reviews__GameID__5535A963] FOREIGN KEY([GameID])
REFERENCES [dbo].[Games] ([GameID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK__Reviews__GameID__5535A963]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK__Reviews__GamerID__5629CD9C] FOREIGN KEY([GamerID])
REFERENCES [dbo].[Gamers] ([GamerID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK__Reviews__GamerID__5629CD9C]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [CK__Reviews__Rating__534D60F1] CHECK  (([Rating]<=(5) AND [Rating]>=(1)))
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [CK__Reviews__Rating__534D60F1]
GO
