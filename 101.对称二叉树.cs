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
    private static List<int> tmp = null;
    public bool IsSymmetric(TreeNode root)
    {
        tmp = new List<int>();

        Do(root);

        if (tmp.Count == 1) return true;

        if (tmp.Count % 2 == 0) return false;

        var l = tmp.Take(tmp.Count / 2).ToArray();

        var r = tmp.Skip(tmp.Count / 2 + 1).ToArray();

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
        if (node != null)
        {
            Do(node.left);
            tmp.Add(node.val);
            System.Console.WriteLine("node:{0} , val: {1}", node, node.val);
            Do(node.right);
        }
    }
}
// @lc code=end


/*
C# 似乎无法通过这个用例

Wrong Answer
194/197 cases passed (N/A)
Testcase
[1,2,2,2,null,2]
Answer
true
Expected Answer
false
*/

