USE RetailStore;
GO

DROP TABLE IF EXISTS Employees;
GO

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2)
);

INSERT INTO Employees VALUES
(101,'Deepak','Kusumkar',1,30000),
(102,'Rahul','Patil',2,45000),
(103,'Amit','Sharma',2,50000),
(104,'Priya','Joshi',3,55000);
GO