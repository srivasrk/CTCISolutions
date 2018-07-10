using System;
using System.Collections.Generic;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_02_ArePermutations
    {
        private bool ArePermutations(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var map = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (map.ContainsKey(s1[i]))
                {
                    map[s1[i]]++;
                }
                else
                {
                    map.Add(s1[i], 1);
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (map.ContainsKey(s2[i]))
                {
                    map[s2[i]]--;
                }
                else
                {
                    return false;
                }
            }

            foreach(var value in map.Values)
            {
                if (value != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void Run()
        {
            #region INPUT SET 1
            var input1 = "abcdeabcde";
            var input2 = "aabbccddee";

            Console.WriteLine("{0} and {1}. Permutations? {2}",
                input1, input2, ArePermutations(input1, input2));
            #endregion

            #region INPUT SET 2
            var input3 = "xxxyyyzzzz";
            var input4 = "xyzxyzxyxz";

            Console.WriteLine("{0} and {1}. Permutations? {2}",
                input3, input4, ArePermutations(input3, input4));
            Console.ReadLine();
            #endregion
        }
    }
}
