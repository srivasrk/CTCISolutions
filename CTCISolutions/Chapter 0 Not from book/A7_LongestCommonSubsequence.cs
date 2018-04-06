using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A7_LongestCommonSubsequence
    {
        Dictionary<Tuple<int, int>, int> memo = new Dictionary<Tuple<int, int>, int>();

        private int LengthOfLCS(string s1, string s2, int l1, int l2)
        {
            if ((l1 == 0) || (l2 == 0))
            {
                return 0;
            }
            else if (s1[l1-1] == s2[l2 - 1])
            {
                return (1 + LengthOfLCS(s1, s2, l1 - 1, l2 - 1));
            }
            else
            {
                var len1 = LengthOfLCS(s1, s2, l1, l2 - 1);
                var len2 = LengthOfLCS(s1, s2, l1 - 1, l2);
                return (Math.Max(len1, len2));
            }            
        }

        private int LengthOfLCSWithMemo(string s1, string s2, int l1, int l2)
        {
            var tuple = new Tuple<int, int>(l1, l2);
            if (memo.ContainsKey(tuple))
            {
                return memo[tuple];
            }
            else if ((l1 == 0) || (l2 == 0))
            {
                return 0;
            }
            else if (s1[l1 - 1] == s2[l2 - 1])
            {
                return (1 + LengthOfLCS(s1, s2, l1 - 1, l2 - 1));
            }
            else
            {
                var len1 = LengthOfLCSWithMemo(s1, s2, l1, l2 - 1);
                var len2 = LengthOfLCSWithMemo(s1, s2, l1 - 1, l2);
                
                var result = Math.Max(len1, len2);
                memo.Add(new Tuple<int, int>(l1, l2), result);
                return result;
            }
        }

        public void Run()
        {
            string s1 = "ABCDEFGHIS";
            string s2 = "ABCJDCHBIqweLKHD";
            var timer = new Stopwatch();

            timer.Start();
            var len1 = LengthOfLCS(s1, s2, s1.Length, s2.Length);
            timer.Stop();
            Console.WriteLine("LCS length: {0}, time taken: {1}", len1, timer.Elapsed);

            timer.Start();
            var len2 = LengthOfLCSWithMemo(s1, s2, s1.Length, s2.Length);
            timer.Stop();
            Console.WriteLine("LCS length: {0}, time taken: {1}", len2, timer.Elapsed);

        }
    }
}
