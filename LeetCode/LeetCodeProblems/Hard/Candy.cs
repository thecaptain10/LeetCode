using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    public class CandyClass
    {
        public int Candy(int[] ratings)
        {
            if (ratings == null || ratings.Length == 0)
                return 0;

            int res = 0;
            int[] candies = new int[ratings.Length];

            //Left to Right Scan 
            candies[0] = 1;

            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    candies[i] = candies[i - 1] + 1;
                else
                    candies[i] = 1;
            }

            res += candies[ratings.Length - 1];
            // Right To Left Scan 

            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                int cur = 1;
                if (ratings[i] > ratings[i + 1])
                {
                    cur = candies[i + 1] + 1;
                }

                res += Math.Max(cur, candies[i]);
                candies[i] = cur;
            }

            return res;


        }
    }
}
