using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/merge-sorted-array/
    //Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    public class MergeSortedArrays
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //start from end to front
            int len = m + n;
            int i1 = m - 1;
            int i2 = n - 1;
            for (int i = len - 1; i >= 0; i--)
            {
                if (i1 >= 0 && i2 >= 0)
                {
                    if (nums1[i1] > nums2[i2])
                    {
                        nums1[i] = nums1[i1];
                        i1--;
                    }
                    else
                    {
                        nums1[i] = nums2[i2];
                        i2--;
                    }
                }
                else if (i1 >= 0)
                {
                    nums1[i] = nums1[i1];
                    i1--;
                }
                else
                {
                    nums1[i] = nums2[i2];
                    i2--;
                }
            }
        }
    }
}
