using System.Linq;
/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var list = nums1.Take(m)
            .Concat(nums2.Take(n))
            .OrderBy(x => x)
            .ToList();

        for (int i = 0; i < list.Count; i++)
        {
            nums1[i] = list[i];
        }
    }
}
// @lc code=end

