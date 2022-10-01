-- Weather Observation Station 1
Select CITY, STATE From STATION WHERE LAT_N >= 0 AND LONG_W >= 0;

-- Weather Observation Station 3
Select DISTINCT CITY From STATION WHERE ID % 2 = 0;

