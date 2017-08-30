using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A2_CheckBinaryNumDivBy3
    {
        // Explanataion: 
        // A binary number is a multiple of 3 if and only if the alternating sum 
        // of its bits is also a multiple of 3:
        // 4   = 100       1 - 0 + 0 = 1, not multiple of 3
        // 6   = 110       1 - 1 + 0 = 0, multiple of 3
        // 78  = 1001110   1 - 0 + 0 - 1 + 1 - 1 + 0 = 0, multiple of 3
        // 109 = 1101101   1 - 1 + 0 - 1 + 1 - 0 + 1 = 1, not multiple of 3
        private bool IsDivisibleBy3(int[] input)
        {
            int total = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    total = total + input[i];
                }
                else
                {
                    total = total - input[i];
                }
            }

            if ((total % 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Run()
        {
            int[] num1 = new int[] { 1, 1, 0, 1, 1, 0, 1 };
            Console.WriteLine("Num1 : 109");
            for (int i = 0; i < num1.Length; i++)
            {
                Console.Write(num1[i]);
            }
            Console.WriteLine();
            Console.WriteLine(IsDivisibleBy3(num1));
            Console.WriteLine();

            int[] num2 = new int[] { 1, 1, 0 };
            Console.WriteLine("Num2 : 6");
            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write(num2[i]);
            }
            Console.WriteLine();
            Console.WriteLine(IsDivisibleBy3(num2));

            Console.ReadLine();
        }
    }
}
