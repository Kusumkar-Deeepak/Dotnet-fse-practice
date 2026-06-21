USE RetailStore;
GO

CREATE OR ALTER PROCEDURE BatchInsertEmployees
AS
BEGIN

    BEGIN TRY

        BEGIN TRANSACTION;

        INSERT INTO Employees
        (
            EmployeeID,
            FirstName,
            LastName
        )
        VALUES
        (
            201,
            'A',
            'User'
        );

        INSERT INTO Employees
        (
            EmployeeID,
            FirstName,
            LastName
        )
        VALUES
        (
            201,
            'Duplicate',
            'User'
        );

        COMMIT TRANSACTION;

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION;

        INSERT INTO AuditLog
        (
            Action,
            ErrorMessage
        )
        VALUES
        (
            'Batch Insert',
            ERROR_MESSAGE()
        );

    END CATCH

END;
GO