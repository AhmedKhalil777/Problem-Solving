using System.Runtime.Intrinsics.X86;

namespace LeetCode.Algorithms;

public static class RectangleArea
{
    public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        var aArea = GetArea(ax1,ay1,ax2,ay2);
        var bArea = GetArea(bx1, by1, bx2, by2);

        int overlapR = 0;

        int xoverlap = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
        int yoverlap = Math.Min(ay2, by2) - Math.Max(ay1, by1);
        if (xoverlap > 0 && yoverlap > 0)
            overlapR = xoverlap * yoverlap;

        return aArea + bArea - overlapR;
    }


    public static int GetArea(int x1, int y1, int x2, int y2)
    {
        var len = Math.Abs(x2 - x1);
        var wed = Math.Abs(y2 - y1);
        return len * wed;
    }
}
