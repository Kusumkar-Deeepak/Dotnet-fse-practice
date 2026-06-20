USE RetailStore;
GO

CREATE PROCEDURE sp_SearchEmployee
    @ColumnName VARCHAR(50),
    @Value VARCHAR(50)
AS
BEGIN

    DECLARE @SQL NVARCHAR(MAX);

    SET @SQL =
    'SELECT * FROM Employees
     WHERE ' + @ColumnName +
     ' = ''' + @Value + '''';

    EXEC(@SQL);

END;
GO