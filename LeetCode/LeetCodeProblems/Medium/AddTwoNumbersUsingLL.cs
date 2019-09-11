using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/add-two-numbers/
    //You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
    public class AddTwoNumbersUsingLL
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;

            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int sum = val1 + val2 + carry;

                cur.next = new ListNode(sum % 10);
                carry = sum / 10;

                cur = cur.next;

                if (l1 != null)
                    l1 = l1.next;


                if (l2 != null)
                    l2 = l2.next;

            }

            cur = dummy.next;
            dummy.next = null;

            return cur;
        }
    }
}
