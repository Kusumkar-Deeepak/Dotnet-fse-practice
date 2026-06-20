USE RetailStore;
GO

CREATE VIEW vw_EmployeeFullName
AS
SELECT
    EmployeeID,

    FirstName + ' ' + LastName
    AS FullName

FROM Employees;
GO

SELECT * FROM vw_EmployeeFullName;