namespace HackerRank.Algorithms.Tests;

public class MigratoryBirds
{
    [Fact]
    public void migratoryBirds_GivenMigratoryIdsSerial_ShouldReturnMaxTypeMigrated()
    {
        Algorithms.MigratoryBirds
            .migratoryBirds(new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 })
            .Should()
            .Be(3);
    }
    
    [Fact]
    public void migratoryBirds_GivenMigratoryIdsSerialAsBatch_ShouldReturnMaxTypeMigrated()
    {
        Algorithms.MigratoryBirds
            .migratoryBirds(File.ReadAllText("./M/migratoryBatch.txt").Split(' ').Select(x=> int.Parse(x)).ToList())
            .Should()
            .Be(3);
    }
}