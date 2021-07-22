/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var arr = s.Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

        if (arr.Length < 1)
        {
            return 0;
        }

        return arr[arr.Length - 1].Length;
    }
}
// @lc code=end

