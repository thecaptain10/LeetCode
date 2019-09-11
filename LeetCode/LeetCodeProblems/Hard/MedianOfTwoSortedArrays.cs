using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/    //Median of Two Sorted Arrays
    //O(n)
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            double m1 = -1;
            double m2 = -1;

            int i = 0;
            int j = 0;

            //If m+n is odd, so middle elment will be median        
            if ((m + n) % 2 == 1)
            {
                for (int count = 0; count <= (m + n) / 2; count++)
                {
                    if (i != m && j != n)
                    {
                        m1 = (nums1[i] > nums2[j]) ? nums2[j++] : nums1[i++];
                    }
                    else if (j < n)
                    {
                        m1 = nums2[j++];
                    }
                    else
                        m1 = nums1[i++];
                }
                return m1;
            }
            else
            {
                //If m+n is even, avg of middle two elements when arrays are merged will be median.
                for (int count = 0; count <= (m + n) / 2; count++)
                {
                    m2 = m1;
                    if (i != m && j != n)
                    {
                        m1 = (nums1[i] > nums2[j]) ? nums2[j++] : nums1[i++];
                    }
                    else if (j < n)
                    {
                        m1 = nums2[j++];
                    }
                    else
                        m1 = nums1[i++];
                }
                return (m1 + m2) / 2;
            }

        }
    }
}
