using System.Collections.Generic;
using System.IO;
/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution
{
    static Dictionary<char, char> dicIsValid = new Dictionary<char, char>
    {
        { ')' , '(' },
        { ']' , '[' },
        { '}' , '{' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (dicIsValid.TryGetValue(item, out var val))
            {
                // 遇到了反向括号
                if (stack.Count < 1) // 栈中没有值
                {
                    return false;
                }
                if (stack.Pop() != val) // 栈中的值不是反向括号
                {
                    return false;
                }
                continue;
            }
            stack.Push(item);
        }
        return stack.Count == 0; // 栈中存在值说明有多余的括号
    }
}
// @lc code=end

