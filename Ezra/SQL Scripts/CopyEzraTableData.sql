Use EzraTest
Go
delete from EzraTest.dbo.CKCUChecking

DBCC CHECKIDENT ('[CKCUChecking]', RESEED, 0)

Insert Into EzraTest.dbo.CKCUChecking (ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID, ChkVendID,
ChkDepNo, ChkBanTransNo, ChkDepImage)
Select ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, NewCatID, ChkVendID, ChkDepNo, ChkBanTransNo,
ChkDepImage
from Ezra.dbo.CKCUChecking
order by ChkDate, ChkID

Go

delete from EzraTest.dbo.Balances

DBCC CHECKIDENT ('[Balances]', RESEED, 0)

Insert Into EzraTest.dbo.Balances (balType, balAccount, balCatID, balAmt, balMonth, balYear)
Select balType, balAccount, balCatID, balAmt, balMonth, balYear
from Ezra.dbo.Balances

Go

delete from EzraTest.dbo.BankTrans

DBCC CHECKIDENT ('[BankTrans]', RESEED, 0)

Insert Into EzraTest.dbo.BankTrans (tranType, tranDate, tranAmt, tranBankID, tranCheckNo, tranName, tranMemo, tranChkID)
Select tranType, tranDate, tranAmt, tranBankID, tranCheckNo, tranName, tranMemo, tranChkID
from Ezra.dbo.BankTrans

Go

delete from EzraTest.dbo.Budget

DBCC CHECKIDENT ('[Budget]', RESEED, 0)

Insert Into EzraTest.dbo.Budget (BudYear, BudGroup, BudAmt)
Select BudYear, BudGroup, BudAmt
from Ezra.dbo.Budget

Go

delete from EzraTest.dbo.Categories

DBCC CHECKIDENT ('[Categories]', RESEED, 0)

Insert Into EzraTest.dbo.Categories (CatName, CatGrpID, CatType, CatPrintOrd)
Select CatName, CatGrpID, CatType, CatPrintOrd
from Ezra.dbo.Categories

Go

delete from EzraTest.dbo.Vendors

DBCC CHECKIDENT ('[Vendors]', RESEED, 0)

Insert Into EzraTest.dbo.Vendors (VendName, VendAddr1, VendAddr2, VendCity, VendState, VendZip, VendContact, VendPhone, VendEMail,
VendCustNo, VendMemo)
Select VendName, VendAddr1, VendAddr2, VendCity, VendState, VendZip, VendContact, VendPhone, VendEMail, VendCustNo, VendMemo
from Ezra.dbo.Vendors

Go

delete from EzraTest.dbo.CKCUSavings

DBCC CHECKIDENT ('[CKCUSavings]', RESEED, 0)

Insert Into EzraTest.dbo.CKCUSavings (savDate, savDesc, savPymt, savDep, savBal, savMemo, savIsDiv)
Select savDate, savDesc, savPymt, savDep, savBal, savMemo, savIsDiv
from Ezra.dbo.CKCUSavings

Go

delete from EzraTest.dbo.Contributions

DBCC CHECKIDENT ('[Contributions]', RESEED, 0)

Insert Into EzraTest.dbo.Contributions (ctrbContribID, ctrbDate, ctrbAmt, ctrbFund, ctrbDepNo)
Select ctrbContribID, ctrbDate, ctrbAmt, ctrbFund, ctrbDepNo
from Ezra.dbo.Contributions

Go

delete from EzraTest.dbo.Contributors

DBCC CHECKIDENT ('[Contributors]', RESEED, 0)

Insert Into EzraTest.dbo.Contributors (cLastName, cFirstName, cMid)
Select cLastName, cFirstName, cMid
from Ezra.dbo.Contributors

Go

delete from EzraTest.dbo.Control

Insert Into EzraTest.dbo.Control (ctrlCurYear)
Select ctrlCurYear
from Ezra.dbo.Control

Go

delete from EzraTest.dbo.CreditCard

DBCC CHECKIDENT ('[CreditCard]', RESEED, 0)

