using System;
using System.Text.RegularExpressions;
/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */

// @lc code=start
public class Solution
{
    public string AddBinary(string a, string b)
    {
        var length = Math.Max(a.Length, b.Length); // 两个字符串的最大长度

        var overflow = false;
        var result = "";

        for (int i = length - 1; i >= 0; i--)
        {
            var aIndex = i - (length - a.Length);
            var bIndex = i - (length - b.Length);

            var aE = aIndex > -1 ? a[aIndex] : '0';
            var bE = bIndex > -1 ? b[bIndex] : '0';

            if (aE == '1' && bE == '1')
            {
                result = (overflow ? "1" : "0") + result;
                overflow = true;
            }
            else if (aE == '1' || bE == '1')
            {
                if (overflow)
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
            }
            else
            {
                result = (overflow ? "1" : "0") + result;
                overflow = false;
            }

            if (!overflow && (aIndex <= 0 || bIndex <= 0))
            {
                if (a.Length != b.Length)
                {
                    var cov = string.Empty;
                    var covLen = i;

                    if (a.Length > b.Length)
                    {
                        cov = a.Substring(0, covLen);
                    }
                    else
                    {
                        cov = b.Substring(0, covLen);
                    }
                    result = cov + result;
                }
                break;
            }
        }

        if (overflow)
        {
            result = "1" + result;
        }

        return result;
    }
}
// @lc code=end

