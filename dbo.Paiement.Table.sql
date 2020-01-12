USE [RevisionTp]
GO
/****** Object:  Table [dbo].[Paiement]    Script Date: 1/12/2020 6:50:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paiement](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_paiment] [date] NULL,
	[montant] [float] NULL,
	[imprime] [varchar](50) NULL,
	[id_inscription] [int] NULL,
 CONSTRAINT [PK_Paiement] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Paiement]  WITH CHECK ADD  CONSTRAINT [FK_Paiement_Inscription] FOREIGN KEY([id_inscription])
REFERENCES [dbo].[Inscription] ([id])
GO
ALTER TABLE [dbo].[Paiement] CHECK CONSTRAINT [FK_Paiement_Inscription]
GO
