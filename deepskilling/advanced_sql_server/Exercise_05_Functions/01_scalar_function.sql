USE RetailStore;
GO

DROP FUNCTION IF EXISTS fn_AnnualSalary;
GO

CREATE FUNCTION fn_AnnualSalary
(
    @MonthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @MonthlySalary * 12;
END;
GO