using System.Linq;
/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution
{
    /// <summary>
    /// 递归二叉查找+双指针可解.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <param name="startIndex"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public int SearchInsert(
        int[] nums,
        int target,
        int startIndex = 0,
        int length = 0)
    {
        if (length == 0)
        {
            length = nums.Length;
        }

        if (length <= 1)
        {
            if (target > nums[startIndex])
            {
                return startIndex + 1;
            }
            else if (target > nums[startIndex])
            {
                return startIndex - 1;
            }
            return startIndex;
        }

        var middleIndex = length / 2;

        var left = nums.Skip(startIndex).Take(middleIndex);

        if (left.LastOrDefault() >= target)
        {
            return SearchInsert(
                nums,
                target,
                startIndex,
                middleIndex);
        }

        return SearchInsert(
            nums,
            target,
            startIndex + middleIndex,
            middleIndex + length % 2);
    }
}
// @lc code=end

