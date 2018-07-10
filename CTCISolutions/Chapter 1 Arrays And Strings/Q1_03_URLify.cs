using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_03_URLify //Urlify
    {
        /*
         Step1: Count the number of spaces.
         Step2: Calculate the end index of the string including
                length for %20 for each space.
         Step3: Shift the chars to the end of the string.
                If Space is encoutered, add '%20'. We have
                accomodated enough length.
             */
        private void ReplaceSpaces(char[] input, int Length)
        {
            int SpaceCount = 0;

            for(int i = 0; i < Length; i++)
            {
                if (input[i] == ' ')
                {
                    SpaceCount++;
                }
            }

            if (SpaceCount == 0)
            {
                return;
            }


            //This will mark the end of the 'new' string which includes '%20'
            //for spaces.
            int index = Length + (SpaceCount * 2);
            for (int i = Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    input[index - 3] = '%';
                    input[index - 2] = '2';
                    input[index - 1] = '0';
                    index = index - 3;
                }
                else
                {
                    input[index - 1] = input[i];
                    index--;
                }
            }
        }

        /* URLify - Replace spaces with %20
         Write a method to replace all spaces in a string with '%20'. You 
         You may assume that the string has sufficient space at the end of 
         the string to hold the additional characters, and that you are 
         given the true length of the string.
         Example:
         Input: "Mr John Smith    " (notice the extra spaces at the end to accomodate '%20'
         Output: "Mr%20John%20Smith"
             */
        public void Run()
        {
            const string input = "abc d e f";
            var characterArray = new char[input.Length + 3 * 2 + 1];

            for (var i = 0; i < input.Length; i++)
            {
                characterArray[i] = input[i];
            }

            ReplaceSpaces(characterArray, input.Length);
            Console.WriteLine("{0} -> {1}", input, new string(characterArray));
        }
    }
}
