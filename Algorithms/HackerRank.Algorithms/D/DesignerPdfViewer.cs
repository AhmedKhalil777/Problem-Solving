namespace HackerRank.Algorithms;

public class DesignerPdfViewer
{
    
    public static int designerPdfViewer(List<int> h, string word)
    {
        var chars = Enumerable.Range(97, 26).Select(x =>(char)x);
        var charsHeights = chars.Zip(h).ToList();
        var maxHeight = charsHeights.Where(x => word.Any(y => x.First == y))
            .Max(x => x.Second);
        return maxHeight * word.Length;
    }
}