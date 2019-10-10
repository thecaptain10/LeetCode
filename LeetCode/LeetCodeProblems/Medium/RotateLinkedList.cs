using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/rotate-list/
    //Given a linked list, rotate the list to the right by k places, where k is non-negative.
    public class RotateLinkedList
    {
        public ListNode RotateRight(ListNode head, int k)
        {

            //Two pointer technique
            ListNode newHead;
            ListNode kPlacesHead = head;
            ListNode temp = head;

            int n = 0;
            ListNode curr = head;

            // if head is null, return
            if (head == null)
                return head;

            //Calculate leangth;
            while (curr != null)
            {
                n++;
                curr = curr.next;
            }

            //if just 1 element or k == 0 return head;
            if (n == 1 || k == 0)
                return head;

            //Take Modulus if k is greater then n
            if (k > n)
                k = k % n;

            
            if (k == n || k == 0)
                return head;

            //if k is less then n
            while (k > 0)
            {
                if (kPlacesHead.next != null)
                {
                    kPlacesHead = kPlacesHead.next;
                    k--;
                }
                else
                    break;

            }

            while (kPlacesHead.next != null)
            {
                kPlacesHead = kPlacesHead.next;
                temp = temp.next;
            }

            newHead = temp.next;
            temp.next = null;
            kPlacesHead.next = head;

            return newHead;

        }
    }
}
