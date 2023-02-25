﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine("1.Create Simple Linked List \n2.Create Linked List By Reversing Data \n3 Display Linked List By Adding Data \n4.Exit Creating Linked List");
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
                        linkedlist.Display();
                        break;
                    case 4:
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
