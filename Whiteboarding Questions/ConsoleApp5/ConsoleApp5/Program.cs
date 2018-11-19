using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            FillList();
            Console.WriteLine(LListAlgo(head, 5));
        }

        private static void FillList()
        {
            

        }

        private static bool LListAlgo(object head, int v)
        {
            throw new NotImplementedException();
        }

        public static LinkedList<Node> list = new LinkedList<Node>();
        
    }
    public class Node
    {
        int value;
        Node next;
    }

    public class LinkedList
    {
        private 
    }

    
}
