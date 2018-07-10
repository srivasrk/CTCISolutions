
using CTCISolutions.Chapter_1_Arrays_And_Strings;
using CTCISolutions.Chapter_2_Linked_Lists;
using System;

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
            //var solution = new A7_LongestCommonSubsequence();
            #endregion

            #region CHAPTER-1
            var solution11 = new Q1_01_UniqueChars();
            var solution12 = new Q1_02_ArePermutations();
            var solution13 = new Q1_03();
            var solution14 = new Q1_04();
            var solution15 = new Q1_05();
            var solution16 = new Q1_06();
            var solution17 = new Q1_07();
            var solution18 = new Q1_08();
            #endregion

            #region CHAPTER-2
            var solution21 = new Q2_01();
            var solution22 = new Q2_02();
            var solution23 = new Q2_03();
            var solution24 = new Q2_04();
            var solution25 = new Q2_05();
            var solution26 = new Q2_06();
            var solution27 = new Q2_07();
            #endregion

            #region CHAPTER-3
            //var solution = new Q3_01();
            //var solution = new Q3_02();

            #endregion

            #region CHAPTER-4
            var solution = new Q4_01();

            #endregion

            solution12.Run();
            Console.ReadKey();
        }
    }
}
