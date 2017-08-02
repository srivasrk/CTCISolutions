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
