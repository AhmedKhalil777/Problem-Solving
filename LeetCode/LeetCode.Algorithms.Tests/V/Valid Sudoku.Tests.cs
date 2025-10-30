using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Valid_Sudoku
{
    [Fact]
    public void IsValidSudoku()
    {
        var json = "[['5','3','.','.','7','.','.','.','.'],['6','.','.','1','9','5','.','.','.'],['.','9','8','.','.','.','.','6','.'],['8','.','.','.','6','.','.','.','3'],['4','.','.','8','.','3','.','.','1'],['7','.','.','.','2','.','.','.','6'],['.','6','.','.','.','.','2','8','.'],['.','.','.','4','1','9','.','.','5'],['.','.','.','.','8','.','.','7','9']]";
        var actual = JsonConvert.DeserializeObject<char[][]>(json);
        Algorithms.Valid_Sudoku.IsValidSudoku(actual).Should().BeTrue();

    }

    [Fact]
    public void IsValidSudoku2()
    {
        var json = "[['8','3','.','.','7','.','.','.','.'],['6','.','.','1','9','5','.','.','.'],['.','9','8','.','.','.','.','6','.'],['8','.','.','.','6','.','.','.','3'],['4','.','.','8','.','3','.','.','1'],['7','.','.','.','2','.','.','.','6'],['.','6','.','.','.','.','2','8','.'],['.','.','.','4','1','9','.','.','5'],['.','.','.','.','8','.','.','7','9']]";
        var actual = JsonConvert.DeserializeObject<char[][]>(json);
        Algorithms.Valid_Sudoku.IsValidSudoku(actual).Should().BeFalse();

    }
}
