USE RetailStore;
GO

SELECT
    EmployeeID,
    FirstName,
    Salary,
    dbo.fn_AnnualSalary(Salary) AS AnnualSalary
FROM Employees;