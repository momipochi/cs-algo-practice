using CsAlgoPractice.Models;

namespace CsAlgoPractice.Leetcode.L92_ReversedLinkedListII;

public class ReversedLinkedListII
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var res = new ListNode();
        res.next = head;
        var prev = res.next;
        for (int i = 1; i < left-1; i++)
        {
            prev = prev.next;
        }

        var curr = prev.next;
        for (int i = left; i < right; i++)
        {
            var tmp = prev.next;
            curr.next = tmp.next;
            tmp.next = prev.next;
            prev.next = tmp;

        }
        return res.next;
    }
}