-- Draw The Triangle 1

DECLARE @i INT = 20 
WHILE @i > 0
BEGIN 
    DECLARE @s VARCHAR(255) = '' 
    DECLARE @c INT = @i 
    WHILE @c > 0 
    BEGIN 
        SET @s +='* ' 
        SET @c = @c-1
    END 
    PRINT @s 
    SET @i = @i - 1 
END;
