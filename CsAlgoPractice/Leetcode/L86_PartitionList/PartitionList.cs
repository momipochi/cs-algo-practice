using CsAlgoPractice.Models;

namespace CsAlgoPractice.Leetcode.L86_PartitionList;

public class PartitionList
{
    public ListNode Partition(ListNode head, int x)
    {
        var left = new ListNode();
        var lHead = left;
        var right = new ListNode();
        var rHead = right;
        var tmp = head;
        while (tmp != null)
        {
            if (tmp.val < x)
            {
                left.next = tmp;
                left = left.next;
            }
            else
            {
                right.next = tmp;
                right = right.next;
            }
            tmp = tmp.next;
        }
        right.next = null;
        left.next = rHead.next;
        return lHead.next;
    }
}