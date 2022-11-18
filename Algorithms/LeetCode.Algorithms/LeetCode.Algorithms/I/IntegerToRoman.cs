using System.Text;

namespace LeetCode.Algorithms;

public class IntegerToRoman
{
    public static string IntToRoman(int num)
    {
        var stringBuilder = new StringBuilder();


        if (num == 0)
        {
            return stringBuilder.ToString();
        }

        if (num / 1000.0 >= 1)
        {
            while(num > 1000)
            {
                stringBuilder.Append("M");
                num -= 1000;
            }
        }

        if (num / 100.0  >= 1)
        {
            var hundreds = num switch
            {
                < 100 => "",
                < 200 => "C",
                < 300 => "CC",
                < 400 => "CCC",
                < 500 => "CD",
                < 600 => "D",
                < 700 => "DC",
                < 800 => "DCC",
                < 900 => "DCCC",
                < 1000 => "CM",
                _ => ""
            };
            stringBuilder.Append(hundreds);

            while (num > 100)
            {
                num -= 100;
            }
        }


        if (num / 10.0 >= 1)
        {
            var tens = num switch
            {
                < 10 => "",
                < 20 => "X",
                < 30 => "XX",
                < 40 => "XXX",
                < 50 => "XL",
                < 60 => "L",
                < 70 => "LX",
                < 80 => "LXX",
                < 90 => "LXXX",
                < 100 => "XC",
                _ => ""
            };
            stringBuilder.Append(tens);

            while (num > 10)
            {
                num -= 10;
            }
        }

        var ones = num switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            _ => "",
        };
        stringBuilder.Append(ones);
        return stringBuilder.ToString();
    }
}
