USE [db_Payroll];
GO
-- =============================================
-- Author:		Shine
-- Create date: 08/30/2016
-- Description:	Adding ID with Increment 
-- =============================================
CREATE PROCEDURE [dbo].[AutoIncrementIDs]
	@CmpCode char(3),
	@CmpGrpCd varchar(2),
	@CmpBranchcode varchar(3),
	@idNo int out
AS
DECLARE @inserr int
DECLARE @maxerr int

SET @maxerr = 0
BEGIN TRANSACTION
	

    INSERT INTO [CompanyIDTable]()
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
