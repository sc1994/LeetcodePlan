/*
 * @lc app=leetcode.cn id=100 lang=csharp
 *
 * [100] 相同的树
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        try
        {
            Do(p, q);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void Do(TreeNode p, TreeNode q)
    {
        if(p == null && q )
        if (p.val == q.val)
        {
            Do(p.left, q.left);
            Do(p.right, q.right);
        }
        else
        {
            throw new System.Exception("");
        }
    }
}
// @lc code=end

