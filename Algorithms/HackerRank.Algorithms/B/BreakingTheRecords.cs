namespace HackerRank.Algorithms;

public static class BreakingTheRecords
{
    public static List<int> breakingRecords(List<int> scores)
    { 
        int max  = scores[0] , min = scores[0] , maxSum = 0 , minSum = 0 ;
       scores.ForEach(x =>
       {
           if (max < x)
           {
               maxSum++;
               max = x;
           }
           if (min> x)
           {
               min = x;
               minSum++;
           }
           
       });
       return new List<int> { maxSum, minSum};
    }
}