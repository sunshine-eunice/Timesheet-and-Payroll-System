USE db_Payroll;
GO

ALTER TABLE dbo.NationalTable 
ADD CONSTRAINT PK_NationalTable_NationalityCode PRIMARY KEY CLUSTERED (NationalityCode);
GO