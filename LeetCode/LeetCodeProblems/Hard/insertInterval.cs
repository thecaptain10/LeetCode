using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/insert-interval/
    //Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
    public class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var n = intervals.Length;

            if (n == 0)
            {
                return new int[][] { newInterval };
            }

            var result = new List<int[]>();

            // 1. insert
            var isAdded = false;
            for (int i = 0; i < n; i++)
            {
                if (intervals[i][0] > newInterval[0])
                {
                    // first item larger than newInterval
                    isAdded = true;
                    result.Add(newInterval);
                }
                result.Add(intervals[i]);
            }

            // 1.1 tail?
            if (!isAdded)
            {
                result.Add(newInterval);
            }

            // 2. merge
            result = MergeIntervals(result);
            return result.ToArray();

        }

        private List<int[]> MergeIntervals(List<int[]> intervals)
        {
            var n = intervals.Count;
            if (n <= 1) return intervals;

            var result = new List<int[]>();
            result.Add(intervals[0]);

            for (int i = 1; i < n; i++)
            {
                var cur = intervals[i];
                var lastFromResult = result.Last();

                if (lastFromResult[1] >= cur[0])
                {
                    lastFromResult[1] = Math.Max(lastFromResult[1], cur[1]);
                }
                else
                {
                    result.Add(cur);
                }
            }

            return result;
        }
    }
}
