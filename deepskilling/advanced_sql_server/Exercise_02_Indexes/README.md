# Exercise 02 - Indexes

## Sub Exercises

1. Non-Clustered Index
2. Clustered Index
3. Composite Index

## Non-Clustered Index

Created on ProductName column.

Query:

CREATE NONCLUSTERED INDEX IX_ProductName
ON Products(ProductName);

Benefit:
Faster searching of products.

---

## Clustered Index

Orders table already contains a clustered index because OrderID is a Primary Key.

Verified using:

EXEC sp_helpindex 'Orders';

Benefit:
Physically organizes table data.

---

## Composite Index

Created on:

CustomerID
OrderDate

Query:

CREATE NONCLUSTERED INDEX IX_Customer_Order
ON Orders(CustomerID, OrderDate);

Benefit:
Faster searching using both columns together.