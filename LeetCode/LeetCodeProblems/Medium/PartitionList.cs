using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {

            //Base Case
            if (head == null || head.next == null)
                return head;

            //Will create 2 lists : elements < x and elements >= x

            ListNode node = head;
            ListNode head1 = new ListNode(0);
            ListNode head2 = new ListNode(0);

            head1.next = head;

            ListNode node1 = head1;
            ListNode node2 = head2;

            while (node != null)
            {
                if (node.val < x)
                {
                    node = node.next;
                    node1 = node1.next;
                }
                else
                {
                    node2.next = node;
                    node1.next = node.next;
                    node = node.next;
                    node2 = node2.next;
                }
            }
            //Close List
            node2.next = null;

            node1.next = head2.next;

            return head1.next; ;
        }
    }
}
