namespace HackerRank.Algorithms;

public class SequenceEquation
{

    public static List<int> permutationEquation(List<int> p)
    {
        var res = new List<int>();
        for (int i = 1; i <= p.Count; i++)
        {
          var index =  p.FindIndex(x => x == i) + 1;
          var permut = p.FindIndex(x=> x == index) + 1;
            res.Add(permut);
        }
        return res;
    }

}
