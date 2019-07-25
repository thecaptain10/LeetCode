using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
    //Given a Binary Search Tree and a target number, return true if there exist two elements in the BST such that their sum is equal to the given target.
    public class TwoSumInBST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var nodes = new List<int>();
            Inorder(root, nodes);
            return AreTwoNodesPresent(nodes, k);
        }
        
        private void Inorder(TreeNode root, List<int> nodes)
        {
            if (root == null)
                return;
            Inorder(root.left, nodes);
            nodes.Add(root.val);
            Inorder(root.right, nodes);
        }

        private bool AreTwoNodesPresent(List<int> nodes, int target)
        {
            int start = 0;
            int end = nodes.Count - 1;

            while (start < end)
            {
                int current = nodes[start] + nodes[end];
                if (current == target)
                    return true;

                if (current < target)
                    start++;

                if (current > target)
                    end--;
            }

            return false;
        }
    }
}
