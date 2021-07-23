using System;
/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        double sqrt_5 = Math.Sqrt(5);
        double fib_n = Math.Pow((1 + sqrt_5) / 2, n + 1) - Math.Pow((1 - sqrt_5) / 2, n + 1);
        return int.Parse((fib_n / sqrt_5).ToString("0"));
    }
}
// @lc code=end

