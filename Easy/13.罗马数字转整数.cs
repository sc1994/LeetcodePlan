using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution
{
    // static Dictionary<string, int> dic = new Dictionary<string, int>
    // {
    //     { "I", 1 },
    //     { "V", 5 },
    //     { "IV", 4 },
    //     { "X", 10 },
    //     { "L", 50 },
    //     { "XL", 40 },
    //     { "C", 100 },
    //     { "D", 500 },
    //     { "CD", 400 },
    //     { "M", 1000 },
    //     { "CM", 900 },
    // };

    static Dictionary<char, int> dicRomanToInt = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public int RomanToInt(string s)
    {
        var result = 0;
        var max = s.Length - 1;
        for (int i = 0; i < s.Length; i++)
        {
            var item = s[i];

            if (i < max)
            {
                var itemNext = s[i + 1];
                if (item == 'I' && (itemNext == 'V' || itemNext == 'X'))
                {
                    result += dic[itemNext] - 1;
                    i++; continue;
                }
                else if (item == 'X' && (itemNext == 'L' || itemNext == 'C'))
                {
                    result += dic[itemNext] - 10;
                    i++; continue;
                }
                else if (item == 'C' && (itemNext == 'D' || itemNext == 'M'))
                {
                    result += dic[itemNext] - 100;
                    i++; continue;
                }
            }

            result += dic[item];
        }

        return result;
    }
}
// @lc code=end

