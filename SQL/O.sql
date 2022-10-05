-- OCCUPATIONS

With OCCUP As (
Select 
        NameRank
        ,[Doctor]
        ,[Professor]
        ,[Singer]
        ,[Actor]
From(
Select 
    [Name]
    ,[Occupation]
    ,ROW_NUMBER() OVER(Partition by Occupation Order by Name Asc) NameRank

From Occupations) d
PIVOT(
    Min(Name)
    For [Occupation] IN(
        [Doctor]
        ,[Professor]
        ,[Singer]
        ,[Actor])
) As PivotTable)
Select 
        [Doctor]
        ,[Professor]
        ,[Singer]
        ,[Actor]
From OCCUP
