CREATE DATABASE RetailStore;
GO

USE RetailStore;
GO

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(1,'iPhone 15','Mobile',80000),
(2,'Samsung S24','Mobile',75000),
(3,'OnePlus 13','Mobile',65000),

(4,'MacBook Air','Laptop',110000),
(5,'Dell XPS','Laptop',95000),
(6,'HP Spectre','Laptop',95000),

(7,'Sony Headphones','Accessories',8000),
(8,'JBL Speaker','Accessories',5000),
(9,'Boat Airdopes','Accessories',1500);