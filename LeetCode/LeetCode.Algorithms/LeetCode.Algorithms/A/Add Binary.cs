using System.Text;

namespace LeetCode.Algorithms;

public class Add_Binary
{
    public string AddBinary(string a, string b)
    {
        var builder = new StringBuilder();
        var max = (a.Length > b.Length ? a : b).Reverse().ToList();
        var min = (b.Length >= a.Length ? a : b).Reverse().ToList();
        var hand = 0;
        for (var i = 0; i < max.Count; i++)
        {
            if (i >= min.Count)
            {
                if (max[i] == '1' && hand == 1)
                {
                    builder.Append('0');
                }
                else if(hand == 1)
                {
                    builder.Append('1');
                    hand = 0;
                }
                else
                {
                    builder.Append(max[i]);
                }

                continue;
            }
            if (max[i] == '1' && min[i] == '1')
            {
                if (hand == 1)
                {
                    builder.Append('1');
                }
                else
                    builder.Append('0');
                hand = 1;

            }
            else if (max[i] == '1' || min[i] == '1')
            {
                if (hand == 1)
                {
                    builder.Append('0');
                }
                else
                {
                    builder.Append('1');
                }
            }
            else
            {
                if (hand == 1)
                {
                    builder.Append('1');
                    hand = 0;
                }
                else
                {
                    builder.Append('0');
                }
            }
        }

        if (hand == 1)
            builder.Append('1');

        return string.Join( "",  builder.ToString().Reverse());
    }
}
