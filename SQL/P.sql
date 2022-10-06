-- Print Prime Numbers

declare @end int
declare @start int
declare @a int
declare @b int
DECLARE @print varchar(1000)=''
set @start = 2
set @end = 1000
set @b = 1
while @start < @end
begin
set @a = 2
    while @a < @start
        begin
            If @start % @a > 0
                begin
                set @b=1
                set @a = @a +1
                end
            Else
                begin
                set @b=0
                Break
                end
        end
    If @b =1
        begin
            if @start <> 997
            begin
            SET @print+= CAST(@start AS VARCHAR(10));
            SET @print+='&';
            end
            
            else
            begin
            SET @print+= CAST(@start AS VARCHAR(10));
            end
        
        set @start = @start +1
        end
    else
        begin
        set @start = @start +1
        continue
        end
end
Print @print
