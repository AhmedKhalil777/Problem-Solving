namespace LeetCode.Algorithms;

public class Add_Digits
{

    public int AddDigits(int num)
    {
        var numStr = num.ToString();
        if (numStr.Length == 1)
        {
            return num;
        }

        return AddDigits(numStr.Select(c => int.Parse($"{c}")).Sum());
    }
}
