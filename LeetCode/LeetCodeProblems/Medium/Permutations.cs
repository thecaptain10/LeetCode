using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/permutations/
    //Given a collection of distinct integers, return all possible permutations.
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int n = nums.Length;
            PermuteHelper(nums, new bool[n], new List<int>(), res);

            return res;
        }

        private void PermuteHelper(int[] nums, bool[] visited, List<int> current, IList<IList<int>> res)
        {
            if (current.Count == nums.Length)
                res.Add(new List<int>(current));
            else
            {
                for(int i=0;i<nums.Length;i++)
                {
                    if (visited[i]) continue;

                    //Mark current element as visited and add it to current list under consideration
                    visited[i] = true;
                    current.Add(nums[i]);

                    PermuteHelper(nums, visited, current, res);

                    //BackTrack : UnMark current element as visited and remove it from current list under consideration
                    visited[i] = false;
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
