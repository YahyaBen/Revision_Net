USE [RevisionTp]
GO
/****** Object:  Table [dbo].[Inscription]    Script Date: 1/12/2020 6:50:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscription](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_debut] [date] NULL,
	[duree] [int] NULL,
	[date_publication] [date] NULL,
	[montant] [float] NULL,
	[id_matiere] [int] NULL,
	[id_etudiant] [int] NULL,
 CONSTRAINT [PK_Inscription] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD  CONSTRAINT [FK_Inscription_Etudiant] FOREIGN KEY([id_etudiant])
REFERENCES [dbo].[Etudiant] ([id])
GO
ALTER TABLE [dbo].[Inscription] CHECK CONSTRAINT [FK_Inscription_Etudiant]
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD  CONSTRAINT [FK_Inscription_Matiere] FOREIGN KEY([id_matiere])
REFERENCES [dbo].[Matiere] ([id])
GO
ALTER TABLE [dbo].[Inscription] CHECK CONSTRAINT [FK_Inscription_Matiere]
GO
