using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/combination-sum-ii/
    //Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.Each number in candidates may only be used once in the combination.
    // O(2^n) - 2 choice for each element
    public class CombinationSumII
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();

            Array.Sort(candidates);

            CombinationSum2DFSHelper(candidates, target, 0, new List<int>(), res);
            
            return res;

        }

        private void CombinationSum2DFSHelper(int[] candidates, int target, int index, List<int> current, IList<IList<int>> res)
        {
            //All elements in current 's sum =0
            if(target == 0)
            {
                res.Add(new List<int>(current));
                return;
            }

            //Sum of all current's element exceeded the target.
            if (target < 0)
                return;

            for(int i=index;i<candidates.Length;i++)
            {
                //Consider an element only once if there are duplicates
                if (i==index || candidates[i] != candidates[i-1])
                {
                    current.Add(candidates[i]);

                    //Add current element in consideration
                    CombinationSum2DFSHelper(candidates, target - candidates[i], i + 1, current, res);

                    //BackTrack // Don't consider current element
                    current.RemoveAt(current.Count() - 1);

                }
            }
        }
    }
}
