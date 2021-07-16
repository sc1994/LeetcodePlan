using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if (dic.ContainsKey(val))
            {
                dic[val].Add(i);
            }
            else
            {
                dic.Add(val, new List<int> { i });
            }
        }

        foreach (var item in dic)
        {
            // 假设值
            var tmp = target - item.Key;
            if (tmp == item.Key)
            {
                if (item.Value.Count > 1)
                {
                    return new[] { item.Value[0], item.Value[1] };
                }
                else
                {
                    continue;
                }
            }

            if (dic.ContainsKey(tmp))
            {
                //  存在假设值
                return new[] { item.Value[0], dic[tmp][0] };
            }
        }

        return new int[0];
    }
}
// @lc code=end

