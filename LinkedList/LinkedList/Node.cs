using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int dataIn;
        public Node next;
        public Node(int data)
        {
            this.dataIn = data;
        }
        public Node(int data, Node next)
        {
            this.dataIn = data;
            this.next = next;
        }
    }
}
