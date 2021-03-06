﻿using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_04_QuickSelectLL
    {
        private LinkedListNode Partition(LinkedListNode headNode, int pivotData)
        {

            LinkedListNode leftList = null;
            LinkedListNode rightList = null;
            LinkedListNode rightListHead = null;
            LinkedListNode pivotNode = null;
            LinkedListNode currentNode = headNode;
            LinkedListNode nextNode = null;

            while (currentNode != null)
            {
                Console.WriteLine("Checking: " + currentNode.Data);
                nextNode = currentNode.Next;
                currentNode.Next = null;

                if (currentNode.Data < pivotData)
                {
                    if (leftList == null)
                    {
                        leftList = currentNode;
                        headNode = currentNode;
                    }
                    else
                    {
                        leftList.Next = currentNode;
                        leftList = leftList.Next;
                    }
                }
                else if (currentNode.Data > pivotData)
                {
                    if (rightList == null)
                    {
                        rightListHead = currentNode;
                        rightList = currentNode;
                    }
                    else
                    {
                        rightList.Next = currentNode;
                        rightList = rightList.Next;
                    }
                }
                else
                {
                    pivotNode = currentNode;
                }

                currentNode = nextNode;
            }

            pivotNode.Next = rightListHead;
            rightListHead = pivotNode;
            leftList.Next = rightListHead;

            return headNode;

        }


        /*
         Write code to partition a linked list around a value X, such that
         all nodes less than X come before, and all nodes greater than X comes
         after X.
             */
        public void Run()
        {
            /* Create linked list */
            int[] vals = { 8, 1, 3, 7, 5, 2, 9, 4 };
            var head = new LinkedListNode(vals[0], null, null);
            var current = head;

            for (var i = 1; i < vals.Length; i++)
            {
                current = new LinkedListNode(vals[i], null, current);
            }
            Console.WriteLine(head.PrintForward());
            
            /* Partition */
            var h = Partition(head, 5);

            /* Print Result */
            Console.WriteLine(h.PrintForward());
        }
    }
}
