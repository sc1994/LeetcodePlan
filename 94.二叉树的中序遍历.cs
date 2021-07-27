using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        return Do(root);
    }

    public IList<int> Do(TreeNode root)
    {
        if (root == null) return new int[0];
        var r = new List<int>();

        r.AddRange(Do(root.left));
        r.Add(root.val);
        r.AddRange(Do(root.right));

        return r;
    }
}
// @lc code=end

