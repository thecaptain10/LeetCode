using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/intersection-of-two-linked-lists/
    //Complexity : O(m+n)
    public class LinkedListIntersection
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int length1 = 0;
            int length2 = 0;

            ListNode node1 = headA;
            ListNode node2 = headB;

            //Get Lengths for both LL
            while(node1 != null)
            {
                length1 = length1 + 1;
                node1 = node1.next;
            }
            while (node2 != null)
            {
                length2 = length2 + 1;
                node2 = node2.next;
            }

            int diff = 0;

            //reset vars.
            node1 = headA;
            node2 = headB;

            if(length1>length2)
            {
                diff = length1 - length2;
                int i = 0;
                while(i<diff)
                {
                    node1 = node1.next;
                    i++;
                }
            }
            else
            {
                diff = length2 - length1;
                int i = 0;
                while (i < diff)
                {
                    node2 = node2.next;
                    i++;
                }
            }

            while(node1 != null && node2 != null)
            {
                if (node1 != node2)
                    return node1;

                node1 = node1.next;
                node2 = node2.next;
            }
            return null;
        }
    }
}
