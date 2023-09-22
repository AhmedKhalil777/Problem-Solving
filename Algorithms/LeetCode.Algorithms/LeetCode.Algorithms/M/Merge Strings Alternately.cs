using System.Text;

namespace LeetCode.Algorithms;

public class Merge_Strings_Alternately
{
    public string MergeAlternately(string word1, string word2)
    {
        if (word1.Length == 0)
        {
            return word2;
        }
        if (word2.Length ==0)
        {
            return word1;
        }
        var sb = new StringBuilder();
        var minLength = word1.Length < word2.Length ? word1.Length : word2.Length;
        for (int i = 0; i < minLength; i++)
        {

            sb.Append(word1[i]);
            sb.Append(word2[i]);
            if (i+1 == word1.Length)
            {
                sb.Append(word2[(i+1)..(word2.Length)]);
            }
            if (i + 1 == word2.Length)
            {
                sb.Append(word1[(i+1)..(word1.Length)]);
            }
        }
        return sb.ToString();   
    }
}
