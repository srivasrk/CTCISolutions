using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_05_OneEditAway
    {
        private bool IsOneEditAway(string s1, string s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }

            if (Math.Abs(s1.Length - s2.Length) > 1)
            {
                return false;
            }
                        
            //Make sure s1 is the longer string
            if (s1.Length < s2.Length)
            {
                var temp = s2;
                s2 = s1;
                s1 = temp;
            }

            var foundOneEdit = false;
            var indexForS2 = 0;

            for (int indexForS1 = 0; (indexForS1 < s1.Length) && (indexForS2 < s2.Length); indexForS1++)
            {
                if (s1[indexForS1] == s2[indexForS2])
                {
                    indexForS2++;
                }
                else //char does not match
                {
                    if (foundOneEdit)
                    {
                        return false;
                    }

                    foundOneEdit = true;

                    if (s1.Length == s2.Length) //Replace operation
                    {
                        indexForS2++;
                    }
                    else //Remove operation
                    {
                        //do not increment
                    }

                }
            }

            return true;
        }

        public void Run()
        {
            var input1 = "pale";
            var input2 = "ple";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pales";
            input2 = "pale";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pale";
            input2 = "bale";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pale";
            input2 = "bake";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pale";
            input2 = "paless";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pale";
            input2 = "pale";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            input1 = "pale";
            input2 = "bake";
            Console.WriteLine("{0} and {1} - One Edit Away: {2}",
                input1, input2, IsOneEditAway(input1, input2));

            Console.ReadLine();
        }
    }
}
