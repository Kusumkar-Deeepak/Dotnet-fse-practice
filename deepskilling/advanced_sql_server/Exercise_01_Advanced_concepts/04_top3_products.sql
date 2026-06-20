oUSE RetailStore;

WITH ProductRanking AS
(
    SELECT
        ProductName,
        Category,
        Price,

        ROW_NUMBER()
        OVER(
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum

    FROM Products
)

SELECT *
FROM ProductRanking
WHERE RowNum <= 3;