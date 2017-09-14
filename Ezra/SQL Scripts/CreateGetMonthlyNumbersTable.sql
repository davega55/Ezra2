USE Ezra;
GO
IF OBJECT_ID(N'dbo.tvfGetMonthlyNumbers', N'TF') IS NOT NULL
    DROP FUNCTION dbo.tvfGetMonthlyNumbers;
GO
CREATE FUNCTION dbo.tvfGetMonthlyNumbers(@begDate datetime, @endDate dateTime)
RETURNS @retMonthlyNumbers TABLE 
(
    -- Columns returned by the function
    CatNum int PRIMARY KEY NOT NULL, 
	CatName char(20) NULL,
	CatGrpID int NULL,
	GroupName char(20) NULL,
    AmtType int NULL,
	TypeName char(20) NULL,
	DepAmount decimal(12,2),
	PmtAmount decimal(12,2),
	DepAmtYTD decimal(12,2),
	PmtAmtYTD decimal(12,2)
)
AS
Begin
	Declare
	@CatNum int,
	@CatName char(20),
	@CatGrpID int,
	@GroupName char(20),
	@AmtType int,
	@TypeName char(20),
	@DepAmount decimal(12,2),
	@PmtAmount decimal(12,2),
	@DepAmtYTD decimal(12,2),
	@PmtAmtYTD decimal(12,2),
	@begOfYear datetime = DateFromParts(Year(@begDate), 1, 1)


	Set @CatNum = (select Min(CatID) From Categories Where CatPrintOrd Is Not Null)
	While @CatNum Is Not Null
	Begin
		Select @CatName = cats.CatName, @AmtType = cats.CatType, @CatGrpID = cats.CatGrpID, @GroupName = grp.grpName, @TypeName = typ.TypeDesc,
		@DepAmount = (Select IsNull(Sum(ChkDep),0) from CKCUChecking Where NewCatID = @CatNum And ChkDate >= @begDate And ChkDate <= @endDate), 
		@PmtAmount = (Select IsNull(Sum(ChkPymt),0) from CKCUChecking Where NewCatID = @CatNum and ChkDate >= @begDate And ChkDate <= @endDate),
		@DepAmtYTD = (Select IsNull(Sum(ChkDep),0) from CKCUChecking Where NewCatID = @CatNum And ChkDate >= @begOfYear And ChkDate <= @endDate), 
		@PmtAmtYTD = (Select IsNull(Sum(ChkPymt),0) from CKCUChecking Where NewCatID = @CatNum and ChkDate >= @begOfYear And ChkDate <= @endDate)
		From Categories cats 
		Inner Join Groups grp on cats.CatGrpID = grp.grpID
		Inner Join Type typ on typ.TypeID = cats.CatType
		Where cats.CatID = @CatNum

		Begin
			Insert @retMonthlyNumbers
			Select @CatNum, @CatName, @CatGrpID, @GroupName, @AmtType, @TypeName, @DepAmount, @PmtAmount, @DepAmtYTD, @PmtAmtYTD;
		End;

		Set @CatNum = (select Min(CatID) From Categories 
			Where CatPrintOrd Is Not Null And CatID > @CatNum)
	End

RETURN;
END;