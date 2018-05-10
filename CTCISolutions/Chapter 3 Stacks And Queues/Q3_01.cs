using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q3_01
    {
        private static int size = 10;
        private int[] stackPointer = { -1, -1, -1 };
        private int[] buffer = new int[size * 3];

        private int TopOfStackIndex(int stackNumber)
        {
            return (stackNumber * size) + stackPointer[stackNumber];
        }

        public void Push(int stackNumber, int value)
        {
            if (stackPointer[stackNumber] + 1 >= size)
            {
                throw new Exception("Stack is full");
            }

            stackPointer[stackNumber]++;
            buffer[TopOfStackIndex(stackNumber)] = value;
        }

        public int Pop(int stackNumber)
        {
            if (stackPointer[stackNumber] == -1)
            {
                throw new Exception("Stack is empty");
            }

            var value = buffer[TopOfStackIndex(stackNumber)];
            buffer[TopOfStackIndex(stackNumber)] = 0;
            stackPointer[stackNumber]--;
            return value;
        }

        public int Peek(int stackNumber)
        {

            return buffer[TopOfStackIndex(stackNumber)];
        }

        public bool IsStackEmpty(int stackNumber)
        {
            return (stackPointer[stackNumber] == -1);
        }

        public void Run()
        {
            //Describe how you could use a single array to implement three stacks.

            Push(2, 4);
            Console.WriteLine("Peek 2: " + Peek(2));
            Push(0, 3);
            Push(0, 7);
            Push(0, 5);
            Console.WriteLine("Peek 0: " + Peek(0));
            Pop(0);
            Console.WriteLine("Peek 0: " + Peek(0));
            Pop(0);
            Console.WriteLine("Peek 0: " + Peek(0));
        }
    }
}
