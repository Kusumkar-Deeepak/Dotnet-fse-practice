USE RetailStore;
GO

CREATE VIEW vw_EmployeeAnnualSalary
AS
SELECT
    EmployeeID,
    FirstName,
    Salary,

    Salary * 12
    AS AnnualSalary

FROM Employees;
GO

SELECT * FROM vw_EmployeeAnnualSalary;