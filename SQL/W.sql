-- Weather Observation Station 1
Select CITY, STATE From STATION WHERE LAT_N >= 0 AND LONG_W >= 0;

-- Weather Observation Station 3
Select DISTINCT CITY From STATION WHERE ID % 2 = 0;

-- Weather Observation Station 4

Select Count(*) - Count(DISTINCT CITY)  From STATION

-- Weather Observation Station 5

Select TOP 1 CITY AS NAME , LEN(CITY) AS LENG
From STATION
Order BY LEN(CITY), CITY

Select TOP 1 CITY AS NAME , LEN(CITY) AS LENG
From STATION
Order BY LEN(CITY) DESC , CITY

-- Weather Observation Station 6
Select CITY From STATION WHERE 
CITY LIKE 'a%' OR 
CITY LIKE 'e%' OR 
CITY LIKE 'i%' OR 
CITY LIKE 'o%' OR 
CITY LIKE 'u%';

-- OR
SELECT CITY FROM STATION WHERE SUBSTRING(CITY,1,1) IN ('A','E','I','O','U')

-- Weather Observation Station 7

Select DISTINCT CITY From STATION WHERE 
CITY LIKE '%a' OR 
CITY LIKE '%e' OR 
CITY LIKE '%i' OR 
CITY LIKE '%o' OR 
CITY LIKE '%u';

-- Or

SELECT DISTINCT CITY FROM STATION WHERE RIGHT(CITY,1) IN ('A','E','I','O','U')
 
-- OR USING REGEX

SELECT DISTINCT CITY
FROM STATION
WHERE CITY LIKE "%[aeiou]";

-- Weather Observation Station 8

Select DISTINCT CITY FROM STATION WHERE CITY LIKE '[aeiou]%[aeiou]'

-- Weather Observation Station 9

SELECT DISTINCT CITY FROM STATION WHERE CITY LIKE '[^aeiou]%'

-- Weather Observation Station 10

SELECT DISTINCT CITY FROM STATION WHERE CITY LIKE '%[^aeiou]'

-- Weather Observation Station 11

SELECT DISTINCT CITY FROM STATION WHERE CITY LIKE '[^aeiou]%' OR CITY LIKE '%[^aeiou]'

-- Weather Observation Station 12

SELECT DISTINCT CITY FROM STATION WHERE CITY LIKE '[^aeiou]%[^aeiou]'

