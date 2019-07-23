using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/path-sum-ii/
    //Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
    public class PathSumAllPaths
    {
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            PathSumHelper(root, sum, new List<int>());
            return result;
        }

        public void PathSumHelper(TreeNode root, int sum, List<int> ListTillNow)
        {

            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                //If LeafNode and Sum equals, Add current list to result
                if (root.val == sum)
                {
                    IList<int> list = new List<int>(ListTillNow) { root.val };
                    result.Add(list);
                }
                //If Leaf Node, Return
                return;
            }

            //Add to Current List.
            ListTillNow.Add(root.val);
            PathSumHelper(root.left, sum - root.val, ListTillNow);
            PathSumHelper(root.right, sum - root.val, ListTillNow);

            //if Sum is Not Equal, Remove last added element.
            ListTillNow.RemoveAt(ListTillNow.Count - 1);

        }
    }
}
