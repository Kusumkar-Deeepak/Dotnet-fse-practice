USE RetailStore;
GO

SELECT *
FROM Products
WHERE ProductName = 'iPhone 15';

CREATE NONCLUSTERED INDEX IX_ProductName
ON Products(ProductName);

SELECT *
FROM Products
WHERE ProductName = 'iPhone 15';