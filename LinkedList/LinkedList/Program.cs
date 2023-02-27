using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1.Create Simple Linked List \n2.Create Linked List By Reversing Data \n3.Delete The First Node \n4.Delete The Last Node \n5.Searching The Element \n6.Inserting The Element After A Element \n7.Size Of The Elements \n8.Display Linked List By Adding Data \n9.Exit Creating Linked List");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        linkedlist.Add(70);
                        linkedlist.Add(30);
                        linkedlist.Add(56);
                        break;
                    case 2:
                        linkedlist.ReverseOrder(56);
                        linkedlist.ReverseOrder(30);
                        linkedlist.ReverseOrder(70);
                        break;
                    case 3:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveFirstNode();
                        break;
                    case 4:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveLastNode();
                        break;
                    case 5:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.SearchValue(30);
                        break;
                    case 6:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.AdditionAfterElement(30, 40);
                        break;
                    case 7:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.AdditionAfterElement(30, 40);
                        linkedlist.Size();
                        break;
                    case 8:
                        linkedlist.Display();
                        break;
                    case 9:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the correct option");
                        break;
                }
            }
        }
    }
}
