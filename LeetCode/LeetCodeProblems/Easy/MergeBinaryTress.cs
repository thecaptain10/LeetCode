using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/merge-two-binary-trees/
    //Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.Merge them
    //O(m) : m = min number of nodes among both trees
    public class MergeBinaryTress
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            else if (t2 == null)
                return t1;

            t1.val += t2.val;

            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);

            return t1;
        }
    }
}
