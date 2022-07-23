namespace HackerRank.Algorithms.Tests;

public class DesignerPdfViewer
{
    [Fact]
    public void designerPdfViewer_GivenWordAndHeights_ShouldReturnArea()
    {
        Algorithms.DesignerPdfViewer.designerPdfViewer( "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5".AsStringIntList(), "abc")
            .Should().Be(9);
        Algorithms.DesignerPdfViewer.designerPdfViewer( "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7".AsStringIntList(), "zaba")
            .Should().Be(28);
    }
}