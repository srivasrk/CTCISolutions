using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_04_PalPermut
    {
        private bool CheckPalPermut(string input)
        {
            var map = new Dictionary<char, int>();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }

                var c = Char.ToLower(input[i]);

                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            var numberOfOddOccurances = 0;

            foreach (var value in map.Values)
            {
                if (value % 2 != 0)
                {
                    numberOfOddOccurances++;
                    if (numberOfOddOccurances > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Run()
        {
            var s = "Taco Coa";
            Console.WriteLine("{0}: Palindrome Permutation: {1}", s, CheckPalPermut(s));
            s = "Taco Coat";
            Console.WriteLine("{0}: Palindrome Permutation: {1}", s, CheckPalPermut(s));
            s = "Taco Coal";
            Console.WriteLine("{0}: Palindrome Permutation: {1}", s, CheckPalPermut(s));
            s = "A b c c d a b";
            Console.WriteLine("{0}: Palindrome Permutation: {1}", s, CheckPalPermut(s));
            s = "abcfgabcfgpq";
            Console.WriteLine("{0}: Palindrome Permutation: {1}", s, CheckPalPermut(s));
            
            Console.ReadLine();
        }
    }
}
