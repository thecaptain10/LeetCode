using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            int curr = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                //element is 0, so can't move forward.
                if (curr <= i && nums[i] == 0)
                    return false;
                // can move forward. Move Forward.
                if (i + nums[i] > curr)
                    curr = i + nums[i];
                //Exit Criteria
                if (curr >= nums.Length - 1)
                    return true;
            }
            return false;
        }
    }
}
