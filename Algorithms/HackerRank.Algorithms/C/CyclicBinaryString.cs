using System.Buffers.Binary;
using System.Collections;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace HackerRank.Algorithms;

public class CyclicBinaryString
{
    /*
 * Complete the 'maximumPower' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts STRING s as parameter.
 */

    public static int maximumPower(string s)
    {
        var w = 0;
        var flag =0;
        var n = s.Length;
        var k = new Queue<char>(s);
        for (int i = 0; i < n; i++)
        {
            var t = k.Dequeue();
            k.Enqueue(t);
            if (k.Peek() == '1')
            {
                w = GetPow(k);
                break;

            }
            flag++;
        }
        if (flag == n)
            return -1;
        else
        {
            return w;
        }
       
    }

    public static int GetPow(Queue<char> n)
    {
        var count = 0;
        var m = 0;
        var k = n.ToList();
        for(var i = 0; i < k.Count; i++)
        {
            if (k[i] == '0')
            {
                count++;
            }
            else
            {
                if (m < count)
                {
                    m = count;
                }
                count = 0;
            }
            if (m < count)
            {
                m = count;
            }
        }
        return m;
    }
    public static int maximumPower2(string s)
    {

        var max = -1;

        for (int i = 0; i < s.Length; i++)
        {
            var maxPower = string.Join("", s.Reverse()) 
                .IndexOf('1');
            if (maxPower > max) max = maxPower;
            s = ShiftOne(s);
        }
        return max;
    }
    public static int maximumPower1(string s)
    {
        var max = -1;
       
        for (int i = 0; i < s.Length; i++)
        {
            if (s.EndsWith('1'))
            {
                return 0;
            }
            var num = ConverToInt32(s);
            var maxPower = FindMaxDivisiblePowerOf2(num);
            if (maxPower > max) max = maxPower;
            s = ShiftOne(s);
        }
        return max;
    }

    public static int FindMaxDivisiblePowerOf2(uint num)
    {
        if (num == 0) return -1;
        int max = 0, current  = 0;
        while (true)
        {
            var nextMax = current + 1;
            if (Math.Pow(nextMax, 2) > num) break;
            if (num % Math.Pow(2, nextMax) == 0)
            {
                max = nextMax;
            }
            current++;
        }
        return max;
    }

    public static string ShiftOne(string s)
    {
        var builder = new StringBuilder();
        builder.Append(s.Last());
        builder.Append(s.AsSpan(0,s.Length -1));
        return builder.ToString();
    }

    public static uint ConverToInt32(string s)
    {
        var intBase = int.Parse(s);
        s = intBase.ToString();
        if (s.Length < 32)
        {
            var remaining = 32 - s.Length;
            s = string.Join( separator: "", s.Reverse()) + string.Join("", Enumerable.Range(0, remaining).Select(x => '0'));
        }
        var bits = new BitArray(s.Select(c => c == '1').ToArray());
        
        var bytes = new byte[4];
        bits.CopyTo(bytes, 0);
        return BitConverter.ToUInt32(bytes);
    }
}
