USE RetailStore;
GO

-- Show all data

SELECT *
FROM Orders
ORDER BY OrderDate;

-- Show existing indexes

EXEC sp_helpindex 'Orders';