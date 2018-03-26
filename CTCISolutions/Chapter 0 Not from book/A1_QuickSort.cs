using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_0_Not_from_book
{
    class A1_QuickSort
    { 
        private void SwapNumbers(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        //Partition moves smaller items to the left of the pivot, and bigger items to the right.
        //Then it returns the pivot index
        private int Partition(int[] nums, int low, int high)
        {
            int i = low;
            int j = high;
            int pivot = nums[high];

            while (i < j)
            {
                if (nums[i] >= pivot)
                {
                    j--;
                    SwapNumbers(nums, i, j);
                }
                else
                {
                    i++;
                }
            }

            SwapNumbers(nums, i, high);

            return i;

        }

        private void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(nums, low, high);

                QuickSort(nums, low, p - 1);
                QuickSort(nums, p + 1, high);
            }
        }
        
        //Implement Quick sort
        public void Run()
        {
            int[] nums = new int[] { 3, 5, 10, 32, 0, 7, 91, 4 };
            Console.WriteLine("Before Sorting:");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            QuickSort(nums, 0, nums.Length-1);
            Console.WriteLine("\nAfter Sorting:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }
    }
}
