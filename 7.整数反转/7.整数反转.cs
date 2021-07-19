using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        var source = x.ToString();

        var target = string.Empty;

        if (source.StartsWith("-"))
        {
            source = source.Substring(1);
            target += "-";
        }

        for (int i = source.Length - 1; i >= 0; i--)
        {
            target += source[i];
        }

        if (int.TryParse(target, out var a))
        {
            return a;
        }
        return 0;
    }
}
// @lc code=end

