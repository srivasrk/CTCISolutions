using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_05
    {
        private string Compress(string input)
        {
            char Prev = input[0];
            int Count = 1;
            string result = "";

            for (int i = 1; i < input.Length; i++)
            {
                if (Prev == input[i])
                {
                    Count++;
                }
                else
                {
                    result = result + Prev + Count.ToString();
                    Prev = input[i];
                    Count = 1;
                }
            }

            result = result + Prev + Count.ToString();

            if (result.Length >= input.Length)
            {
                return input;
            }

            return result;
        }

        public void Run()
        {
            const string original = "abbccccccde";
            var compressed = Compress(original);
            Console.WriteLine("Original  : {0}", original);
            Console.WriteLine("Compressed: {0}", compressed);
        }
    }
}
