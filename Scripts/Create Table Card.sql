USE [CardGenerator]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[CardNumber] [varchar](16) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CreatedAt] [date] NOT NULL,
	
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[CardNumber] ASC,
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Card] ([CardNumber], [Email], [CreatedAt]) VALUES ('12345678', 'teste@gmail.com', SYSDATETIME())