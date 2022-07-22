namespace HackerRank.Algorithms;

public class ElectronicsShop
{
    /*
 * Complete the getMoneySpent function below.
 */
    public static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        Func<int, int> getMaxKeyboardForDrive = x =>
        {
            try
            {
                return keyboards.Where(y => (y + x) <= b).Max();
            }
            catch (Exception)
            {
                return -1;
            }
        };
        
        try
        {
           return  drives
                .Select(x => new Tuple<int, int>(x, getMaxKeyboardForDrive(x)))
                .Where(x=> x.Item2 != -1)
                .Max(x => x.Item1 + x.Item2);

        }
        catch (Exception)
        {
            return -1;
        }
    }
}