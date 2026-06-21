USE RetailStore;
GO

CREATE OR ALTER PROCEDURE CheckSalary
(
    @Salary DECIMAL(10,2)
)
AS
BEGIN

    IF @Salary < 0
    BEGIN

        RAISERROR
        (
            'Negative salary.',
            16,
            1
        );

    END

    ELSE IF @Salary < 1000
    BEGIN

        RAISERROR
        (
            'Salary is very low.',
            10,
            1
        );

    END

    ELSE
    BEGIN

        PRINT 'Salary Accepted';

    END

END;
GO