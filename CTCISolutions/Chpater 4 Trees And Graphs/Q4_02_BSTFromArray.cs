using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chpater_4_Trees_And_Graphs
{
    class Q4_02_BSTFromArray
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int d)
            {
                data = d;
                left = null;
                right = null;
            }
        }

        private Node BuildBSTFromSortedArray(int[] ar, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            var node = new Node(ar[mid]);

            node.left = BuildBSTFromSortedArray(ar, start, mid - 1);
            node.right = BuildBSTFromSortedArray(ar, mid + 1, end);

            return node;
        }

        private void Inorder(Node node)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left);
            Console.Write(node.data + " ");
            Inorder(node.right);
        }
        
        public void Run()
        {
            var ar = new int[] {1,2,3,4,5,6,7,8,9,10};
            var node = BuildBSTFromSortedArray(ar, 0, ar.Length - 1);
            Inorder(node);
        }

    }
}
