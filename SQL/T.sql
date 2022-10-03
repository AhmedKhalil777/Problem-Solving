-- Type of Triangle

SELECT CASE 
       WHEN (A = B AND B = C AND C = A) THEN 'Equilateral'
       WHEN (A + B >  C AND B + C >  A AND C + A > B) AND (A = B OR B = C OR C = A)     
       THEN 'Isosceles'
       WHEN (A + B >  C AND B + C >  A AND C + A > B) THEN 'Scalene' 
       ELSE  'Not A Triangle' 
       END AS TY
FROM TRIANGLES    
