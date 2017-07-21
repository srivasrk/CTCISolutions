using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_01
    {
        /*
         * Time Complexity: O(n)
         * Space Compexity: O(n)
         */
        private void DeleteDupsA(LinkedListNode list)
        {
            if ((list == null) || (list.Next == null))
            {
                return;
            }

            LinkedListNode current = list;
            LinkedListNode previous = null;
            HashSet<int> dataset = new HashSet<int>();

            while (current != null)
            {
                if (dataset.Contains(current.Data))
                {
                    previous.Next = current.Next;
                }
                else
                {
                    dataset.Add(current.Data);
                    previous = current;
                }
                current = current.Next;

            }

        }

        /*
         * Time Complexity: O(n^2)
         * Space Compexity: O(1)
         */
        private void DeleteDupsB(LinkedListNode list)
        {
            if ((list == null) || (list.Next == null))
            {
                return;
            }

            LinkedListNode current = list;
            LinkedListNode runner = list;
            int data;

            while (current != null)
            {
                data = current.Data;
                runner = current;

                while (runner.Next != null)
                {
                    if (runner.Next.Data == data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;

            }

        }


        /*
         Write a code to remove duplicates from a LinkedList.
         Follow up: How would you solve this problem if temporary 
                    buffer (dictionary, hashset etc) is not allowed
             */
        public void Run()
        {
            var first = new LinkedListNode(0, null, null);
            var originalList = first;
            var second = first;

            for (var i = 1; i < 8; i++)
            {
                second = new LinkedListNode(i % 2, null, null);
                first.SetNext(second);
                second.SetPrevious(first);
                first = second;
            }

            var list1 = originalList.Clone();
            var list2 = originalList.Clone();
            var list3 = originalList.Clone();

            DeleteDupsA(list1);
            DeleteDupsB(list2);

            Console.WriteLine(originalList.PrintForward());
            Console.WriteLine("");
            Console.WriteLine("Method A:");
            Console.WriteLine(list1.PrintForward());
            Console.WriteLine("");
            Console.WriteLine("Method B:");
            Console.WriteLine(list2.PrintForward());         
        }
    }
}
