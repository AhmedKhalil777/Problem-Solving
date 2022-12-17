using System.Text;

namespace LeetCode.Algorithms;

public static class ValidParentheses
{

    public static Dictionary<char,char> ValidPairs = new () {
        ['}'] = '{',
        [')'] = '(',
        [']'] = '[',
    };
    
    public static bool IsValid(string s)
    {
        if (s.Length % 2 == 1)
        {
            return false;
        }
        var sb = new StringBuilder(s);
 
        while(sb.Length > 1) {
            var ending = sb.ToString().IndexOfAny(new char[] { '}' , ']' , ')' });
            if (ending == -1) { return false; }
            var start = ValidPairs[sb[ending]];
            if (ending != 0 && sb[ending - 1]  == start) {
                sb.Remove(ending -1, 2);
                continue;
            }
            return false;
        }
        return true;
    }


    public static bool IsValid2(string s)
    {
        Stack<char> stack = new Stack<char>();
        if (IsClosingBracket(s[0]))
            return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!IsClosingBracket(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count != 0 && DoBracketsMatch(stack.Peek(), s[i]))
                    stack.Pop();
                else
                    return false;
            }
        }
        return stack.Count == 0;
    }
    public static bool IsClosingBracket(char c)
    {
        return c == ')' || c == '}' || c == ']';
    }
    public static bool DoBracketsMatch(char firstBracket, char secondBracket)
    {
        return firstBracket == '(' && secondBracket == ')'
                || firstBracket == '{' && secondBracket == '}'
                || firstBracket == '[' && secondBracket == ']';
    }
}
