using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node() { }
        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
    class CopyListWithRandomPointers
    {
        public Node CopyRandomList(Node head)
        {
            //Base Case
            if (head == null)
                return null;

            Node p = head;

            //Create Duplicate Nodes and Insert

            while (p != null)
            {
                Node copyNode = new Node(p.val, p.next, null);
                p.next = copyNode;
                p = copyNode.next;
            }

            //Point Random Pointers
            p = head;

            while (p != null)
            {
                if (p.random != null)
                    p.next.random = p.random.next;
                p = p.next.next;
            }

            //Break List and Return
            p = head;
            Node copyHead = head.next;
            while (p != null)
            {
                //new node.
                Node temp = p.next;
                //like original list
                p.next = temp.next;
                if (temp.next != null)
                    temp.next = temp.next.next;

                p = p.next;
            }
            return copyHead;
        }
    }
}
