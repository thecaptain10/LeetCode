using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            string res = string.Empty;

            List<string> numsString = new List<string>();

            for (int i = 0; i < nums.Length; i++)
                numsString.Add(nums[i].ToString());

            numsString.Sort(MyComparer);

            for (int i = 0; i < numsString.Count; i++)
                res += numsString[i];

            if (res[0] == '0' && res.Length > 1)
                return "0";

            return res;

        }

        public int MyComparer(string x, string y)
        {
            //Append X then Y
            string xy = x + y;
            //Append Y then X
            string yx = y + x;
            //Compare
            return xy.CompareTo(yx) > 0 ? -1 : 1;
        }
    }
}
