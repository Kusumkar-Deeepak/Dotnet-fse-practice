USE RetailStore;
GO

EXEC sp_GetEmployeesByDepartment
    @DepartmentID = 1;