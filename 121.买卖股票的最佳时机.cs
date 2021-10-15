/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var max = 0;
        foreach (var price in prices)
        {
            if (price < min)
            {
                min = price;
            }

            if (price > max)
            {
                max = price;
            }
        }

        return max - min;
    }
}
// @lc code=end

