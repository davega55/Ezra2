USE Ezra;
GO
IF OBJECT_ID(N'dbo.tvfGetMonthlyNums', N'TF') IS NOT NULL
    DROP FUNCTION dbo.tvfGetMonthlyNums;
GO
CREATE FUNCTION dbo.tvfGetMonthlyNums(@begDate datetime, @endDate dateTime)
RETURNS @retMonthlyNums TABLE 
(
    -- Columns returned by the function
    CatNum int PRIMARY KEY NOT NULL, 
    Amount decimal(12,2) NULL, 
    AmtType int NULL
)
AS
Begin
	Declare
	@CatNum int,
	@Amount decimal(12,2),
	@AmtType int

	--Get Income Amounts
	Set @CatNum = (select Min(CatID) From Categories Where CatPrintOrd Is Not Null And CatType = 4)

	While @CatNum Is Not Null
	Begin
		Set @AmtType = 4;
		select @Amount= ISNULL(Sum(ChkDep),0) from CKCUChecking
		where ChkDate >= @begDate And ChkDate <= @endDate And NewCatID = @CatNum;

		Begin
			Insert @retMonthlyNums
			Select @CatNum, @Amount, @AmtType;
		End;

		Set @CatNum = (select Min(CatID) From Categories 
			Where CatPrintOrd Is Not Null And CatType = 4 And CatID > @CatNum)
	End

	--Get Expense Amounts
	Set @CatNum = (select Min(CatID) From Categories Where CatPrintOrd Is Not Null And CatType = 5)

	While @CatNum Is Not Null
	Begin
		Set @AmtType = 5;
		select @Amount= ISNULL(Sum(ChkPymt),0) from CKCUChecking
		where ChkDate >= @begDate And ChkDate <= @endDate And NewCatID = @CatNum;

		Begin
			Insert @retMonthlyNums
			Select @CatNum, @Amount, @AmtType;
		End;

		Set @CatNum = (select Min(CatID) From Categories 
			Where CatPrintOrd Is Not Null And CatType = 5 And CatID > @CatNum)
	End

RETURN;
END;
GO