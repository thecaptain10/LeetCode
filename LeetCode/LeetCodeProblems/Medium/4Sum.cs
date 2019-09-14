using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/4sum/
    //Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            //Same Logic as 3 Sum
            var n = nums.Length;
            Array.Sort(nums);

            var result = new List<IList<int>>();

            for (int i = 0; i < n; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i]) continue;
                for (int j = i + 1; j < n; j++)
                {
                    if (j > i + 1 && nums[j - 1] == nums[j]) continue;
                    var left = j + 1;
                    var right = n - 1;

                    while (left < right)
                    {
                        var sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });

                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
