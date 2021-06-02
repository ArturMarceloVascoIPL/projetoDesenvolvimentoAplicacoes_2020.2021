SET QUOTED_IDENTIFIER OFF;
GO
USE [BookidsDB];

ALTER TABLE [dbo].[Produtos]
ALTER COLUMN [Preco] decimal(18,2) NOT NULL
GO

ALTER TABLE [dbo].[Pessoas_Cliente]
ALTER COLUMN [ValorOferta] decimal(18,2) NULL
GO