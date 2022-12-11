USE [CalcDB]
GO

/****** Object:  StoredProcedure [dbo].[GetCountOperationsByOperationType]    Script Date: 2022-12-12 1:41:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCountOperationsByOperationType] 
	-- Add the parameters for the stored procedure here
	@OperationType int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT count(*) as Value
	from CalculationHistory 
	where operationTypeId = @OperationTYpe
	and Month(calcdate) = MONTH(getdate())
	group by operationTypeId
END
GO


