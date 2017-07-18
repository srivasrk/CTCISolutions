using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_03
    {
        //Keep the count of chars in each word in a dictionary.
        //for chars in word1, increment the count of chars, and 
        //for chars in word2, decrement the count of chars.
        //At the end, all values must be 0 if they are permutations
        private bool IsPermutation(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i = 0; i < word1.Length; i++)
            {
                if (map.ContainsKey(word1[i]))
                {
                    map[word1[i]]++;
                } 
                else
                {
                    map.Add(word1[i], 1);
                }

                if (map.ContainsKey(word2[i]))
                {
                    map[word2[i]]--;
                }
                else
                {
                    map.Add(word2[i], -1);
                }
            }

            foreach (int val in map.Values)
            {
                if (val != 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Given 2 strings, determine if one is permutation of the other.
        public void Run()
        {

            string[][] pairs =
                {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh"}
            };

            foreach(var pair in pairs)
            {
                bool res = IsPermutation(pair[0], pair[1]);
                Console.WriteLine("Permutations: {0} and {1}: {2}", pair[0], pair[1], res);
            }
        }

    }
}
