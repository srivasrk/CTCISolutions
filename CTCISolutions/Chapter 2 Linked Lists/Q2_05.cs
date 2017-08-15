using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_05
    {

        private LinkedListNode AddLists(LinkedListNode list1, LinkedListNode list2, int carry)
        {
            if ((list1 == null) && (list2 == null) && (carry == 0))
            {
                return null;
            }

            var result = new LinkedListNode();
            var value = carry;

            if (list1 != null)
            {
                value += list1.Data;
            }
            if (list2 != null)
            {
                value += list2.Data;
            }

            result.Data = value % 10;            

            if (list1 != null || list2 != null)
            {
                var more = AddLists(list1 == null ? null : list1.Next,
                    list2 == null ? null : list2.Next,
                    value >= 10 ? 1 : 0);

                result.SetNext(more);
            }
            
            return result;
        }

        private LinkedListNode AddLists2(LinkedListNode list1, LinkedListNode list2, int carry)
        {
            return null;
        }

        private int LinkedListToInt(LinkedListNode node)
        {
            int value = 0;

            if (node.Next != null)
            {
                value = 10 * LinkedListToInt(node.Next);
            }

            return value + node.Data;
        }

        private int LinkedListToInt2(LinkedListNode node)
        {
            int value = 0;

            while (node != null)
            {
                value = value * 10 + node.Data;
                node = node.Next;
            }

            return value;
        }

        /*
         You have 2 numbers represented by a linked list, where each node contains a single digit.
         The digits are stored in reverse order, such that the 1's digit is at the head of the list.
         Write a function that adds the two numbers and returns the sum as a linked list.
         Example:
         Input: (7->1->6) + (5->9->2) that is 617 + 295
         Output: (2->1->9) that is 912

         Follow up:
         Suppose the digits are stored in forward order. Repeat the above problem.
         Input: (6->1->7) + (2->9->5) that is 617 + 295
         Output: (9->1->2) that is 912 

             */
        public void Run()
        {
            #region First Part

            {
                var lA1 = new LinkedListNode(9, null, null);
                var lA2 = new LinkedListNode(9, null, lA1);
                var lA3 = new LinkedListNode(9, null, lA2);

                var lB1 = new LinkedListNode(1, null, null);
                var lB2 = new LinkedListNode(0, null, lB1);
                var lB3 = new LinkedListNode(0, null, lB2);

                var list3 = AddLists(lA1, lB1, 0);

                Console.WriteLine("  " + lA1.PrintForward());
                Console.WriteLine("+ " + lB1.PrintForward());
                Console.WriteLine("= " + list3.PrintForward());

                var l1 = LinkedListToInt(lA1);
                var l2 = LinkedListToInt(lB1);
                var l3 = LinkedListToInt(list3);

                Console.Write(l1 + " + " + l2 + " = " + l3 + "\n");
                Console.WriteLine(l1 + " + " + l2 + " = " + (l1 + l2));
            }

            #endregion First Part

            #region Followup

            //{
            //    var lA1 = new LinkedListNode(3, null, null);
            //    var lA2 = new LinkedListNode(1, null, lA1);
            //    //LinkedListNode lA3 = new LinkedListNode(5, null, lA2);

            //    var lB1 = new LinkedListNode(5, null, null);
            //    var lB2 = new LinkedListNode(9, null, lB1);
            //    var lB3 = new LinkedListNode(1, null, lB2);

            //    var list3 = AddLists2(lA1, lB1, 0);

            //    Console.WriteLine("  " + lA1.PrintForward());
            //    Console.WriteLine("+ " + lB1.PrintForward());
            //    Console.WriteLine("= " + list3.PrintForward());

            //    var l1 = LinkedListToInt2(lA1);
            //    var l2 = LinkedListToInt2(lB1);
            //    var l3 = LinkedListToInt2(list3);

            //    Console.Write(l1 + " + " + l2 + " = " + l3 + "\n");
            //    Console.WriteLine(l1 + " + " + l2 + " = " + (l1 + l2));
            //}

            #endregion Followup
        }
    }
}
