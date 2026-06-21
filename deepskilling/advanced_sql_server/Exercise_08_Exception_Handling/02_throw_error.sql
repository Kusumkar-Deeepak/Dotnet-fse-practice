USE RetailStore;
GO

ALTER PROCEDURE AddEmployee
(
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2),
    @DepartmentID INT
)
AS
BEGIN

    BEGIN TRY

        INSERT INTO Employees
        VALUES
        (
            @EmployeeID,
            @FirstName,
            @LastName,
            @DepartmentID,
            @Salary,
            GETDATE(),
            @Email
        );

    END TRY

    BEGIN CATCH

        INSERT INTO AuditLog
        (
            Action,
            ErrorMessage
        )
        VALUES
        (
            'Add Employee',
            ERROR_MESSAGE()
        );

        THROW;

    END CATCH

END;
GO