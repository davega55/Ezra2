USE [EzraTest]

IF OBJECT_ID (N'dbo.CKCUChecking', N'U') IS NOT NULL  
    DROP TABLE dbo.CKCUChecking;  
GO

/****** Object:  Table [dbo].[CKCUChecking]    Script Date: 8/16/2017 12:21:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CKCUChecking](
	[ChkID] [int] IDENTITY(1,1) NOT NULL,
	[ChkDate] [datetime] NULL,
	[ChkNo] [nvarchar](20) NULL,
	[ChkDesc] [nvarchar](30) NULL,
	[ChkPymt] [money] NULL,
	[ChkDep] [money] NULL,
	[ChkBalance] [money] NULL,
	[ChkCat] [nvarchar](25) NULL,
	[ChkRec] [bit] NULL,
	[ChkMemo] [nvarchar](150) NULL,
	[newCatID] [int] NULL,
	[ChkVendID] [int] NULL,
	[ChkDepNo] [smallint] NULL,
	[ChkBanTransNo] [nvarchar](100) NULL,
	[ChkDepImage] [ntext] NULL,
 CONSTRAINT [PK_CKCUChecking] PRIMARY KEY CLUSTERED 
(
	[ChkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Balances', N'U') IS NOT NULL  
    DROP TABLE dbo.Balances;  
GO

CREATE TABLE [dbo].[Balances](
	[balID] [int] IDENTITY(1,1) NOT NULL,
	[balType] [nvarchar](30) NULL,
	[balAccount] [nvarchar](30) NULL,
	[balCatID] [int] NULL,
	[balAmt] [money] NULL,
	[balMonth] [smallint] NULL,
	[balYear] [smallint] NULL,
 CONSTRAINT [PK_Balances] PRIMARY KEY CLUSTERED 
(
	[balID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.BankTrans', N'U') IS NOT NULL  
    DROP TABLE dbo.BankTrans;  
GO

CREATE TABLE [dbo].[BankTrans](
	[tranNo] [int] IDENTITY(1,1) NOT NULL,
	[tranType] [nvarchar](10) NULL,
	[tranDate] [datetime] NULL,
	[tranAmt] [money] NULL,
	[tranBankID] [nvarchar](100) NULL,
	[tranCheckNo] [nvarchar](15) NULL,
	[tranName] [nvarchar](50) NULL,
	[tranMemo] [nvarchar](100) NULL,
	[tranChkID] [int] NULL,
 CONSTRAINT [PK_BankTrans] PRIMARY KEY CLUSTERED 
(
	[tranNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Budget', N'U') IS NOT NULL  
    DROP TABLE dbo.Budget;  
GO

CREATE TABLE [dbo].[Budget](
	[BudID] [int] IDENTITY(1,1) NOT NULL,
	[BudYear] [nvarchar](4) NULL,
	[BudGroup] [int] NULL,
	[BudAmt] [money] NULL,
 CONSTRAINT [PK_Budget] PRIMARY KEY CLUSTERED 
(
	[BudID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Categories', N'U') IS NOT NULL  
    DROP TABLE dbo.Categories;  
GO

CREATE TABLE [dbo].[Categories](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](40) NULL,
	[CatGrpID] [int] NULL,
	[CatType] [int] NULL,
	[CatPrintOrd] [smallint] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Vendors', N'U') IS NOT NULL  
    DROP TABLE dbo.Vendors;  
GO

CREATE TABLE [dbo].[Vendors](
	[VendID] [int] IDENTITY(1,1) NOT NULL,
	[VendName] [nvarchar](50) NULL,
	[VendAddr1] [nvarchar](30) NULL,
	[VendAddr2] [nvarchar](30) NULL,
	[VendCity] [nvarchar](25) NULL,
	[VendState] [nvarchar](10) NULL,
	[VendZip] [nvarchar](10) NULL,
	[VendContact] [nvarchar](50) NULL,
	[VendPhone] [nvarchar](15) NULL,
	[VendEMail] [nvarchar](50) NULL,
	[VendCustNo] [nvarchar](20) NULL,
	[VendMemo] [ntext] NULL,
 CONSTRAINT [PK_Vendors] PRIMARY KEY CLUSTERED 
(
	[VendID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.CKCUSavings', N'U') IS NOT NULL  
    DROP TABLE dbo.CKCUSavings;  
GO

CREATE TABLE [dbo].[CKCUSavings](
	[savID] [int] IDENTITY(1,1) NOT NULL,
	[savDate] [datetime] NULL,
	[savDesc] [nvarchar](50) NULL,
	[savPymt] [money] NULL,
	[savDep] [money] NULL,
	[savBal] [money] NULL,
	[savMemo] [nvarchar](255) NULL,
	[savIsDiv] [bit] NULL,
 CONSTRAINT [PK_CKCUSavings] PRIMARY KEY CLUSTERED 
(
	[savID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Contributions', N'U') IS NOT NULL  
    DROP TABLE dbo.Contributions;  
GO

CREATE TABLE [dbo].[Contributions](
	[ctrbID] [int] IDENTITY(1,1) NOT NULL,
	[ctrbContribID] [int] NULL,
	[ctrbDate] [datetime] NULL,
	[ctrbAmt] [money] NULL,
	[ctrbFund] [int] NULL,
	[ctrbDepNo] [smallint] NULL,
 CONSTRAINT [PK_Contributions] PRIMARY KEY CLUSTERED 
(
	[ctrbID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Contributors', N'U') IS NOT NULL  
    DROP TABLE dbo.Contributors;  
GO

CREATE TABLE [dbo].[Contributors](
	[cID] [int] IDENTITY(1,1) NOT NULL,
	[cLastName] [nvarchar](40) NULL,
	[cFirstName] [nvarchar](30) NULL,
	[cMid] [nvarchar](20) NULL,
	[cBusinessName] [nvarchar](50) NULL,
	[cSalutation] [nvarchar](75) NULL,
	[cLastName2] [nvarchar](40) NULL,
	[cFirstName2] [nvarchar](30) NULL,
	[cMid2] [nvarchar](20) NULL,
	[cAddress] [nvarchar](40) NULL,
	[cAddress2] [nvarchar](40) NULL,
	[cCity] [nvarchar](30) NULL,
	[cState] [nvarchar](10) NULL,
	[cZip] [nvarchar](10) NULL,
	[cPhone] [nvarchar](15) NULL,
	[cPhone2] [nvarchar](15) NULL,
	[cEMail] [nvarchar](50) NULL,
	[cEMail2] [nvarchar](50) NULL,
	[cMemo] [nvarchar](150) NULL,
	[cUseBusiness] [bit] NULL,
	[cLabel] [bit] NULL,
 CONSTRAINT [PK_Contributors] PRIMARY KEY CLUSTERED 
(
	[cID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Control', N'U') IS NOT NULL  
    DROP TABLE dbo.Control;  
GO

CREATE TABLE [dbo].[Control](
	[ctrlCurYear] [smallint] NULL
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.CreditCard', N'U') IS NOT NULL  
    DROP TABLE dbo.CreditCard;  
GO

CREATE TABLE [dbo].[CreditCard](
	[ccID] [int] IDENTITY(1,1) NOT NULL,
	[ccDate] [datetime] NULL,
	[ccDesc] [nvarchar](255) NULL,
	[ccVendID] [int] NULL,
	[ccCharged] [money] NULL,
	[ccPymt] [money] NULL,
	[ccBal] [money] NULL,
	[ccCat] [nvarchar](255) NULL,
	[ccCatID] [int] NULL,
	[ccFund] [int] NULL,
	[ccStatementDate] [datetime] NULL,
	[ccChargedBy] [nvarchar](255) NULL,
	[ccNotes] [nvarchar](255) NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[ccID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.EmployeePayDates', N'U') IS NOT NULL  
    DROP TABLE dbo.EmployeePayDates;  
GO

CREATE TABLE [dbo].[EmployeePayDates](
	[PayID] [int] IDENTITY(1,1) NOT NULL,
	[EmplID] [int] NULL,
	[EmplPDID] [int] NULL,
	[ChkID] [int] NULL,
	[PayDate] [datetime] NULL,
	[GrossPayAmount] [decimal](11, 2) NULL,
	[NetPayAmount] [decimal](11, 2) NULL,
	[FedWHAmount] [decimal](11, 2) NULL,
	[StateWHAmount] [decimal](11, 2) NULL,
	[HousingAllowance] [decimal](11, 2) NULL,
	[TaxablePayAmount] [decimal](11, 2) NULL,
	[BankTransNo] [nvarchar](100) NULL,
 CONSTRAINT [PK_EmployeePayDates] PRIMARY KEY CLUSTERED 
(
	[PayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.EmployeePayDed', N'U') IS NOT NULL  
    DROP TABLE dbo.EmployeePayDed;  
GO

CREATE TABLE [dbo].[EmployeePayDed](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmplID] [int] NULL,
	[EffectiveDate] [datetime] NULL,
	[PayFrequency] [nvarchar](10) NULL,
	[GrossPayAmount] [decimal](11, 2) NULL,
	[FedWHStatus] [nvarchar](10) NULL,
	[FedWHExemptNo] [real] NULL,
	[FedWHAmount] [decimal](11, 2) NULL,
	[StateWHStatus] [nvarchar](10) NULL,
	[StateWHExemptNo] [real] NULL,
	[StateWHAmount] [decimal](11, 2) NULL,
	[NetPayAmount] [decimal](11, 2) NULL,
	[HousingAllow] [decimal](11, 2) NULL,
	[TaxablePayAmount] [decimal](11, 2) NULL,
 CONSTRAINT [PK_EmployeePayDed] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Employees', N'U') IS NOT NULL  
    DROP TABLE dbo.Employees;  
GO

CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](30) NULL,
	[FirstName] [nvarchar](30) NULL,
	[Middle] [nvarchar](30) NULL,
	[Address1] [nvarchar](30) NULL,
	[Address2] [nvarchar](30) NULL,
	[City] [nvarchar](25) NULL,
	[State] [nvarchar](2) NULL,
	[Zip] [nvarchar](10) NULL,
	[SSN] [nvarchar](10) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Funds', N'U') IS NOT NULL  
    DROP TABLE dbo.Funds;  
GO

CREATE TABLE [dbo].[Funds](
	[fundID] [int] IDENTITY(1,1) NOT NULL,
	[fundName] [nvarchar](40) NULL,
	[fundActive] [bit] NULL,
	[fundSpecial] [bit] NULL,
	[fundAllocat] [bit] NULL,
	[fundLiab] [bit] NULL,
	[fundDonations] [bit] NULL,
 CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED 
(
	[fundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.FundTransactions', N'U') IS NOT NULL  
    DROP TABLE dbo.FundTransactions;  
GO

CREATE TABLE [dbo].[FundTransactions](
	[ftID] [int] IDENTITY(1,1) NOT NULL,
	[ftFundID] [int] NULL,
	[ftDate] [datetime] NULL,
	[ftDesc] [nvarchar](50) NULL,
	[ftPay] [money] NULL,
	[ftDep] [money] NULL,
	[ftBal] [money] NULL,
	[ftMemo] [nvarchar](255) NULL,
 CONSTRAINT [PK_FundTransactions] PRIMARY KEY CLUSTERED 
(
	[ftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Groups', N'U') IS NOT NULL  
    DROP TABLE dbo.Groups;  
GO

CREATE TABLE [dbo].[Groups](
	[grpID] [int] IDENTITY(1,1) NOT NULL,
	[grpName] [nvarchar](40) NULL,
	[grpPrintOrd] [smallint] NULL,
	[grpType] [int] NULL,
	[grpBudOrder] [smallint] NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[grpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.PeoplesChecking', N'U') IS NOT NULL  
    DROP TABLE dbo.PeoplesChecking;  
GO

CREATE TABLE [dbo].[PeoplesChecking](
	[ChkID] [int] IDENTITY(1,1) NOT NULL,
	[ChkDate] [datetime] NULL,
	[ChkNo] [nvarchar](20) NULL,
	[ChkDesc] [nvarchar](30) NULL,
	[ChkPymt] [money] NULL,
	[ChkDep] [money] NULL,
	[ChkBalance] [money] NULL,
	[ChkCat] [nvarchar](25) NULL,
	[ChkRec] [bit] NULL,
	[ChkMemo] [nvarchar](150) NULL,
	[newCatID] [int] NULL,
 CONSTRAINT [PK_PeoplesChecking] PRIMARY KEY CLUSTERED 
(
	[ChkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF OBJECT_ID (N'dbo.Type', N'U') IS NOT NULL  
    DROP TABLE dbo.Type;  
GO

CREATE TABLE [dbo].[Type](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeDesc] [nvarchar](30) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



