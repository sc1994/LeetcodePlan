using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var tmp = new List<int>();

        foreach (int item in nums)
        {
            tmp.Add(tmp.LastOrDefault() + item);
        }

        System.Console.WriteLine(string.Join(",", tmp));

        return tmp.Max();
    }
}
// @lc code=end

