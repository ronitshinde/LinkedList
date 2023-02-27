using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node headNode;
        public void Add(int dataValue)
        {
            Node node = new Node(dataValue);
            if (this.headNode == null)
            {
                this.headNode = node;
            }
            else
            {
                Node temp = headNode;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} : inserted into linked list", node.dataIn);
        }
        public void ReverseOrder(int dataValue)
        {
            Node newNode = new Node(dataValue);
            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = this.headNode;
                headNode = newNode;
                headNode.next = tempNode;
            }
            Console.WriteLine(newNode.dataIn + " : is inserted into the linked list");
        }
        public void Display()
        {
            Node temp = this.headNode;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            Console.WriteLine("Linked List Is : ");
            while (temp != null)
            {
                Console.WriteLine(temp.dataIn + " ");
                temp = temp.next;
            }
        }
        public void RemoveFirstNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            this.headNode = this.headNode.next;
            Console.WriteLine("The First Element Is Deleted");
        }
    }
}
