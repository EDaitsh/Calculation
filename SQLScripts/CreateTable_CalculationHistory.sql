USE [CalcDB]
GO

/****** Object:  Table [dbo].[CalculationHistory]    Script Date: 2022-12-12 1:39:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CalculationHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[field1] [decimal](18, 0) NOT NULL,
	[field2] [decimal](18, 0) NOT NULL,
	[operationTypeId] [int] NOT NULL,
	[result] [decimal](18, 0) NOT NULL,
	[calcDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CalculationHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CalculationHistory]  WITH CHECK ADD  CONSTRAINT [FK_CalculationHistory_OperationType] FOREIGN KEY([operationTypeId])
REFERENCES [dbo].[OperationType] ([Id])
GO

ALTER TABLE [dbo].[CalculationHistory] CHECK CONSTRAINT [FK_CalculationHistory_OperationType]
GO


