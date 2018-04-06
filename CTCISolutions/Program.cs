using CTCISolutions.Chapter_0_Not_from_book;
using CTCISolutions.Chapter_1_Arrays_And_Strings;
using CTCISolutions.Chapter_2_Linked_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NOT-FROM-BOOK
            //var solution = new A1_QuickSort();
            //var solution = new A2_CheckBinaryNumDivBy3();
            //var solution = new A3_KadanesAlgo();
            //var solution = new A4_Fibonacci();
            //var solution = new A5_MinStepsToOne();
            //var solution = new A6_LongestIncreasingSubarray();
            var solution = new A7_LongestCommonSubsequence();
            #endregion

            #region CHAPTER-1
            //var solution = new Q1_01();
            //var solution = new Q1_03();
            //var solution = new Q1_04();
            //var solution = new Q1_05();
            //var solution = new Q1_06();
            //var solution = new Q1_07();
            //var solution = new Q1_08();
            #endregion

            #region CHAPTER-2
            //var solution = new Q2_01();
            //var solution = new Q2_02();
            //var solution = new Q2_03();
            //var solution = new Q2_04();
            //var solution = new Q2_05();
            #endregion

            solution.Run();
            Console.ReadKey();
        }
    }
}
