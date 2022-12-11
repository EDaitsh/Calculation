USE [CalcDB]
GO

/****** Object:  StoredProcedure [dbo].[GetMinMaxAveOperationsByOperationType]    Script Date: 2022-12-12 1:42:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetMinMaxAveOperationsByOperationType] 
	-- Add the parameters for the stored procedure here
	@OperationType int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT min(result) as MIN, max(result) as MAX, AVG(result) as AVG
	from CalculationHistory 
	where operationTypeId = @OperationTYpe
	group by operationTypeId
END
GO


