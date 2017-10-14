Use Ezra
Go

-- CKCUChecking
delete from Ezra.dbo.CKCUChecking

DBCC CHECKIDENT ('[CKCUChecking]', RESEED, 0)

Go

Set Identity_Insert CKCUChecking On

Insert Into Ezra.dbo.CKCUChecking (ChkID, ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID, ChkVendID,
ChkDepNo, ChkBanTransNo, ChkDepImage)
Select ChkID, ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, NewCatID, ChkVendID, ChkDepNo, ChkBanTransNo,
ChkDepImage
from Ezra081517.dbo.CKCUChecking

Set Identity_Insert CKCUChecking Off

Go

-- Balances
delete from Ezra.dbo.Balances

DBCC CHECKIDENT ('[Balances]', RESEED, 0)

Go

Set Identity_Insert Balances On

Insert Into Ezra.dbo.Balances (balID, balType, balAccount, balCatID, balAmt, balMonth, balYear)
Select balID, balType, balAccount, balCatID, balAmt, balMonth, balYear
from Ezra081517.dbo.Balances

Set Identity_Insert Balances Off

Go

-- BankTrans
delete from Ezra.dbo.BankTrans

DBCC CHECKIDENT ('[BankTrans]', RESEED, 0)

Go

Set Identity_Insert BankTrans On

Insert Into Ezra.dbo.BankTrans (tranNo, tranType, tranDate, tranAmt, tranBankID, tranCheckNo, tranName, tranMemo, tranChkID)
Select tranNo, tranType, tranDate, tranAmt, tranBankID, tranCheckNo, tranName, tranMemo, tranChkID
from Ezra081517.dbo.BankTrans

Set Identity_Insert BankTrans Off

Go

-- Budget
delete from Ezra.dbo.Budget

DBCC CHECKIDENT ('[Budget]', RESEED, 0)

Go

Set Identity_Insert Budget On

Insert Into Ezra.dbo.Budget (BudID, BudYear, BudGroup, BudAmt)
Select BudID, BudYear, BudGroup, BudAmt
from Ezra081517.dbo.Budget

Set Identity_Insert Budget Off

Go

-- Categories
delete from Ezra.dbo.Categories

DBCC CHECKIDENT ('[Categories]', RESEED, 0)

Go

Set Identity_Insert Categories On

Insert Into Ezra.dbo.Categories (CatID, CatName, CatGrpID, CatType, CatPrintOrd)
Select CatID, CatName, CatGrpID, CatType, CatPrintOrd
from Ezra081517.dbo.Categories

Set Identity_Insert Categories Off

Go

-- Vendors
delete from Ezra.dbo.Vendors

DBCC CHECKIDENT ('[Vendors]', RESEED, 0)

Go

Set Identity_Insert Vendors On

Insert Into Ezra.dbo.Vendors (VendID, VendName, VendAddr1, VendAddr2, VendCity, VendState, VendZip, VendContact, VendPhone, VendEMail,
VendCustNo, VendMemo)
Select VendID, VendName, VendAddr1, VendAddr2, VendCity, VendState, VendZip, VendContact, VendPhone, VendEMail, VendCustNo, VendMemo
from Ezra081517.dbo.Vendors

Set Identity_Insert Vendors Off

Go

-- CKCUSavings
delete from Ezra.dbo.CKCUSavings

DBCC CHECKIDENT ('[CKCUSavings]', RESEED, 0)

Go

Set Identity_Insert CKCUSavings On

Insert Into Ezra.dbo.CKCUSavings (savID, savDate, savDesc, savPymt, savDep, savBal, savMemo, savIsDiv)
Select savID, savDate, savDesc, savPymt, savDep, savBal, savMemo, savIsDiv
from Ezra081517.dbo.CKCUSavings

Set Identity_Insert CKCUSavings Off

Go

-- Contributions
delete from Ezra.dbo.Contributions

DBCC CHECKIDENT ('[Contributions]', RESEED, 0)

Go

Set Identity_Insert Contributions On

Insert Into Ezra.dbo.Contributions (ctrbID, ctrbContribID, ctrbDate, ctrbAmt, ctrbFund, ctrbDepNo)
Select ctrbID, ctrbContribID, ctrbDate, ctrbAmt, ctrbFund, ctrbDepNo
from Ezra081517.dbo.Contributions

Set Identity_Insert Contributions Off

Go

-- Contributors
delete from Ezra.dbo.Contributors

DBCC CHECKIDENT ('[Contributors]', RESEED, 0)

Go

Set Identity_Insert Contributors On

Insert Into Ezra.dbo.Contributors (cID, cLastName, cFirstName, cMid, cBusinessName, cSalutation, cLastName2, cFirstName2, cMid2,
	cAddress, cAddress2, cCity, cState, cZip, cPhone, cPhone2, cEMail, cEMail2, cMemo, cUseBusiness, cLabel)
Select cID, cLastName, cFirstName, cMid, cBusinessName, cSalutation, cLastName2, cFirstName2, cMid2, cAddress, cAddress2, cCity, cState,
	cZip, cPhone, cPhone2, cEMail, cEMail2, cMemo, cUseBusiness, cLabel
from Ezra081517.dbo.Contributors

Set Identity_Insert Contributors Off

Go

-- Control
delete from Ezra.dbo.Control

Insert Into Ezra.dbo.Control (ctrlCurYear)
Select ctrlCurYear
from Ezra081517.dbo.Control

Go

