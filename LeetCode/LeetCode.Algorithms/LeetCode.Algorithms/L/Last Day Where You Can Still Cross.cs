namespace LeetCode.Algorithms;

public class Last_Day_Where_You_Can_Still_Cross
{
    public int[,] GameSet { get; set; }
    public int Rows { get; set; }
    public int Columns { get; set; }
    public List<Tuple<int,int>> Entrances { get; set; }
    public int LatestDayToCross(int row, int col, int[][] cells)
    {
        Rows = row;
        Columns = col;
        GameSet = new int[row,col];
        var res = 0;
        var cellsToAdded = cells.Select(x=> new Tuple<int, int>(x[0], x[1])).ToList();
        foreach( var cell in cellsToAdded)
        {
            GameSet[cell.Item1, cell.Item2] = 1;
            for (int i = 0; i < Columns; i++)
            {
                if (CanCorss(cell, new Tuple<int,int>(0,i)))
                {
                    res++;
                    break;
                }

                if (i == Columns)
                {
                    return res;
                }
            }

        }
        return res;

    }


    public bool CanCorss(Tuple<int, int> cell, Tuple<int,int> entrance)
    {
        var stack = new Stack<Tuple<int,int>>();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {

            }
        }
        return true;
    }
}
