using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A4_Fibonacci
    {
        private int Fibonacci(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Invalid index!");
                return 0;
            }
            else if ((n == 1) || (n == 2))
            {
                return 1;
            }         
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }

        public void Run()
        {
            Console.WriteLine("We will print nth fibonacci number!");
            for(int i = -1; i < 20; i++)
            {
                Console.WriteLine("{0}: {1} ", i, Fibonacci(i));
            }
        }
    }
}
