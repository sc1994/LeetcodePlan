using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
 */

// @lc code=start

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    private static List<int?> tmp = null;
    public bool IsSymmetric(TreeNode root)
    {
        return Do(root?.left, root?.right);
    }

    public bool Do(TreeNode l, TreeNode r)
    {
        if (l == null || r == null)
        {
            return l?.val == r?.val;
        }

        if (l.val != r.val)
        {
            return false;
        }

        return Do(l.left, r.right) && Do(l.right, r.left);
    }
}
// @lc code=end

