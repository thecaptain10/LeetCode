using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/unique-binary-search-trees-ii/
    //Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1 ... n.
    public class PrintUniqueBST
    {
        public IList<TreeNode> GenerateTrees(int n)
        {

            if (n == 0)
                return new List<TreeNode>();

            return ConstructTrees(1, n);

        }

        public IList<TreeNode> ConstructTrees(int start, int end)
        {
            IList<TreeNode> res = new List<TreeNode>();

            //Terminating Condition for Recursion.
            if (start > end)
            {
                res.Add(null);
                return res;
            }

            for (int i = start; i <= end; i++)
            {
                //Get All left Subtrees
                IList<TreeNode> leftTrees = ConstructTrees(start, i - 1);
                //Get All right Subtrees
                IList<TreeNode> rightTrees = ConstructTrees(i + 1, end);

                //Create Combinations
                for (int p = 0; p < leftTrees.Count; p++)
                {
                    //Left Tree
                    TreeNode left = leftTrees[p];
                    for (int q = 0; q < rightTrees.Count; q++)
                    {
                        //Right Tree
                        TreeNode right = rightTrees[q];

                        //Make i as root and attach left and right child
                        TreeNode root = new TreeNode(i);

                        root.left = left;
                        root.right = right;

                        //Add to res.
                        res.Add(root);
                    }
                }
            }

            return res;

        }
    }
}
