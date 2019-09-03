using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/remove-linked-list-elements/
    //Remove all elements from a linked list of integers that have value val.
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {

            if (head == null)
                return head;


            ListNode curr = head;

            //Middle Elements
            while (curr != null && curr.next != null)
            {
                if (curr.next.val == val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
            }


            //Front Node
            if (head.val == val)
                head = head.next;

            //Tail Node
            if (head != null && head.next != null && head.next.val == val)
                head.next = null;

            return head;


        }
    }
}
