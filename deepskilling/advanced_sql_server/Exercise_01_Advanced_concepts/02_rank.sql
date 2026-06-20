USE RetailStore;

SELECT
    ProductName,
    Category,
    Price,

    RANK()
    OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS ProductRank

FROM Products;