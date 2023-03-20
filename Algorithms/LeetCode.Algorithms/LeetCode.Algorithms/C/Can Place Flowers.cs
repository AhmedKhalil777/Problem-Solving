namespace LeetCode.Algorithms;

public class Can_Place_Flowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }
        if (flowerbed.Length == 1 && n ==1 && flowerbed[0] == 0 )
        {
            return true;
        }
        var adj = false;
        for (int i = 0, j =1; j < flowerbed.Length ; i++, j++)
        {
            if (n == 0)
                return true;

            if (flowerbed[i] == 0 && flowerbed[j] == 0 && !adj)
            {
                n--;
                flowerbed[i] = 1;
                adj= true;

                continue;
            }
            if (j == flowerbed.Length - 1 && flowerbed[i] == 0 && flowerbed[j] == 0)
            {
                n--;
                flowerbed[j] = 1;
                continue;
            }

            if (flowerbed[i] == 1)
            {
                adj = true;
            }
            else
            {
                adj = false;

            }



        }

        if (n > 0)
            return false;
                
        return true;
    }
}
