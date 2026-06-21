USE RetailStore;
GO

DECLARE
    @EmpID INT,
    @Name VARCHAR(50);

DECLARE ForwardCursor CURSOR FORWARD_ONLY
FOR

SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN ForwardCursor;

FETCH NEXT FROM ForwardCursor
INTO
    @EmpID,
    @Name;

WHILE @@FETCH_STATUS = 0
BEGIN

    PRINT
    CAST(@EmpID AS VARCHAR)
    + ' '
    + @Name;

    FETCH NEXT FROM ForwardCursor
    INTO
        @EmpID,
        @Name;

END;

CLOSE ForwardCursor;

DEALLOCATE ForwardCursor;
GO