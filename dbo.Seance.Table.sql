USE [RevisionTp]
GO
/****** Object:  Table [dbo].[Seance]    Script Date: 1/12/2020 6:50:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_seance] [date] NULL,
	[masse] [varchar](50) NULL,
	[valide] [varchar](50) NULL,
	[id_enseignant] [int] NULL,
	[id_inscription] [int] NULL,
 CONSTRAINT [PK_Seance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Seance]  WITH CHECK ADD  CONSTRAINT [FK_Seance_Enseignant] FOREIGN KEY([id_enseignant])
REFERENCES [dbo].[Enseignant] ([id])
GO
ALTER TABLE [dbo].[Seance] CHECK CONSTRAINT [FK_Seance_Enseignant]
GO
ALTER TABLE [dbo].[Seance]  WITH CHECK ADD  CONSTRAINT [FK_Seance_Inscription] FOREIGN KEY([id_inscription])
REFERENCES [dbo].[Inscription] ([id])
GO
ALTER TABLE [dbo].[Seance] CHECK CONSTRAINT [FK_Seance_Inscription]
GO
