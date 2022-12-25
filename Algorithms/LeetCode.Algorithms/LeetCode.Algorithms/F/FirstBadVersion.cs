using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static IronPython.Modules._ast;

namespace LeetCode.Algorithms;

public class VersionControl : VersionControlBase
{
    public int FirstBadVersion(int n)
    {
        long minNum = 0;
        long maxNum = n ;
        while (minNum <= maxNum)
        {
            long mid =  (minNum + maxNum) / 2;
            if (IsBadVersion((int)mid) && !IsBadVersion((int)mid -1))
            {
                return (int)mid;
            }
            else if (IsBadVersion((int)mid))
            {
                maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }
        return -1;
    }
}


public abstract class VersionControlBase
{
    public void SetBadVersion(int badVersion)
    {
        FirstBadVersion= badVersion;
    }
    private int FirstBadVersion { set; get; }
    protected bool IsBadVersion(int version)
    {
        return version>= FirstBadVersion;
    }
}
