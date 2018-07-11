using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q3_02_MinStack
    {
        private Stack<int> stack = new Stack<int>();        
        public int min = int.MaxValue;
        
        public void Push(int x)
        {
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }

            stack.Push(x);
        }

        public int Pop()
        {
            var x = stack.Pop();

            if (x == min)
            {
                min = stack.Pop();
            }

            return x;
        }

        public int Min()
        {
            return min;
        }

        public void Run()
        {
            /*
                How would you design a stack which, in addition to push and pop, also has a
                function min which returns the minimum element? Push, pop and min should
                all operate in O(1) time.
            */

            Push(4);
            Console.WriteLine("Push(4)");

            Console.WriteLine("Min: " + Min());

            Push(3);
            Console.WriteLine("Push(3)");

            Push(7);
            Console.WriteLine("Push(7)");

            Push(5);
            Console.WriteLine("Push(5)");

            Console.WriteLine("Min: " + Min());
                        
            Console.WriteLine("Pop:" + Pop());

            Console.WriteLine("Min: " + Min());

            Console.WriteLine("Pop:" + Pop());

            Console.WriteLine("Min: " + Min());

            Push(0);
            Console.WriteLine("Push(0)");

            Console.WriteLine("Min: " + Min());

            Console.WriteLine("Pop:" + Pop());

            Console.WriteLine("Min: " + Min());
        }
    }
}
