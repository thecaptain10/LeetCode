using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
    public class RemoveDuplicatesFromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode fakeHead = new ListNode(0);
            fakeHead.next = head;

            ListNode prev = fakeHead;
            while (prev.next != null && prev.next.next != null)
            {
                if (prev.next.val == prev.next.next.val)
                {
                    int dup = prev.next.val;
                    while (prev.next != null && prev.next.val == dup)
                    {
                        prev.next = prev.next.next;
                    }
                }
                else
                {
                    prev = prev.next;
                }

            }

            return fakeHead.next;
        }
    }
}
