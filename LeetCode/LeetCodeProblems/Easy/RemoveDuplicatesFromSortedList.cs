using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {

            if (head == null || head.next == null)
                return head;

            ListNode prev = head;
            ListNode curr = head.next;

            while (curr != null)
            {
                if (curr.val == prev.val)
                {
                    //Duplicate
                    curr = curr.next;
                    prev.next = curr;
                }
                else
                {
                    //Distinct
                    curr = curr.next;
                    prev = prev.next;
                }
            }
            return head;
        }
    }
}
