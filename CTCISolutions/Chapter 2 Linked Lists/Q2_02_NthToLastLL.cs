using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_02_NthToLastLL
    {
        private LinkedListNode NthToLast(LinkedListNode head, int n)
        {
            LinkedListNode ForwardRunner = head;
            int i = 0;

            while (i < n)
            {
                if (ForwardRunner == null)
                {
                    return null;
                }
                else
                {
                    ForwardRunner = ForwardRunner.Next;
                    i++;
                }
            }

            while(ForwardRunner != null)
            {
                head = head.Next;
                ForwardRunner = ForwardRunner.Next;
            }

            return head;
        }

        /*
         Write an algorithm to find the kth to last element of a singly linked list.
             */
        public void Run()
        {
            var head = AssortedMethods.RandomLinkedList(10, 0, 10);
            Console.WriteLine(head.PrintForward());            
            const int nth = 3;

            var node = NthToLast(head, nth);

            if (node != null)
            {
                Console.WriteLine(nth + "th to last node is " + node.Data);
            }
            else
            {
                Console.WriteLine("Null.  n is out of bounds.");
            }
        }
    }
}
