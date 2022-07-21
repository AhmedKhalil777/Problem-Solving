namespace HackerRank.Algorithms;

public class DayOfTheProgrammer
{
    /*
 * Complete the 'dayOfProgrammer' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts INTEGER year as parameter.
 */

    public static string dayOfProgrammer(int year)
    {
        var feb = year switch
        {
            < 1918 => IsJulianLeapYear(year) ? 29: 28,
            > 1918 => IsGregorianLeapYear(year) ? 29 : 28,
            _ => 15
        };
        return $"{256 - (feb + 215)}.09.{year}";
    }


    private static bool IsJulianLeapYear(int year) =>  (year % 4 == 0);

    private static bool IsGregorianLeapYear(int year) => ( (year % 4 == 0)  && (year % 100 != 0))  || (year % 400 == 0 ); 
}

