using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_06
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
        }
    }
}
