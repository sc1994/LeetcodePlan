using System;
using System.Linq;

/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var overflow = 0;

        var last = digits[digits.Length - 1] + 1;
        if (last > 9)
        {
            digits[digits.Length - 1] = 0;
            overflow = 1;
        }
        else
        {
            digits[digits.Length - 1] = last;
            return digits;
        }

        for (int i = digits.Length - 2; i >= 0; i--)
        {
            System.Console.WriteLine("{0},{1},{2}", i, digits[i], overflow);
            if (overflow == 1)
            {
                var tmp = digits[i] + 1;

                if (tmp > 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    overflow = 0;
                    digits[i] = tmp;
                }

            }
            else
            {
                break;
            }
        }

        if (overflow == 1)
        {
            digits[0] = 1;
            digits = digits.Append(0).ToArray();
        }

        return digits;
    }
}
// @lc code=end

