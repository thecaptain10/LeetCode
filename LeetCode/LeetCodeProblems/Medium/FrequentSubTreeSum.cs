using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/most-frequent-subtree-sum/
    //Given the root of a tree, you are asked to find the most frequent subtree sum.
    public class FrequentSubTreeSum
    {
        Dictionary<TreeNode, int> sums = new Dictionary<TreeNode, int>();
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null) return result.ToArray();
            //Traverse Tree while storing sum.
            Traverse(root);

            /* Compute frequencies of sum and max-frequency */
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            int maxFreq = int.MinValue;
            foreach (TreeNode n in sums.Keys)
            {
                int sum = sums[n];
                frequencies[sum] = frequencies.ContainsKey(sum) ? frequencies[sum] + 1 : 1;
                maxFreq = Math.Max(maxFreq, frequencies[sum]);
            }

            /* Collect the sums with max-frequency */
            foreach (int key in frequencies.Keys)
            {
                if (frequencies[key] == maxFreq)
                {
                    result.Add(key);
                }
            }
            return result.ToArray();
        }

        void Traverse(TreeNode n)
        {
            if (n.left != null) Traverse(n.left);
            if (n.right != null) Traverse(n.right);

            int sum = n.val;
            sum += n.left != null ? sums[n.left] : 0;
            sum += n.right != null ? sums[n.right] : 0;
            sums.Add(n, sum);
        }


    }
}
