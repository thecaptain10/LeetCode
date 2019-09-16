using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/combination-sum/
    //Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.The same repeated number may be chosen from candidates unlimited number of times.
    public class CombinationSumSets
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();

            Array.Sort(candidates);

            CombinationSum2DFSHelper(candidates, target, 0, new List<int>(), res);

            return res;

        }

        private void CombinationSum2DFSHelper(int[] candidates, int target, int index, List<int> current, IList<IList<int>> res)
        {
            //All elements in current 's sum =0
            if (target == 0)
            {
                res.Add(new List<int>(current));
                return;
            }

            //Sum of all current's element exceeded the target.
            if (target < 0)
                return;

            for (int i = index; i < candidates.Length; i++)
            {
                current.Add(candidates[i]);

                //Add current element in consideration. i in below call allows considering any element multiple no of times
                CombinationSum2DFSHelper(candidates, target - candidates[i], i, current, res);

                //BackTrack // Don't consider current element
                current.RemoveAt(current.Count() - 1);

            }
        }
    }
}
