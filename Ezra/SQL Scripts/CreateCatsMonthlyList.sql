USE Ezra
IF OBJECT_ID (N'dbo.tvf_CatsMonthlyList', N'IF') IS NOT NULL  
    DROP FUNCTION dbo.tvf_CatsMonthlyList;  
GO
CREATE FUNCTION dbo.tvf_CatsMonthlyList()  
RETURNS TABLE  
AS  
RETURN
(
	SELECT cats.CatID, cats.CatName, cats.CatGrpID, grp.grpName, cats.CatType, typ.TypeDesc, cats.CatPrintOrd, grp.grpPrintOrd, 
	grp.grpBudOrder FROM Categories cats
	JOIN Groups grp ON grp.grpID = cats.CatGrpID
	JOIN dbo.Type typ ON typ.TypeID = cats.CatType
	WHERE cats.CatPrintOrd IS NOT NULL
); 
GO  

