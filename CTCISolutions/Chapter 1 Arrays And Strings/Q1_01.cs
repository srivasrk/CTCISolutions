using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_01
    {
        //This is with additional Data Structure
        private bool IsUniqueChars(string word)
        {
            if (word.Length > 256)
            {
                return false;
            }

            HashSet<char> SetOfChars = new HashSet<char>();

            foreach(char c in word.ToCharArray())
            {
                if (SetOfChars.Contains(c))
                {
                    return false;
                }
                else
                {
                    SetOfChars.Add(c);
                }
            }
            return true;
        }

        //tricky solution: appplicable for strings with lowercase chars ONLY
        //Use a 32 bit integer.
        //(1 << val) creates an int variable which has only val'th bit set to 1.
        //Bitwise AND with checker to see if the bit is already set, if yes then return false.
        //Checker sets its bit by doing a Bitwise OR with val
        private bool IsUniqueChars2(string word)
        {
            if (word.Length > 256)
            {
                return false;
            }

            int checker = 0;
            foreach (char c in word.ToCharArray())
            {
                int val = c - 'a';
                if ((checker & (1 << val)) > 0){
                    return false;
                }

                checker = checker | (1 << val);
            }
            return true;
        }


        //Q1_01: Implement an algorithm to determine if a string has all unique characters.
        //What if you can not use additional data structure.
        public void Run()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };
            
            foreach (string word in words)
            {
                Console.WriteLine("{0}: Unique Chars only? {1}, {2}", word, IsUniqueChars(word), IsUniqueChars2(word));
            }
        
        }
    }
}
