using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_1_Arrays_And_Strings
{
    class Q1_08_ZeroMatrix
    {
        public void SetZeros(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            List<int> rowList = new List<int>();
            List<int> colList = new List<int>();

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row][col] == 0)
                    {
                        rowList.Add(row);
                        colList.Add(col);
                    }
                }
            }

            for (int index = 0; index < rowList.Count; index++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[rowList[index]][col] = 0;
                }
            }

            for (int index = 0; index < colList.Count; index++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][colList[index]] = 0;
                }
            }

        }

        /*
         Write an algorithm such that if an element in an MxN matrix is 0, 
         the entire row and column are set to 0.
             */
        public void Run()
        {
            const int numberOfRows = 10;
            const int numberOfColumns = 15;
            var matrix1 = AssortedMethods.RandomMatrix(numberOfRows, numberOfColumns, 0, 100);
            
            AssortedMethods.PrintMatrix(matrix1);

            SetZeros(matrix1);

            Console.WriteLine();

            AssortedMethods.PrintMatrix(matrix1);
        }
    }
}
