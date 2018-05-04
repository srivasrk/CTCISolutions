using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_06
    {
        public LinkedListNode FindBeginning(LinkedListNode[] nodes)
        {
            var fastRunner = nodes[0];
            var slowRunner = nodes[0];

            while ((fastRunner != null) && (fastRunner.Next != null))
            {
                fastRunner = fastRunner.Next.Next;
                slowRunner = slowRunner.Next;
                if (fastRunner == slowRunner)
                {
                    //loop found
                    break;
                }
            }

            if ((fastRunner == null) || (fastRunner.Next == null))
            {
                //loop not found
                return null;
            }

            slowRunner = nodes[0];

            // *****IMP***** //
            /* Move slowRunner to Head. Keep fastRunner at Meeting Point. 
             * Each are k steps from the Loop Start. If they move at the 
             * same pace, they must meet at Loop Start. */
            while (slowRunner != fastRunner)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next;
            }

            return slowRunner;
        }
        

        /*
        Given a circular linked list, implement an algorithm which returns the node at
        the beginning of the loop.
        DEFINITION
        Circular linked list: A (corrupt) linked list in which a node's next pointer points
        to an earlier node, so as to make a loop in the linked list.
        EXAMPLE
        Input: A - > B - > C - > D - > E - > C [the same C as earlier]
        Output: C
         */

        public LinkedListNode[] SetupQuestion()
        {
            const int listLength = 10;
            const int k = 3;

            // Create linked list
            var nodes = new LinkedListNode[listLength];

            for (var i = 1; i <= listLength; i++)
            {
                nodes[i - 1] = new LinkedListNode(i, null, i - 1 > 0 ? nodes[i - 2] : null);
                Console.Write("{0} -> ", nodes[i - 1].Data);
            }
            Console.WriteLine("Loop");

            // Create loop;
            nodes[listLength - 1].Next = nodes[listLength - k - 1];
            Console.WriteLine("{0} -> {1}", nodes[listLength - 1].Data, nodes[listLength - k - 1].Data);

            return nodes;
        }

        public void Run()
        {
            var nodes = SetupQuestion();

            var loop = FindBeginning(nodes);
            if (loop == null)
            {
                Console.WriteLine("No Cycle.");
            }
            else
            {
                Console.WriteLine(loop.Data);
            }
            Console.ReadKey();

        }
    }
}
