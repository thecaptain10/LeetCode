using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/subsets/
    //Given a set of distinct integers, nums, return all possible subsets (the power set).
    public class SubSet
    {
        public IList<IList<int>> Subsets(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();

            DFS(nums, 0, new List<int>(), res);

            return res;

        }

        private void DFS(int[] nums, int start, IList<int> oneResult, IList<IList<int>> result)
        {
            result.Add(new List<int>(oneResult));

            for (int i = start; i < nums.Length; i++)
            {
                oneResult.Add(nums[i]);
                DFS(nums, i + 1, oneResult, result);
                oneResult.RemoveAt(oneResult.Count - 1);
            }
        }
    }
}
