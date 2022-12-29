using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class Pascal_s_Triangle
{
    public static Dictionary<int, List<int>> PascalTriangle = new Dictionary<int, List<int>>
    {
        {1, new List<int>      {1}  },
        {2, new List<int>     {1,1}  },
        {3, new List<int>    {1,2,1}  },
        {4, new List<int>   {1,3,3,1} },
        {5, new List<int>  {1,4,6,4,1} },
    };


    public static IList<IList<int>> Generate(int numRows)
    {
        var res = new List<IList<int>>();
        if (!PascalTriangle.ContainsKey(numRows))
        {
            var lastRow = PascalTriangle.Max(x => x.Key);
            for (int i = lastRow + 1; i <= numRows; i++)
            {
                var rowBefore = PascalTriangle[i - 1];
                var row = new List<int> { 1 };
                for (int j = 0; j < rowBefore.Count -1; j++)
                {
                    row.Add(rowBefore[j] + rowBefore[j + 1]);
                }
                row.Add(1);
                PascalTriangle.Add(i, row);
            }
        }

        for (int i = 1; i <= numRows; i++)
        {
            res.Add(PascalTriangle[i]);
        }
        return res;        
    }


}
