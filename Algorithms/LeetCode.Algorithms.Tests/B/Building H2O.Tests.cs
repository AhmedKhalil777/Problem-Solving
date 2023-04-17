using System.Diagnostics;

namespace LeetCode.Algorithms.Tests;

public class Building_H2O
{
    [Theory]
    [InlineData("HHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHOHHO")]
    public void H2OTest(string atomsStream)
    {
        atomsStream = string.Concat(atomsStream.ToCharArray().OrderBy(x => Guid.NewGuid()));
        var h2oGenerator = new H2OCreator();
        var str = new StringBuilder();
        Parallel.ForEach(atomsStream, c =>
        {
            if (c == 'H')
            {
                h2oGenerator.Hydrogen(() => str.Append('H'));
            }
            else
            {
                h2oGenerator.Oxygen(() => str.Append('O'));

            }
        });
        var res = str.ToString();
        Trace.WriteLine(res);
        for (int i = 0; i < res.Length; i+= 3)
        {
           var h2o= res.Skip(i).Take(3);
           h2o.Count(x => x == 'H').Should().Be(2);
           h2o.Count(x => x == 'O').Should().Be(1);
        }
    }
}


