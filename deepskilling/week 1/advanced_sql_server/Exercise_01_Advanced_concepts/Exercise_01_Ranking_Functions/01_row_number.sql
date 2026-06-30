USE RetailStore;

SELECT
    ProductName,
    Category,
    Price,

    ROW_NUMBER()
    OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber

FROM Products;