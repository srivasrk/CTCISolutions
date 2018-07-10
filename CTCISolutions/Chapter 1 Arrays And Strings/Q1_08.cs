using System;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_08
    {
        /*
         Solution:
         Word1 + Word1 = waterbottlewaterbottle.
         Check if Word2 is a rotation of the above string.
         */
        private bool IsRotation(string Word1, string Word2)
        {
            if (Word1.Length != Word2.Length)
            {
                return false;
            }

            string NewWord = Word1 + Word1;

            if (NewWord.IndexOf(Word2) >= 0)
            {
                return true;
            }

            return false;

        }
        
        /*
         Assume you have a method IsSubstring which checks if one word 
         is a substring of another word. Given 2 strings, word1 and word2, 
         write code to check if word2 is a rotation of word1 using only
         one call to IsSubstring.
         Eg: word1: "waterbottle" is a rotation of word2: "terbottlewa"
             */
        public void Run()
        {
            string[][] pairs =
            {
                new string[]{"apple", "pleap"},
                new string[]{"waterbottle", "erbottlewat"},
                new string[]{"camera", "macera"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var isRotation = IsRotation(word1, word2);
                Console.WriteLine("{0}, {1}: {2}", word1, word2, isRotation);
            }
        }
    }
}
