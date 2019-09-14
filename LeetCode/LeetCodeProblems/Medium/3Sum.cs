using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/3sum/
    //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();

            if (nums == null || nums.Count() < 3)
                return res;

            //Sort the array
            Array.Sort(nums);

            for (int i = 0; i < nums.Count() - 2; i++)
            {
                //Fix First Element
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int low = i + 1;
                int high = nums.Count() - 1;

                //Since array is sorted, shrink based on sum value.
                while (low < high)
                {

                    if (nums[i] + nums[low] + nums[high] == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        low++;
                    }
                    else if (nums[i] + nums[low] + nums[high] <= 0)
                        low++;
                    else
                        high--;
                }
            }



            return res;

        }

    }
}
