using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int nData)
        {
            data = nData;
            next = null;
        }
    }
    public class LinkedList
    {
        Node head;
        public void push(int d)
        {
            Node node = new Node(d);
            //node.data = d;
            node.next = head;
            head = node;
        }

        public void printLL()
        {
            var iHead = head;
            if (iHead == null)
            {
                Console.WriteLine("LINKED LIST IS EMPTY!!");

                return;
            }

            while (iHead != null)
            {
                Console.Write("Element is : " + iHead.data + "\n");
                iHead = iHead.next;
            }
            Console.WriteLine();
        }

        public void add(int d)
        {
            if(head == null)
            {
                Console.WriteLine("Element is : " + head.data);
                return;
                //IEnumerable<List<int>> lists = 
                //  IEnumerator<>
            }

            while (head.next != null)
                head = head.next;

            var newNode = new Node(d);
            head.next = newNode;
        }
    }
}
