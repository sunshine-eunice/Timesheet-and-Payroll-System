USE [db_Payroll]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertMasterEmployee]    Script Date: 30/08/2016 10:54:54 AM ******/

-- =============================================
-- Author:		Shine
-- Create date: 08/19/2016
-- Description:	add employee 
-- =============================================
CREATE PROCEDURE [dbo].[SPInsertMasterEmployee]
	@EmpID varchar(50),
	@EmpFName varchar(50),
	@EmpMName varchar(50),
	@EmpLName varchar(50),
	@EmpSuffix varchar(8),
	@birthdate date,
	@CivilStatus varchar(20),
	@Nationality varchar(20),
	@sex varchar(6),
	@EmpSSS varchar(50),
	@EmpPhilhealthID varchar(50),
	@EmpTIN varchar(50),
	@EmpPagibigID varchar(50),
	@HealthInsType varchar(5),
	@HealthINSCd varchar(10),
	@HealthINSName nvarchar(100),
	@HealthInsID nvarchar(100), 
	@withchild bit,
	@idNo int out

AS
DECLARE @inserr int
DECLARE @maxerr int

SET @maxerr = 0

BEGIN TRANSACTION
	INSERT INTO [EmployeeMaster](EmployeeID, EmpFName, EmpMName, EmpLName, EmpSuffix, birthdate, CivilStatus, Nationality, sex, EmpSSS, EmpPhilhealthID, EmpTIN, EmpPagibigID, HealthInsType, HealthINSName, HealthInsID, withchild)
	VALUES(@EmpID,@EmpFName,@EmpMName,@EmpLName,@EmpSuffix,@birthdate,@CivilStatus,@Nationality,@sex,@EmpSSS,@EmpPhilhealthID,@EmpTIN,@EmpPagibigID,@HealthInsType,@HealthINSName,@HealthInsID,@withchild)

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
