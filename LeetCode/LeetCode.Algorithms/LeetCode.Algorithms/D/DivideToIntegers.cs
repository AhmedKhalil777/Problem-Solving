namespace LeetCode.Algorithms;

public class DivideToIntegers
{
    public static int Divide(int dividend, int divisor)
    {
        try
        {
            return dividend / divisor;

        }
        catch (OverflowException)
        {
            if (dividend > 0 && divisor > 0 || dividend < 0 && divisor < 0)
            {
                return int.MaxValue;
            }
            return int.MinValue;  
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
