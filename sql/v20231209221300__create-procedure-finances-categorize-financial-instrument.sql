CREATE OR ALTER PROCEDURE finances.CategorizeFinancialInstrument
    @InstrumentId INT,
    @MarketValue DECIMAL,
    @Type NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @Category NVARCHAR(50);

    IF @MarketValue < 1000000
        SET @Category = 'Low Value';
    ELSE IF @MarketValue <= 5000000
        SET @Category = 'Medium Value';
    ELSE
        SET @Category = 'High Value';

    BEGIN TRY
        INSERT INTO finances.InstrumentCategories (InstrumentId, Category)
        VALUES (@InstrumentId, @Category);

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
