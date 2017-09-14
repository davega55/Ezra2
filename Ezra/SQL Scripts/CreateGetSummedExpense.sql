Use Ezra
Go

IF OBJECT_ID (N'dbo.GetSummedExpense', N'FN') IS NOT NULL
	DROP FUNCTION dbo.GetSummedExpense;
GO
CREATE FUNCTION [dbo].[GetSummedExpense]
(
	@begDate datetime, 
	@endDate datetime, 
	@catNum int
)
RETURNS decimal(12,2)
AS
BEGIN
	DECLARE @amount decimal(12,2);
	select @amount = Sum(ChkPymt) from CKCUChecking
	where ChkDate Between @begDate And @endDate And NewCatID = @catNum;
	IF(@amount IS NULL)
		SET @amount = 0;
	RETURN @amount;
END;
GO