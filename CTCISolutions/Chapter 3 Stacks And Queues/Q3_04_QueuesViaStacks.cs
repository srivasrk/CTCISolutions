using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_3_Stacks_And_Queues
{
    class Q3_04_QueuesViaStacks
    {
        public class QueueViaStack
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            public void Enqueue(int value)
            {
                stack1.Push(value);
            }

            public int Dequeue()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                if (stack2.Count == 0)
                {
                    throw new Exception("Nothing in the queue!");
                }

                return stack2.Pop();
            }
        }

        public void Run()
        {
            var myQueue = new QueueViaStack();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enqueue: " + i);
                myQueue.Enqueue(i);
            }

            Console.WriteLine("**********************");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dequeue: " + myQueue.Dequeue());
            }
        }
    }
}
