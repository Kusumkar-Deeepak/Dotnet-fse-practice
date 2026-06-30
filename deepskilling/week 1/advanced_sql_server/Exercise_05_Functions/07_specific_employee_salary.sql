USE RetailStore;
GO

SELECT
    EmployeeID,
    FirstName,
    Salary AS MonthlySalary,
    dbo.fn_AnnualSalary(Salary) AS AnnualSalary
FROM Employees
WHERE EmployeeID = 101;