-- CreditCard
delete from Ezra.dbo.CreditCard

DBCC CHECKIDENT ('[CreditCard]', RESEED, 0)

Go

Set Identity_Insert CreditCard On

Insert Into Ezra.dbo.CreditCard (ccID, ccDate, ccDesc, ccVendID, ccCharged, ccPymt, ccBal, ccCat, ccCatID, ccFund, ccStatementDate,
 ccChargedBy, ccNotes)
Select ccID, ccDate, ccDesc, ccVendID, ccCharged, ccPymt, ccBal, ccCat, ccCatID, ccFund, [ccStatement Date], [ccCharged By], ccNotes
from Ezra081517.dbo.CreditCard

Set Identity_Insert CreditCard Off

Go

-- EmployeePayDates
delete from Ezra.dbo.EmployeePayDates

DBCC CHECKIDENT ('[EmployeePayDates]', RESEED, 0)

Go

Set Identity_Insert EmployeePayDates On

Insert Into Ezra.dbo.EmployeePayDates (PayID, EmplID, EmplPDID, ChkID, PayDate, GrossPayAmount, NetPayAmount, FedWHAmount, 
StateWHAmount, HousingAllowance, TaxablePayAmount, BankTransNo)
Select PayID, EmplID, EmplPDID, ChkID, PayDate, GrossPayAmount, NetPayAmount, FedWHAmount, StateWHAmount, HousingAllowance, 
TaxablePayAmount, BankTransNo
from Ezra081517.dbo.EmployeePayDates

Set Identity_Insert EmployeePayDates Off

Go

-- EmployeePayDed
delete from Ezra.dbo.EmployeePayDed

DBCC CHECKIDENT ('[EmployeePayDed]', RESEED, 0)

Go

Set Identity_Insert EmployeePayDed On

Insert Into Ezra.dbo.EmployeePayDed (ID, EmplID, EffectiveDate, PayFrequency, GrossPayAmount, FedWHStatus, FedWHExemptNo,
FedWHAmount, StateWHStatus, StateWHExemptNo, StateWHAmount, NetPayAmount, HousingAllow, TaxablePayAmount)
Select ID, EmplID, EffectiveDate, PayFrequency, GrossPayAmount, FedWHStatus, FedWHExemptNo,
FedWHAmount, StateWHStatus, StateWHExemptNo, StateWHAmount, NetPayAmount, HousingAllow, TaxablePayAmount
from Ezra081517.dbo.EmployeePayDed

Set Identity_Insert EmployeePayDed Off

Go

-- Employees
delete from Ezra.dbo.Employees

DBCC CHECKIDENT ('[Employees]', RESEED, 0)

Go

Set Identity_Insert Employees On

Insert Into Ezra.dbo.Employees (ID, LastName, FirstName, Middle, Address1, Address2, City, [State], Zip, SSN)
Select ID, LastName, FirstName, Middle, Address1, Address2, City, [State], Zip, SSN
from Ezra081517.dbo.Employees

Set Identity_Insert Employees Off

Go

-- Funds
delete from Ezra.dbo.Funds

DBCC CHECKIDENT ('[Funds]', RESEED, 0)

Go

Set Identity_Insert Funds On

Insert Into Ezra.dbo.Funds (fundID, fundName, fundActive, fundSpecial, fundAllocat, fundLiab, fundDonations)
Select fundID, fundName, fundActive, fundSpecial, fundAllocat, fundLiab, fundDonations
from Ezra081517.dbo.Funds

Set Identity_Insert Funds Off

Go

-- FundTransactions
delete from Ezra.dbo.FundTransactions

DBCC CHECKIDENT ('[FundTransactions]', RESEED, 0)

Go

Set Identity_Insert FundTransactions On

Insert Into Ezra.dbo.FundTransactions (ftID, ftFundID, ftDate, ftDesc, ftPay, ftDep, ftBal, ftMemo)
Select ftID, ftFundID, ftDate, ftDesc, ftPay, ftDep, ftBal, ftMemo
from Ezra081517.dbo.FundTransactions

Set Identity_Insert FundTransactions Off

Go

-- Groups
delete from Ezra.dbo.Groups

DBCC CHECKIDENT ('[Groups]', RESEED, 0)

Go

Set Identity_Insert Groups On

Insert Into Ezra.dbo.Groups (grpID, grpName, grpPrintOrd, grpType, grpBudOrder)
Select grpID, grpName, grpPrintOrd, grpType, grpBudOrder
from Ezra081517.dbo.Groups

Set Identity_Insert Groups Off

Go

-- PeoplesChecking
delete from Ezra.dbo.PeoplesChecking

DBCC CHECKIDENT ('[PeoplesChecking]', RESEED, 0)

Go

Set Identity_Insert PeoplesChecking On

Insert Into Ezra.dbo.PeoplesChecking (ChkID, ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID)
Select ChkID, ChkDate, ChkNo, ChkDesc, ChkPymt, ChkDep, ChkBalance, ChkCat, ChkRec, ChkMemo, newCatID
from Ezra081517.dbo.PeoplesChecking

Set Identity_Insert PeoplesChecking Off

Go

-- Type
delete from Ezra.dbo.[Type]

DBCC CHECKIDENT ('[Type]', RESEED, 0)

Go

Set Identity_Insert [Type] On

Insert Into Ezra.dbo.[Type] (TypeID, TypeDesc)
Select TypeID, TypeDesc
from Ezra081517.dbo.[Type]

Set Identity_Insert [Type] Off

Go