Insert Into EzraTest.dbo.CreditCard (ccDate, ccDesc, ccVendID, ccCharged, ccPymt, ccBal, ccCat, ccCatID, ccFund, ccStatementDate,
 ccChargedBy, ccNotes)
Select ccDate, ccDesc, ccVendID, ccCharged, ccPymt, ccBal, ccCat, ccCatID, ccFund, [ccStatement Date], [ccCharged By], ccNotes
from Ezra.dbo.CreditCard

Go

delete from EzraTest.dbo.EmployeePayDates

DBCC CHECKIDENT ('[EmployeePayDates]', RESEED, 0)

Insert Into EzraTest.dbo.EmployeePayDates (EmplID, EmplPDID, ChkID, PayDate, GrossPayAmount, NetPayAmount, FedWHAmount, 
StateWHAmount, HousingAllowance, TaxablePayAmount, BankTransNo)
Select EmplID, EmplPDID, ChkID, PayDate, GrossPayAmount, NetPayAmount, FedWHAmount, StateWHAmount, HousingAllowance, 
TaxablePayAmount, BankTransNo
from Ezra.dbo.EmployeePayDates

Go

delete from EzraTest.dbo.EmployeePayDed

DBCC CHECKIDENT ('[EmployeePayDed]', RESEED, 0)

Insert Into EzraTest.dbo.EmployeePayDed (EmplID, EffectiveDate, PayFrequency, GrossPayAmount, FedWHStatus, FedWHExemptNo,
FedWHAmount, StateWHStatus, StateWHExemptNo, StateWHAmount, NetPayAmount, HousingAllow, TaxablePayAmount)
Select EmplID, EffectiveDate, PayFrequency, GrossPayAmount, FedWHStatus, FedWHExemptNo,
FedWHAmount, StateWHStatus, StateWHExemptNo, StateWHAmount, NetPayAmount, HousingAllow, TaxablePayAmount
from Ezra.dbo.EmployeePayDed

Go

delete from EzraTest.dbo.Employees

DBCC CHECKIDENT ('[Employees]', RESEED, 0)

Insert Into EzraTest.dbo.Employees (LastName, FirstName, Middle, Address1, Address2, City, [State], Zip, SSN)
Select LastName, FirstName, Middle, Address1, Address2, City, [State], Zip, SSN
from Ezra.dbo.Employees

Go

delete from EzraTest.dbo.Funds

DBCC CHECKIDENT ('[Funds]', RESEED, 0)

Insert Into EzraTest.dbo.Funds (fundName, fundActive, fundSpecial, fundAllocat, fundLiab, fundDonations)
Select fundName, fundActive, fundSpecial, fundAllocat, fundLiab, fundDonations
from Ezra.dbo.Funds

Go

delete from EzraTest.dbo.FundTransactions

DBCC CHECKIDENT ('[FundTransactions]', RESEED, 0)

Insert Into EzraTest.dbo.FundTransactions (ftFundID, ftDate, ftDesc, ftPay, ftDep, ftBal, ftMemo)
Select ftFundID, ftDate, ftDesc, ftPay, ftDep, ftBal, ftMemo
from Ezra.dbo.FundTransactions

Go

delete from EzraTest.dbo.Groups

DBCC CHECKIDENT ('[Groups]', RESEED, 0)

Insert Into EzraTest.dbo.Groups (grpName, grpPrintOrd, grpType, grpBudOrder)
Select grpName, grpPrintOrd, grpType, grpBudOrder
from Ezra.dbo.Groups

Go

delete from EzraTest.dbo.PeoplesChecking

DBCC CHECKIDENT ('[PeoplesChecking]', RESEED, 0)

Insert Into EzraTest.dbo.PeoplesChecking (ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID)
Select ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID
from Ezra.dbo.PeoplesChecking

Go

delete from EzraTest.dbo.[Type]

DBCC CHECKIDENT ('[Type]', RESEED, 0)

Insert Into EzraTest.dbo.[Type] (TypeDesc)
Select TypeDesc
from Ezra.dbo.[Type]

Go
