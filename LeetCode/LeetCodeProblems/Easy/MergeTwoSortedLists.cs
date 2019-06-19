using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
   
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode fakeHead = new ListNode(0);

            ListNode p1 = l1;
            ListNode p2 = l2;
            ListNode p3 = fakeHead;

            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    p3.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    p3.next = p2;
                    p2 = p2.next;
                }

                p3 = p3.next;
            }
            if (p1 != null)
            {
                p3.next = p1;
            }
            if (p2 != null)
            {
                p3.next = p2;
            }
            
            return fakeHead.next;
        }
    }
}
