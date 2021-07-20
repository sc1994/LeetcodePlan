/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现 strStr()
 */

// @lc code=start
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        if (haystack == needle || needle == "")
        {
            return 0;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var success = true;
                for (int j = 1; j < needle.Length; j++)
                {
                    if (haystack.Length <= i + j || needle[j] != haystack[i + j])
                    {
                        success = false;
                        break;
                    }
                }
                if (success)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
// @lc code=end

