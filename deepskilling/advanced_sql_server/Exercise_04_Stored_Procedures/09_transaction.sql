USE RetailStore;
GO

CREATE PROCEDURE sp_UpdateSalaryTransaction
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN

    BEGIN TRANSACTION;

    UPDATE Employees
    SET Salary = @Salary
    WHERE EmployeeID = @EmployeeID;

    COMMIT TRANSACTION;

END;
GO