using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedList
{
    using System;

    class Node
    {
        public int data ;
        public Node Next;

        public Node(int data_in)
        {
            data = data_in;
        }

        public Node()
        {
        }
    }

    class LinkedList
    {
        private Node Head;

        public void InsertData(Node node)
        {
            Node aCurrentNode = Head;
            if (Head == null)
            {
                Head = new Node();
                Head = node;
            }
            else
            {
                while (aCurrentNode.Next != null)
                    aCurrentNode = aCurrentNode.Next;

                aCurrentNode.Next = new Node();
                aCurrentNode.Next = node;
            }
        }

        public void DisplayData()
        {
            Node aCurrentNode = Head;

            while (aCurrentNode != null)
            {
                Console.WriteLine("the value is {0}", aCurrentNode.data);
                aCurrentNode = aCurrentNode.Next;
            }
        }

        public void RemoveData(Node node)
        {
            if (Head == null)
                return;

            if (Head == node)
            {
                Head = Head.Next;
            }
            else
            {
                Node previous = Head;
                Node current = Head.Next;

                while (current != null)
                {
                    if (current == node)
                    {
                        // If we're removing the last entry in the list, current.Next
                        // will be null. That's OK, because setting previous.Next to 
                        // null is the proper way to set the end of the list.
                        previous.Next = current.Next;
                        break;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }
    }
    
    internal partial class Program
    {
        static void Main(string[] args)
        {
            LinkedList aLinkedList = new LinkedList();

            Node a = new Node(10);
            Node b = new Node(20);
            Node c = new Node(30);
            Node d = new Node(40);
            aLinkedList.InsertData(a);
            aLinkedList.InsertData(b);
            aLinkedList.InsertData(c);
            aLinkedList.InsertData(d);
            aLinkedList.DisplayData();


            Console.WriteLine();
            aLinkedList.RemoveData(a);
            aLinkedList.RemoveData(c);


            aLinkedList.DisplayData();

            Console.Read();
        }
    }
}
