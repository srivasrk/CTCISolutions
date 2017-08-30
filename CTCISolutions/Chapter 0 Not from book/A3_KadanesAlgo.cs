using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A3_KadanesAlgo
    {
        private int GetMaxSubarraySum(int[] input)
        {
            //Kadane's Algorithm
            int LCurrent = input[0];
            int LMaxSum = int.MinValue;

            for(int i = 1; i < input.Length; i++)
            {
                LCurrent = Math.Max(input[i], LCurrent + input[i]);
                LMaxSum = Math.Max(LMaxSum, LCurrent);
            }

            return LMaxSum;
        }

        public void Run()
        {
            int[] num1 = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4};
            Console.WriteLine("Expected Output : 6");            
            Console.WriteLine("Actual Output: {0}", GetMaxSubarraySum(num1));
            Console.WriteLine();
        }
    }
}
