USE RetailStore;
GO

SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2025-01-10';

CREATE NONCLUSTERED INDEX IX_Customer_Order
ON Orders(CustomerID, OrderDate);

SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2025-01-10';