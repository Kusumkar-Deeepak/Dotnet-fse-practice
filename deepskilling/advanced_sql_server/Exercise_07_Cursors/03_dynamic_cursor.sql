USE RetailStore;
GO

DECLARE
    @EmpID INT,
    @Name VARCHAR(50);

DECLARE DynamicCursor CURSOR DYNAMIC
FOR

SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN DynamicCursor;

FETCH NEXT FROM DynamicCursor
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

    FETCH NEXT FROM DynamicCursor
    INTO
        @EmpID,
        @Name;

END;

CLOSE DynamicCursor;

DEALLOCATE DynamicCursor;
GO