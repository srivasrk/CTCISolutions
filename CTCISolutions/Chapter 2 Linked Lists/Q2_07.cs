using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_07
    {
        private LinkedListNode Setup(int length)
        {
            var nodes = new LinkedListNode[length];

            for (var i = 0; i < length; i++)
            {
                nodes[i] = new LinkedListNode(i >= length / 2 ? length - i - 1 : i, null, null);
            }

            for (var i = 0; i < length; i++)
            {
                if (i < length - 1)
                {
                    nodes[i].SetNext(nodes[i + 1]);
                }

                if (i > 0)
                {
                    nodes[i].SetPrevious(nodes[i - 1]);
                }
            }
            //nodes[length - 1].Next = new LinkedListNode(9, null, null);
           
            var head = nodes[0];
            Console.WriteLine(head.PrintForward());
            return head;
        }

        private LinkedListNode Reverse(LinkedListNode node)
        {
            LinkedListNode prev = null;
            LinkedListNode curr = node;
            LinkedListNode next = node;

            while (next != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            //Console.WriteLine(prev.PrintForward());
            return prev;

        }

        private bool IsPalindrome(LinkedListNode head)
        {
            var fast = head;
            var slow = head;

            while ((fast != null) && (fast.Next != null))
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            
            var reversedHalf = Reverse(slow);

            while ((reversedHalf != null) && (head.Data == reversedHalf.Data))
            {
                head = head.Next;
                reversedHalf = reversedHalf.Next;
            }

            if (reversedHalf == null)
            {
                return true;
            }

            return false;
        }

        public void Run()
        {
            /*
             Implement a function to check if a linked list is a palindrome
            */

            var head = Setup(10);//Setup(11);
            var value = IsPalindrome(head);
            Console.WriteLine("This LL is a palindrome: {0}", value);           

        }
    }
}
