using System;
/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根
 */

// @lc code=start
public class Solution
{
    public int MySqrt(int x)
    {
        return int.Parse(Math.Floor(Math.Sqrt(x)).ToString("0"));
    }
}
// @lc code=end

