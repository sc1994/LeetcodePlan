/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start
// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
    // 递归可解
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        Do(head);

        return head;
    }

    private void Do(ListNode p)
    {
        if (p.next != null)
        {
            if (p.next.val == p.val)
            {
                p.next = p.next.next;
                Do(p);
            }
        }
        if (p.next != null)
        {
            Do(p.next);
        }
    }
}
// @lc code=end

