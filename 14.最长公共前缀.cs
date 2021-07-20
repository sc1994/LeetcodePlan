using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start 
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var order = strs.OrderBy(x => x.Length).ToArray();
        var baseStr = order.First();

        for (int i = 1; i < order.Length; i++)
        {
            for (int j = 0; j < Math.Min(order[i].Length, baseStr.Length); j++)
            {
                if (baseStr[j] != order[i][j])
                {
                    baseStr = baseStr.Remove(j, baseStr.Length - j);
                    if (baseStr.Length < 1)
                    {
                        return "";
                    }
                }
            }

        }
        return baseStr;
    }
}
// @lc code=end

