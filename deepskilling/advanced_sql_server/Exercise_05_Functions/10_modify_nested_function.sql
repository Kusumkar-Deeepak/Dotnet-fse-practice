SELECT
    EmployeeID,
    FirstName,

    dbo.fn_CalculateTotalCompensation(Salary)
    AS TotalCompensation

FROM Employees;