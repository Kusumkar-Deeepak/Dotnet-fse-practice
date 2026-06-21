USE RetailStore;
GO

IF NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'Employees'
    AND COLUMN_NAME = 'Email'
)
BEGIN

    ALTER TABLE Employees
    ADD Email VARCHAR(100);

END
GO

IF OBJECT_ID('AuditLog') IS NULL
BEGIN

    CREATE TABLE AuditLog
    (
        LogID INT IDENTITY(1,1) PRIMARY KEY,
        Action VARCHAR(100),
        ErrorMessage VARCHAR(4000),
        ActionDate DATETIME DEFAULT GETDATE()
    );

END
GO

SELECT * FROM Employees;
SELECT * FROM AuditLog;