using CTCISolutions.Library;
using System;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q4_01
    {
        private int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(GetHeight(root.Right), GetHeight(root.Left)) + 1;
        }

        private Boolean IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var heightDifference = GetHeight(root.Left) - GetHeight(root.Right);

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return (IsBalanced(root.Left) && IsBalanced(root.Right));
            }
        }

        private int CheckHeightDifference(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftHeight = CheckHeightDifference(root.Left);

            if (leftHeight == -1)
            {
                return leftHeight;
            }

            var rightHeight = CheckHeightDifference(root.Right);

            if (rightHeight == -1)
            {
                return leftHeight;
            }

            var heightDifference = Math.Abs(leftHeight - rightHeight);

            if (heightDifference > 1)
            {
                return -1;
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }

        }

        private Boolean IsBalancedImproved(TreeNode root)
        {
            if (CheckHeightDifference(root) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Run()
        {
            // Create balanced tree
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var root = TreeNode.CreateMinimalBst(array);
            Console.WriteLine("Root? " + root.Data);
            Console.WriteLine("Is balanced? " + IsBalanced(root));
            Console.WriteLine("Improved Is balanced? " + IsBalancedImproved(root));

            // Could be balanced, actually, but it's very unlikely...
            var unbalanced = new TreeNode(10);
            for (var i = 0; i < 10; i++)
            {
                unbalanced.InsertInOrder(AssortedMethods.RandomIntInRange(0, 100));
            }

            Console.WriteLine("Root? " + unbalanced.Data);
            Console.WriteLine("Is balanced? " + IsBalanced(unbalanced));
            Console.WriteLine("Improved Is balanced? " + IsBalancedImproved(unbalanced));
        }
    }
}
