using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    //Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
    //Return the decimal value of the number in the linked list.
    //O(n)
    public class BinaryNumberInLLToInt
    {
        public int GetDecimalValue(ListNode head)
        {
            ListNode revHead = ReverseList(head);

            int res = 0;
            int index = 0;

            ListNode cur = revHead;
            while (cur != null)
            {
                res += cur.val * (int)Math.Pow(2, index);
                cur = cur.next;
                index++;
            }

            return res;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }
    }
}
