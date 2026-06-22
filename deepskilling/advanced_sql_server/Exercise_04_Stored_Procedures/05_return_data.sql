USE RetailStore;
GO

DROP PROCEDURE IF EXISTS sp_CountEmployees;
GO

CREATE PROCEDURE sp_CountEmployees
    @DepartmentID INT
AS
BEGIN
    SELECT
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

USE RetailStore;
GO

EXEC sp_CountEmployees
    @DepartmentID = 2;