USE [CalcDB]
GO

/****** Object:  StoredProcedure [dbo].[GetRecentOperationsByOperationType]    Script Date: 2022-12-12 1:43:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRecentOperationsByOperationType] 
	-- Add the parameters for the stored procedure here
	@OperationTYpe int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 3 ch.* from CalculationHistory ch
	where operationTypeId = @OperationTYpe
	order by calcdate desc
END
GO


