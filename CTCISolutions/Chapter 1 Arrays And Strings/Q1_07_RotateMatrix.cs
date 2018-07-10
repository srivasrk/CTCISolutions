using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_07_RotateMatrix
    {
        private void Rotate(int[][] matrix, int size)
        {
            for (int row = 0; row < size/2; row++)
            {
                int start = row;
                int end = size - row - 1;

                for (int col = start; col < end; col++)
                {
                    int offset = col - start;
                    int temp = matrix[start][col];

                    //(left bottom -> left top)
                    matrix[start][col] = matrix[end - offset][start];

                    //(right bottm -> left bottom)
                    matrix[end - offset][start] = matrix[end][end - offset];

                    //(right top -> right bottom)
                    matrix[end][end - offset] = matrix[col][end];

                    //(left top -> right top)
                    matrix[col][end] = temp;
                }
            }
        }

        private void Rotate2(int[][] matrix, int n)
        {
            int t;

            //for eg: start with 
            //1 2 3
            //4 5 6
            //7 8 9
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    t = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = t;
                }
            }
            //now we have 
            //3 2 1 
            //6 5 4 
            //9 8 7 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    t = matrix[i][j];
                    matrix[i][j] = matrix[n - j - 1][n - i - 1];
                    matrix[n - j - 1][n - i - 1] = t;
                }
            }
            //now we have 
            //7 4 1 
            //8 5 2 
            //9 6 3 

        }

        /*
         Rotate an NxN matrix by 90 degrees.
             */
        public void Run()
        {
            const int size = 3;

            var matrix = AssortedMethods.RandomMatrix(size, size, 0, 9);
            Console.WriteLine("Original Matrix:");
            AssortedMethods.PrintMatrix(matrix);

            Rotate(matrix, size);

            Console.WriteLine();
            Console.WriteLine("Rotated Matrix:");
            AssortedMethods.PrintMatrix(matrix);

            Rotate2(matrix, size);

            Console.WriteLine();
            Console.WriteLine("Rotated Again Matrix:");
            AssortedMethods.PrintMatrix(matrix);
        }
    }
}
