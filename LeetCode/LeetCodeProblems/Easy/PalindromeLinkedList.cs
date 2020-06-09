using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/palindrome-linked-list/
    //Given a singly linked list, determine if it is a palindrome.
    //O(n) time and O(1) space
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {

            if (head == null || head.next == null)
                return true;

            bool isPalin = true;
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode cur = head;
            //Reverse second half and return head.
            ListNode rev = ReverseList(slow);

            //Compare 1st and reversed 2nd half.
            while (cur != null)
            {
                if (cur.val != rev.val)
                {
                    isPalin = false;
                    break;
                }
                cur = cur.next;
                rev = rev.next;
            }

            return isPalin;
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
