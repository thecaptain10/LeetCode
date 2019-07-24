using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/binary-tree-paths/
    //Given a binary tree, return all root-to-leaf paths.
    public class BinaryTreePathsRootToLeaf
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> res = new List<string>();
            PathsHelper(root, string.Empty, res);
            return res;
        }

        public void PathsHelper(TreeNode root, string str, IList<string> result)
        {
            if (root == null)
                return;
            //If Leaf Node, aDd to result.
            if (root.left == null && root.right == null)
            {
                str += root.val;
                result.Add(str);
                return;
            }

            //Add current node to string and recur for left and right child.
            PathsHelper(root.left, str + root.val + "->", result);
            PathsHelper(root.right, str + root.val + "->", result);
        }
    }
}
