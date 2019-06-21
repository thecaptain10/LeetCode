using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class DoublyLinkedList
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public DoublyLinkedList prev;
        public DoublyLinkedList next;

        public DoublyLinkedList(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class LRUCache
    {
        Dictionary<int, DoublyLinkedList> dict = new Dictionary<int, DoublyLinkedList>();
        DoublyLinkedList head;
        DoublyLinkedList tail;
        int capacity;
        int len;

        public LRUCache(int _capacity)
        {
            capacity = _capacity;
            len = 0;
        }

        public int Get(int key)
        {
            if (dict.ContainsKey(key))
            {
                DoublyLinkedList Node = dict[key];
                int val = Node.Value;
                RemoveNode(Node);
                SetHead(Node);

                return val;
            }
            else
                return -1;
        }

        public void Put(int key, int value)
        {
            if(dict.ContainsKey(key))
            {
                DoublyLinkedList existing = dict[key];

                //update value
                existing.Value = value;
                //Remove from existing position
                RemoveNode(existing);
                //Add  In front.
                SetHead(existing);

            }else
            {
                DoublyLinkedList Node = new DoublyLinkedList(key, value);
                if (len < capacity)
                {
                    SetHead(Node);
                    dict.Add(key, Node);
                    len++;
                }
                else
                {
                    dict.Remove(tail.Key);
                    tail = tail.prev;
                    if (tail != null)
                        tail.next = null;
                    SetHead(Node);
                    dict.Add(key, Node);
                }
            }
        }

        public void SetHead(DoublyLinkedList Node)
        {
            Node.next = head;
            Node.prev = null;

            if (head != null)
                head.prev = Node;
            head = Node;
            if (tail == null)
                tail = Node;
        }
        public void RemoveNode(DoublyLinkedList Node)
        {
            DoublyLinkedList curr = Node;
            DoublyLinkedList pre = Node.prev;
            DoublyLinkedList next = Node.next;

            //Handling head.
            if (pre != null)
            {
                pre.next = next;
            }
            else
            {
                //First Element 
                head = next;
            }

            //Handling Tail
            if (next != null)
                next.prev = pre;
            else
                tail = pre;

        }
    }

}
