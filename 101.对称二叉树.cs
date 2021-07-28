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
        tmp = new List<int?>();

        Do(root);

        if (tmp.Count == 1) return true;
        if (tmp.Count % 2 == 0) return false;

        var l = tmp.Take(tmp.Count / 2).ToArray();

        var r = tmp.Skip(tmp.Count / 2 + 1).ToArray();

        System.Console.WriteLine(string.Join(",", l));
        System.Console.WriteLine(string.Join(",", r));

        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] != r[r.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    public void Do(TreeNode node)
    {
        if (node == null) return;

        if (node.left == null && node.right != null)
        {
            tmp.Add(null);
            System.Console.WriteLine("null");
        }
        else
        {
            Do(node.left);
        }
        tmp.Add(node.val);
        System.Console.WriteLine(node.val);
        if (node.right == null && node.left != null)
        {
            tmp.Add(null);
            System.Console.WriteLine("null");
        }
        else
        {
            Do(node.right);
        }
    }
}
// @lc code=end

