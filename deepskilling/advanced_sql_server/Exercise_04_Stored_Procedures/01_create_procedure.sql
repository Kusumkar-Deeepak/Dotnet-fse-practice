USE RetailStore;
GO

DROP PROCEDURE IF EXISTS sp_GetEmployeesByDepartment;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO