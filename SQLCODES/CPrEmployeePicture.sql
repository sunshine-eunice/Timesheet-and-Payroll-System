USE [db_Payroll];
GO

CREATE PROCEDURE [dbo].[SPInsertEmpParents]
@EmployeeID varchar(50),
@EmpFatherLName varchar(50),
@EmpFatherMName varchar(50),
@EmpFatherFName varchar(50),
@EmpFatherSuffix varchar(8),
@EmpMotherMaidLName varchar(50),
@EmpMotherMaidMName varchar(50),
@EmpMotherFName varchar(50),
@idNo int out

AS
DECLARE @inserr int
DECLARE @maxerr int

SET @maxerr = 0

BEGIN TRANSACTION
INSERT INTO [EmployeeParents](EmployeeID,EmpFatherLName,EmpFatherMName,EmpFatherFName,EmpFatherSuffix,EmpMotherMaidLName,EmpMotherMaidMName,EmpMotherFName)
VALUES (@EmployeeID,@EmpFatherLName,@EmpFatherMName,@EmpFatherFName,@EmpFatherSuffix,@EmpMotherMaidLName,@EmpMotherMaidMName,@EmpMotherFName)
SET @inserr=@@ERROR
	if @inserr > @maxerr
		set @maxerr = @inserr
			if @maxerr <> 0 
				BEGIN
				ROLLBACK 
				END
			ELSE
				BEGIN
				COMMIT
				SELECT @idNo = SCOPE_IDENTITY();
END
