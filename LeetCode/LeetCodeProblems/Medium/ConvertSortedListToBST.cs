using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
    //Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
    public class ConvertSortedListToBST
    {
        public TreeNode SortedListToBST(ListNode head)
        {

            if (head == null)
                return null;
            if (head.next == null)
                return new TreeNode(head.val);

            ListNode slow = head;
            ListNode fast = head;
            ListNode prevSlow = new ListNode(0);
            prevSlow.next = head;

            while (fast != null && fast.next != null)
            {
                prevSlow = prevSlow.next;
                slow = slow.next;
                fast = fast.next.next;
            }

            prevSlow.next = null;


            //Split LL from mid and link left & right subtree as per BST since list is already sorted.
            TreeNode root = new TreeNode(slow.val);
            root.left = SortedListToBST(head);
            root.right = SortedListToBST(slow.next);

            return root;

        }
    }
}
