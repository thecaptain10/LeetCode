using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/merge-intervals/
    //Given a collection of intervals, merge all overlapping intervals.
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            int n = intervals.Length;

            //Only 1 Interval
            if (n <= 1)
                return intervals;

            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            var res = new List<int[]>();

            res.Add(intervals[0]);

            for (int i = 1; i < n; i++)
            {
                if (res.Last()[1] >= intervals[i][0])
                    res.Last()[1] = Math.Max(res.Last()[1], intervals[i][1]);
                else
                    res.Add(intervals[i]);

            }

            return res.ToArray();

        }
    }
}
