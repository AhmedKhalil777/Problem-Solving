namespace LeetCode.Algorithms
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var length = s.Length;


            var total = 0;
            var i = length;

            while (i > 0)
            {
                var digit = RomanNumerals[s[--i].ToString()];

                if (i > 0)
                {
                    var previousDigit = RomanNumerals[s[i - 1].ToString()];

                    if (previousDigit < digit)
                    {
                        digit -= previousDigit;
                        i--;
                    }
                }

                total += digit;
            }

            return total;

        }

        private const int NumberOfRomanNumeralMaps = 13;

        private static readonly IDictionary<string, int> RomanNumerals =
            new Dictionary<string, int>(NumberOfRomanNumeralMaps)
            {
                        { "M",  1000 },
                        { "CM", 900 },
                        { "D",  500 },
                        { "CD", 400 },
                        { "C",  100 },
                        { "XC", 90 },
                        { "L",  50 },
                        { "XL", 40 },
                        { "X",  10 },
                        { "IX", 9 },
                        { "V",  5 },
                        { "IV", 4 },
                        { "I",  1 }
            };
    }
}
