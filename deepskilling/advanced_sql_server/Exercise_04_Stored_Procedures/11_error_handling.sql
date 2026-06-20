USE RetailStore;
GO

CREATE PROCEDURE sp_UpdateSalarySafe
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN

    BEGIN TRY

        UPDATE Employees
        SET Salary = @Salary
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Salary Updated Successfully';

    END TRY

    BEGIN CATCH

        PRINT 'Error Occurred';

    END CATCH

END;
GO