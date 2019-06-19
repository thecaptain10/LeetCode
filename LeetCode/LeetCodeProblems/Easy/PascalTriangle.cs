using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {

            IList<IList<int>> res = new List<IList<int>>();

            if (numRows < 1)
                return res;

            //1st Row
            List<int> pre = new List<int>();
            pre.Add(1);
            res.Add(pre);


            for (int i = 2; i <= numRows; i++)
            {
                List<int> curr = new List<int>();
                curr.Add(1);  //First 1

                for (int j = 0; j < pre.Count - 1; j++)
                    curr.Add(pre[j] + pre[j + 1]);

                curr.Add(1); //Last 1
                res.Add(curr);
                pre = curr;
            }

            return res;
        }
    }
}
