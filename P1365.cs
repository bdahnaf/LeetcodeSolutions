/**
 * 
 * Problem URL - https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
 * Problem Id - 1365
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class P1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int smallerNumberCount = 0;
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && i != j)
                    {
                        smallerNumberCount++;
                    }
                }
                ans[i] = smallerNumberCount;
            }
            return ans;
        }
    }
}
