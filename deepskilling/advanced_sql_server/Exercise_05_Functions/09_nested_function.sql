USE RetailStore;
GO

CREATE OR ALTER FUNCTION fn_CalculateTotalCompensation
(
    @Salary DECIMAL(10,2)
)

RETURNS DECIMAL(10,2)

AS
BEGIN

    DECLARE @AnnualSalary DECIMAL(10,2);

    SET @AnnualSalary =
        dbo.fn_CalculateAnnualSalary(@Salary);

    RETURN
        @AnnualSalary +
        dbo.fn_CalculateBonus(@Salary);

END;
GO