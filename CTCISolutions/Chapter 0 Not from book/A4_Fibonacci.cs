using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A4_Fibonacci
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        
        // Not efficient
        private int NthFibonacciNumberBasic(int n)
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
                return (NthFibonacciNumberBasic(n - 1) + NthFibonacciNumberBasic(n - 2));
            }
        }

        private int NthFibonacciNumberWithMemoization(int n)
        {
            if (memo.ContainsKey(n))
            {
                Console.WriteLine("Invalid index!");
                return memo[n];
            }
            else if (n < 1)
            {
                return 0;
            }
            else if ((n == 1) || (n == 2))
            {
                memo.Add(n, 1);
                return 1;
            }
            else
            {
                int k = NthFibonacciNumberWithMemoization(n - 1) +
                    NthFibonacciNumberWithMemoization(n - 2);
                memo.Add(n, k);
                return k;
            }
        }

        private int NthFibonacciNumberBottomUp(int n)
        {
            if (memo.ContainsKey(n))
            {
                Console.WriteLine("Invalid index!");
                return memo[n];
            }
            else if (n < 1)
            {
                return 0;
            }
            else
            {
                memo.Clear();
                memo.Add(1, 1);
                memo.Add(2, 1);
                int k = 0;

                for (int i = 3; i <= n; i++)
                {
                    k = memo[i - 1] + memo[i - 2];
                    memo.Add(i, k);
                }

                return k;
            }
        }

        public void Run()
        {
            Console.WriteLine("We will print nth fibonacci number!");
            for(int i = -1; i < 20; i++)
            {
                Console.WriteLine("{0}: {1} ", i, NthFibonacciNumberBasic(i));
                // Console.WriteLine("{0}: {1} ", i, NthFibonacciNumberWithMemoization(i));
                Console.WriteLine("{0}: {1} ", i, NthFibonacciNumberBottomUp(i));
            }
        }
    }
}
