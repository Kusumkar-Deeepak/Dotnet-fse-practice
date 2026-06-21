USE RetailStore;
GO

DECLARE
    @EmpID INT,
    @Name VARCHAR(50);

DECLARE StaticCursor CURSOR STATIC
FOR

SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN StaticCursor;

FETCH NEXT FROM StaticCursor
INTO
    @EmpID,
    @Name;

WHILE @@FETCH_STATUS = 0
BEGIN

    PRINT
    'Employee: '
    + CAST(@EmpID AS VARCHAR)
    + ' '
    + @Name;

    FETCH NEXT FROM StaticCursor
    INTO
        @EmpID,
        @Name;

END;

CLOSE StaticCursor;

DEALLOCATE StaticCursor;
GO