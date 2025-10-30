namespace LeetCode.Algorithms;

public static class Valid_Sudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        const int cells = 9;
        //Rows
        for (int i = 0; i < cells; i++)
        {
            if (ContainsDuplicate(board[i].Where(x=> x!= '.').ToArray()))
            {
                return false;
            }
        }

        // Columns
        for (int i = 0; i < cells; i++)
        {
            var col = new List<char>();
            for (int j = 0; j < cells; j++)
            {
                if (board[j][i] != '.')
                {
                    col.Add(board[j][i]);
                }
            }
            if (ContainsDuplicate(col.ToArray()))
            {
                return false;
            }
        }


        // Boxes
        var s = 0;
        var p = 0;
        for (int i = 0; i < cells; i++)
        {
            var box = new char[9];
            var m = 0;

            if (s == 9)
            {
                s = 0;
            }
            if (p == 9)
            {
                p = 0;
            }

            for (int j = s; j < (s + 3); j++)
            {
                for (int k = p ; k < (p  + 3); k++)
                {
                    box[m++] = board[j][k];
                }
            }
            p += 3;
            if (p == 9)
            {
                s+=3;
            }
            if (ContainsDuplicate(box.Where(x=> x!= '.').ToArray()))
            {
                return false;
            }
        }

        return true;
    }

    public static bool ContainsDuplicate(char[] chars)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = i + 1; j < chars.Length; j++)
            {
                if (chars[i] == chars[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}
