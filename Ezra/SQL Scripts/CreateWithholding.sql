USE Ezra;
GO
IF OBJECT_ID(N'dbo.tvfGetWithholding', N'TF') IS NOT NULL
    DROP FUNCTION dbo.tvfGetWithholding;
GO
CREATE FUNCTION dbo.tvfGetWithholding(@begDate datetime, @endDate dateTime, @fundId int)
RETURNS @retWHNumbers TABLE 
(
    -- Columns returned by the function
    FtFundId int PRIMARY KEY NOT NULL,
	DepAmount decimal(12,2),
	PmtAmount decimal(12,2),
	DepAmtYTD decimal(12,2),
	PmtAmtYTD decimal(12,2)
)
Begin
	Declare
	@FtFundId int,
	@DepAmount decimal(12,2),
	@PmtAmount decimal(12,2),
	@DepAmtYTD decimal(12,2),
	@PmtAmtYTD decimal(12,2),
	@begOfYear datetime = DateFromParts(Year(@begDate), 1, 1)

	Set @FtFundId = @fundId
	Begin
		Select @FtFundId = @fundId,
		@DepAmount = (Select IsNull(Sum(ftDep),0) from FundTransactions where ftFundID = @FtFundId and ftDate >= @begDate and ftDate <= @endDate
			and ftDesc <> 'Beginning Balance'),
		@PmtAmount = (Select IsNull(Sum(ftPay),0) from FundTransactions where ftFundID = @FtFundId and ftDate >= @begDate and ftDate <= @endDate
			and ftDesc <> 'Beginning Balance'),
		@DepAmtYTD = (Select IsNull(Sum(ftDep),0) from FundTransactions where ftFundID = @FtFundId and ftDate >= @begOfYear and ftDate <= @endDate
			and ftDesc <> 'Beginning Balance'),
		@PmtAmtYTD = (Select IsNull(Sum(ftPay),0) from FundTransactions where ftFundID = @FtFundId and ftDate >= @begOfYear and ftDate <= @endDate
			and ftDesc <> 'Beginning Balance')
		from FundTransactions 

		Begin
			Insert @retWHNumbers
			Select @FtFundId, @DepAmount, @PmtAmount, @DepAmtYTD, @PmtAmtYTD;
		End;
	End

RETURN;
END;