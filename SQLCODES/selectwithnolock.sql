USE [db_Payroll];
GO
-- =============================================
-- Author:		SHINE
-- Create date: 08/24/2016
-- Description:	SELECT NATIONALITY (NOLOCKING)
-- =============================================
CREATE PROCEDURE [dbo].[SelectNationality]
	@Nationality nvarchar(50)
AS
BEGIN
	SELECT * FROM [dbo].[NationalTable] WITH(INDEX(byNationality) NOLOCK);
END
GO