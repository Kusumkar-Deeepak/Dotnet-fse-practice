USE RetailStore;
GO

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE
);

INSERT INTO Customers VALUES
(1,'Deepak','West'),
(2,'Rahul','North'),
(3,'Priya','South'),
(4,'Anjali','East');

INSERT INTO Orders VALUES
(101,1,'2025-01-10'),
(102,2,'2025-01-15'),
(103,3,'2025-02-01'),
(104,1,'2025-02-05'),
(105,4,'2025-03-01');