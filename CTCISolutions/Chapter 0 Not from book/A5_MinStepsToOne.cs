using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A5_MinStepsToOne
    {
        /*
         On a positive integer, you can perform any one of the following 3 steps. 
         1.) Subtract 1 from it. ( n = n - 1 )
         2.) If its divisible by 2, divide by 2. (if n%2 == 0 , then n = n/2) 
         3.) If its divisible by 3, divide by 3. (if n%3 == 0 , then n = n/3).
         Now the question is, given a positive integer n, find the minimum 
         number of steps that takes n to 1

        eg: 
        1.)For n = 1 , output: 0       
        2.) For n = 4 , output: 2  ( 4  /2 = 2  /2 = 1 )    
        3.)  For n = 7 , output: 3  (  7  -1 = 6   /3 = 2   /2 = 1 )
         */

        private int MinStepsToOne_DPWithMemo(Dictionary<int, int> memo, int num)
        {

            if (num == 1)
            {
                return 0;
            }
            else if (memo.ContainsKey(num))
            {
                return memo[num];
            }
            else
            {
                var min = 1 + MinStepsToOne_DPWithMemo(memo, num - 1);
                if ((num % 2) == 0)
                {
                    min = Math.Min(min, 1 + MinStepsToOne_DPWithMemo(memo, num / 2));
                }
                if ((num % 3) == 0)
                {
                    min = Math.Min(min, 1 + MinStepsToOne_DPWithMemo(memo, num / 3));
                }
                memo[num] = min;
                return min;
            }            
        }

        public void Run()
        {
            var num = 10;
            Console.WriteLine("Min steps to {0}:", num);

            var memo = new Dictionary<int, int>();
            var min = MinStepsToOne_DPWithMemo(memo, 10);
            Console.WriteLine(min);

        }
    }
}
