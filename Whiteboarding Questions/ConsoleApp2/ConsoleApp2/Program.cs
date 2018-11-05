using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static LinkedList<int> list1 = new LinkedList<int>();
        public static LinkedList<int> list2 = new LinkedList<int>();

        public static Dictionary<LinkedListNode<int>, LinkedListNode<int>> list = new Dictionary<LinkedListNode<int>, LinkedListNode<int>>();

        static void Main(string[] args)
        {
            LinkedListNode<int> foo = fill(head1, head2);
            if (foo == null)
                Console.WriteLine("Lists do not intersect.");
            else
                Console.WriteLine($"{foo}");
        }

        private static LinkedListNode<int> fill(LinkedListNode<int> head1, LinkedListNode<int> head2)
        {
            while (head1 != head2)
            {
                    head2 = head2.Next;
                if (head2 == null)
                {
                    head2 = list2.First;
                    head1 = head1.Next;
                }
                if (head1 == null)
                {
                    break;
                }
            }
            return head1;
        }
    }
}
