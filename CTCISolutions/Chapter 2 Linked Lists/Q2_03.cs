using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_03
    {
        private bool DeleteNode(LinkedListNode node)
        {
            if ((node == null) || (node.Next == null))
            {
                //Cannot delete the last node
                return false;
            }

            node.Data = node.Next.Data;
            node.Next = node.Next.Next;
            return true;

        }

        /*
         Implement an algo to delete a node in the middle of a singly linked list,
         given access to only that node.
         Example: Input the node c from the linked list a->b->c->d->e
         Result: nothing is returned but the new linked list looks like: a->b->d->e
             */

        public void Run()
        {
            var head = AssortedMethods.RandomLinkedList(10, 0, 10);
            Console.WriteLine(head.PrintForward());

            var deleted = DeleteNode(head.Next.Next.Next.Next); // delete node 4
            Console.WriteLine("deleted? {0}", deleted);
            Console.WriteLine(head.PrintForward());
        }
    }
}
