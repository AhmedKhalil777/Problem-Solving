namespace HackerRank.Algorithms;

public class ClimbingTheLeaderboard
{
    // Dense Ranking 12234556 ordered ranking follow one if higher and equally if equals
    public static List<int> climbingLeaderboardV1(List<int> ranked, List<int> player)
    {
        var res = new int[player.Count];
        var ranking = new int[ranked.Count];
        ranking[0] = 1;
        var rank = 1;
        for (int i = 1; i < ranked.Count  ; i++)
        {
            if (ranked[i - 1] != ranked[i])
            {               
                rank++;
            }
            ranking[i] = rank;
        }
        var zipped = ranked.Zip(ranking);
        var j = -1;
        foreach (var play in player)
        {
            j++;
            var topper = zipped.LastOrDefault(x => x.First >= play);
            if (topper.First ==  default && topper.Second == default )
            {
                res[j] = 1;
                continue;
            }

            if (topper.First == play)
            {
                res[j] = (topper.Second);
            }
            
            if (topper.First > play)
            {
                res[j]= (topper.Second + 1);
            }
        }

        return res.ToList();
    }
    
    
    
    public static List<int> climbingLeaderboardV2(List<int> ranked, List<int> player)
    {
        var res = new List<int>();
        List<int> places = new List<int>();
        int place = 1;
        places.Add(ranked[0]);
        for(int i = 1; i < ranked.Count; i++){
            int currPlace1 = place-1;
            int currScore = ranked[i];
            if(currScore != places[currPlace1]){
                place++;
                places.Add(currScore);
            }
        }
        
        int currPlace = places.Count + 1;
        for(int i = 0; i < player.Count; i++)
        {
            currPlace = GetPlace(currPlace, player[i], places);
            res.Add(currPlace);
        }

        return res;
    }
    
    public static List<int> climbingLeaderboardV3(List<int> ranked, List<int> player)
    {
        var res = new List<int>();
        var places = ranked.Distinct().ToList();
        int currPlace = places.Count + 1;
        for(int i = 0; i < player.Count; i++)
        {
            currPlace = GetPlace(currPlace, player[i], places);
            res.Add(currPlace);
        }

        return res;
    }
    
    
    
    public static int GetPlace(int currPlace, int currScore, List<int> places){
        for(int i = currPlace - 1; i > 0; i--){
            int index = i - 1;
            if(currScore < places[index]){
                return i + 1;
            }
        }
        return 1;
    }
  
    
    
    
    
}

