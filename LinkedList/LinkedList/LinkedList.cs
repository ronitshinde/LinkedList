using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
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
        public void RemoveLastNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            if (headNode.next == null)
            {
                headNode = null;
            }
            else
            {
                Node lastNode = this.headNode;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("The Last Element Is Deleted : " + lastNode.next);
            }
        }
        public void SearchValue(int value)
        {
            bool doesExists = false;
            if (headNode != null)
            {
                int count = 0;
                Node temp = headNode;
                while (temp != null)
                {
                    if (temp.dataIn == value)
                    {
                        doesExists = true;
                        count++;
                    }
                    temp = temp.next;
                }
                if (doesExists)
                    Console.WriteLine($"{value} exists {count} times");
                else
                    Console.WriteLine($"{value} is not present in List");
            }
        }
        public void Size()
        {
            Node temp = headNode;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.dataIn + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Total No Of Count : " + count);
        }
        public void AdditionAfterElement(int afterData, int data)
        {
            Node newNode = new Node(data);
            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = headNode;
                while (tempNode.dataIn != afterData)
                {
                    tempNode = tempNode.next;
                }
                if (tempNode.dataIn == afterData)
                {
                    Node afterNode = tempNode.next;
                    tempNode.next = newNode;
                    newNode.next = afterNode;
                }
                else
                    Console.WriteLine(" Data not found ");
            }
        }
    }
}
