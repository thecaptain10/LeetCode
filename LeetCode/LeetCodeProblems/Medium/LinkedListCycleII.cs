using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/linked-list-cycle-ii/
    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return null;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                //Loop is present
                if (fast == slow)
                {
                    //set fast to starting index
                    //For Proof : https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/
                    fast = head;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                    return slow;
                }
            }
            return null;
        }
    }
}
