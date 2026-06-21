USE RetailStore;
GO

CREATE OR ALTER FUNCTION fn_GetEmployeesByDepartment
(
    @DepartmentID INT
)

RETURNS TABLE

AS

RETURN
(
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID
);
GO