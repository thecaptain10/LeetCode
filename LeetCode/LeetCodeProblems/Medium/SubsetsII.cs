using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/subsets-ii/
    //Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).
    public class SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);

            DFS(nums, 0, new List<int>(), res);

            return res;
        }

        private void DFS(int[] nums, int start, IList<int> oneResult, IList<IList<int>> result)
        {

            result.Add(new List<int>(oneResult));

            for (int i = start; i < nums.Length; i++)
            {
                //Ignore duplicates to avoid duplicate sets.
                if (i > start && nums[i] == nums[i - 1]) continue;
                oneResult.Add(nums[i]);
                DFS(nums, i + 1, oneResult, result);
                oneResult.RemoveAt(oneResult.Count - 1);
            }
        }
    }
}
