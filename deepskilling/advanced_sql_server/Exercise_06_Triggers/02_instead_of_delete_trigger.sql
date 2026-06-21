USE RetailStore;
GO

CREATE OR ALTER TRIGGER trg_PreventDelete
ON Employees
INSTEAD OF DELETE
AS
BEGIN

    RAISERROR
    (
        'Employee deletion is not allowed.',
        16,
        1
    );

END;
GO