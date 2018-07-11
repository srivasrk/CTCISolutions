
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
            var solution12_2 = new Q1_02_ArePermutations2();
            var solution13 = new Q1_03_URLify();
            var solution14 = new Q1_04_PalPermut();
            var solution15 = new Q1_05_OneEditAway();
            var solution16 = new Q1_06_Compression();
            var solution17 = new Q1_07_RotateMatrix();
            var solution18 = new Q1_08_ZeroMatrix();
            var solution19 = new Q1_09_StringRotation();
            #endregion

            #region CHAPTER-2
            var solution21 = new Q2_01_RemoveDupsLL();
            var solution22 = new Q2_02_NthToLastLL();
            var solution23 = new Q2_03_DeleteNode();
            var solution24 = new Q2_04_QuickSelectLL();
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

            solution24.Run();
            Console.ReadKey();
        }
    }
}
