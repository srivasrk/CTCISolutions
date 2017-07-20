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

        public void Run()
        {
            const int size = 3;

            var matrix = AssortedMethods.RandomMatrix(size, size, 0, 9);

            AssortedMethods.PrintMatrix(matrix);

           // Rotate(matrix, size);
            Console.WriteLine();
            AssortedMethods.PrintMatrix(matrix);
        }
    }
}
