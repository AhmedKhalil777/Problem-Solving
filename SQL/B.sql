-- Binary Tree Nodes

SELECT N, 
       CASE WHEN P Is Null THEN 'Root'
            WHEN N In (SELECT DISTINCT P From BST) THEN 'Inner'
       ELse 'Leaf'
       END AS NodeType
From BST
Order By N
