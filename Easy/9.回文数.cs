/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        else if (x < 10)
        {
            return true;
        }

        var str = x.ToString();
    
        var count = str.Length / 2;
        for (int i = 0; i < count; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

