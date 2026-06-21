SELECT
    EmployeeID,
    FirstName,

    dbo.fn_CalculateAnnualSalary(Salary)
    AS AnnualSalary

FROM Employees;