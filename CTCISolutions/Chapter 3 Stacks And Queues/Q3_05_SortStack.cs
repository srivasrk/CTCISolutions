using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_3_Stacks_And_Queues
{
    class Q3_05_SortStack
    {
        private void SortStack(Stack<int> stack)
        {
            var tempStack = new Stack<int>();

            while (stack.Count > 0)
            {
                var tempValue = stack.Pop();

                if (tempStack.Count == 0)
                {
                    tempStack.Push(tempValue);
                }
                else if (tempStack.Peek() < tempValue)
                {
                    tempStack.Push(tempValue);
                }
                else
                {
                    while (tempStack.Count > 0)
                    {
                        stack.Push(tempStack.Pop());
                    }
                    tempStack.Push(tempValue);
                }
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
        }

        public void Run()
        {
            var stack = new Stack<int>();
            Console.WriteLine("Push: 33");
            stack.Push(33);
            Console.WriteLine("Push: 3");
            stack.Push(3);
            Console.WriteLine("Push: 43");
            stack.Push(43);
            Console.WriteLine("Push: 203");
            stack.Push(203);
            Console.WriteLine("Push: 13");
            stack.Push(13);

            Console.WriteLine("Sorted: ");
            SortStack(stack);
            while (stack.Count > 0)
            {
                Console.WriteLine("Pop: " + stack.Pop());
            }
        }
    }
}
