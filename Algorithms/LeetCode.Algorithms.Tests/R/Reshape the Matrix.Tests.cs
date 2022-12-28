namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class Reshape_the_Matrix
{
    [Fact]
    public async Task MatrixReshape()
    {
        var mat = new int[2][];
        mat[0] = new int[] { 1, 2 }; 
        mat[1] = new int[] { 3, 4 };
        await Verify(Algorithms.Reshape_the_Matrix.MatrixReshape(mat, 1, 4));
    }

    [Fact]
    public async Task MatrixReshape2()
    {
        var mat = new int[2][];
        mat[0] = new int[] { 1, 2 };
        mat[1] = new int[] { 3, 4 };
        await Verify(Algorithms.Reshape_the_Matrix.MatrixReshape(mat, 2, 4));
    }
}
