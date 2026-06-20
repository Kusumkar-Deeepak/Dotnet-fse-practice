USE RetailStore;
GO

CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments VALUES
(1,'IT'),
(2,'HR'),
(3,'Finance'),
(4,'Marketing');

INSERT INTO Employees VALUES
(101,'Deepak','Kusumkar',1,50000,'2024-01-10'),
(102,'Rahul','Sharma',2,45000,'2023-06-15'),
(103,'Priya','Patil',3,60000,'2022-08-20'),
(104,'Anjali','Jadhav',4,55000,'2024-03-01');