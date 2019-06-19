using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {

            //Base Cases
            if (height == null || height.Length < 2)
                return 0;

            int max = 0;

            //if height(left) < height(right) -> move right
            //if height(right) < height(left) -> move left

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                //Calculate Area
                max = Math.Max(max, (right - left) * (Math.Min(height[left], height[right])));

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return max;

        }
    }
}
