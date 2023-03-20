namespace LeetCode.Algorithms;

public class WordDictionary
{

    private TrieNode _root = new ();

    public WordDictionary()
    {

    }

    public void AddWord(string word)
    {
        var current = _root;

        foreach (var c in word)
        {
            var node = current.Children[c - 'a'];
            if (node is null)
            {
                node = new TrieNode();
                current.Children[c - 'a'] = node;
            }
            current = node;
        }
        current.EndOfWord = true;
    }

    public bool Search(string word)
    {
        var current = _root;
        return RegexSearch(0, current, word.ToArray());
    }


    private bool RegexSearch(int index, TrieNode current ,char[] chars)
    {
        if (index == chars.Length)
        {
            if (current.EndOfWord)
            {
                return true;
            }
            return false;
        }
        if (chars[index] != '.')
        {
            TrieNode node = current.Children[chars[index] - 'a'];
            return (node != null && RegexSearch(index + 1, node, chars));
        }
        else
        {
            /* for char '.' we check all those characters in the children which are not null that is have furhter link/letters */
            for (int i = 0; i < current.Children.Length; i++)
            {
                TrieNode node = current.Children[i];
                if (node != null)
                {
                    if (RegexSearch(index + 1, node, chars))
                    {
                        return true;
                    }
                }
            }
        }
        return false;

    }
}
