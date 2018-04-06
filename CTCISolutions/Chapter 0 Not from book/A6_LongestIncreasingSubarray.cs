using System;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A6_LongestIncreasingSubarray
    {
        private int LIS(int[] input)
        {
            var lis = new int[input.Length];
            var maxLength = 0;
            
            for(int index = 0; index < input.Length; index++)
            {
                lis[index] = 1;
            }

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j])
                    {
                        lis[i] = Math.Max(lis[i], 1 + lis[j]);                       
                    }
                }
            }

            for(int i = 0; i < lis.Length; i++)
            {
                if (maxLength < lis[i])
                {
                    maxLength = lis[i];
                }
            }

            return maxLength;

        }

        public int LengthOfLIS(int[] nums)
        {

            int[] lis = new int[nums.Length];

            for (int i = 0; i < lis.Length; i++)
            {
                lis[i] = 1;
            }

            for (int i = 1; i < lis.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        lis[i] = Math.Max(lis[i], lis[j] + 1);
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < lis.Length; i++)
            {
                if (max < lis[i])
                {
                    max = lis[i];
                }
            }

            return max;

        }

        public void Run()
        {
            var nums = new int[] {3, 5, 1, 6, 9, 2, 4, 7, 5 , 2, 7, 9, 11, 3, 2 };
            Console.WriteLine(LengthOfLIS(nums));
        }
    }
}
