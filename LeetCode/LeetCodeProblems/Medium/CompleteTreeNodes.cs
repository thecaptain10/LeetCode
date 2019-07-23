using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/count-complete-tree-nodes/
    //In a complete binary tree every level, except possibly the last, is completely filled, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.
    //Given a complete binary tree, count the number of nodes.
    public class CompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
                return 0;

            int count = 0;

            //Leaf Node
            if (root.left == null && root.right == null)
                count++;

            //Node with Both Childs Present
            if (root.left != null && root.right != null)
                count++;

            //Node With Left Child only
            if (root.left != null && root.right == null)
                count++;

            //Recur for Left and Right child
            count += (CountNodes(root.left) + CountNodes(root.right));

            return count;
        }
    }
}
