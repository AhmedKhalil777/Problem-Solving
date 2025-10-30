

namespace LeetCode.Algorithms.Tests;

public class VersionControl
{

    [Fact]
    public void FirstBadVersion()
    {
        var versionC = new Algorithms.VersionControl();
        versionC.SetBadVersion(4);
        versionC.FirstBadVersion(5).Should().Be(4);
        versionC.SetBadVersion(1);
        versionC.FirstBadVersion(1).Should().Be(1);
        versionC.SetBadVersion(2);
        versionC.FirstBadVersion(2).Should().Be(2);  
        versionC.SetBadVersion(1702766719);
        versionC.FirstBadVersion(2126753390).Should().Be(1702766719);

    }
}
