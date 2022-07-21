namespace HackerRank.Algorithms;

public static class BetweenTowSets
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        var f = Lcm(a);
        var l = Gcd(b);
        var count = 0;
        for(int i = f, j =2; i<=l; i=f*j,j++){
            if(l%i==0){ count++;}
        }
        return count;
    }
    
    
    private static int Gcd(int a, int b) {
        while (b > 0) {
            (a , b ) = (b , a % b);
        }
        return a;
    }
    
    private static int Gcd(IReadOnlyList<int> input) {
        int result = input[0];
        for (int i = 1; i < input.Count; i++) {
            result = Gcd(result, input[i]);
        }
        return result;
    }
    
    private static int Lcm(int a, int b) {
        return a * (b / Gcd(a, b));
    }

    private static int Lcm(IReadOnlyList<int> input) {
        var result = input[0];
        for (var i = 1; i < input.Count; i++) {
            result = Lcm(result, input[i]);
        }
        return result;
    }
}