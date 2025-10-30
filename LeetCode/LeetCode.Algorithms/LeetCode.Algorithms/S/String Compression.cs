using System.Text;

namespace LeetCode.Algorithms;

public class String_Compression
{
    public int Compress(char[] chars)
    {
        switch (chars.Length)
        {
            case 0:
                return 0;
            case 1:
                return 1;
        }

        var prevChar = chars[0];
        var charCount = 1;

        var index = 0;
        var total = 0;
        for (int i = 1; i < chars.Length +1 ; i++)
        {
            
            if (i == chars.Length || chars[i] != prevChar )
            {
                if (charCount == 1)
                {
                    chars[index] = prevChar;
                    total++;
                    index++;
                }
                else
                {
                    var str = prevChar.ToString() + charCount;
                    foreach (var ch in str)
                    {
                        chars[index] = ch;
                        total++;
                        index++;
                    }
                }
                if (i == chars.Length)
                {
                    break;
                }
                charCount = 0;

            }
            charCount++;
            prevChar = chars[i];
        }

        return total;
    }
}