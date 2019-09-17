using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/permutations-ii/
    //Given a collection of numbers that might contain duplicates, return all possible unique permutations.
    public class PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int n = nums.Length;
            Array.Sort(nums);
            PermuteHelper(nums, new bool[n], new List<int>(), res);

            return res;
        }

        private void PermuteHelper(int[] nums, bool[] visited, List<int> current, IList<IList<int>> res)
        {
            if (current.Count == nums.Length)
                res.Add(new List<int>(current));
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (visited[i]) continue;

                    //Skip Duplicates
                    if (i > 0 && nums[i - 1] == nums[i] && visited[i - 1]) continue;

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
