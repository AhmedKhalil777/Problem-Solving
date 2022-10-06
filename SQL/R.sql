-- Revising the Select Query I

Select * From City
Where population >  100000  and CountryCode = 'USA'

-- Revising the Select Query II

Select Name From City 
Where Population > 120000 and CountryCode = 'USA'

-- Revising Aggregations - The Count Function

SELECT Count(POPULATION) 
From CITY
WHERE Population > 100000

-- Revising Aggregations - The Sum Function

SELECT SUM(Population)
From CITY
Where DISTRICT = 'California'

-- Revising Aggregations - Averages

SELECT AVG(Population) 
From CITY
Where DISTRICT = 'California'


