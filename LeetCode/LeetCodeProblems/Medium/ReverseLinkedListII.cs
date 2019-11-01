using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/reverse-linked-list-ii/
    //Reverse a linked list from position m to n. Do it in one-pass.
    public class ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {

            if (head == null) return null;
            var dummy = new ListNode(-1);
            dummy.next = head;
            var cur = head;

            var preReverseHead = dummy;

            var count = 1;
            while (cur != null)
            {
                if (count < m)
                {
                    preReverseHead = cur;
                    cur = cur.next;
                }
                else if (count >= n)
                {
                    cur = cur.next;
                }
                else
                {
                    // reverse
                    var temp = cur.next;
                    cur.next = temp.next;
                    temp.next = preReverseHead.next;
                    preReverseHead.next = temp;
                }

                count++;
            }

            var newHead = dummy.next;
            dummy.next = null;

            return newHead;

        }
    }
}
