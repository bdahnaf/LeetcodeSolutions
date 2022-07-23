/**
 * 
 * Problem URL - https://leetcode.com/problems/shuffle-the-array/
 * Problem Id - 1470
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
    internal class P1470
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] ans = new int[2 * n];
            int arrayIndex = 0;
            for(int i = 0; i < n; i++)
            {
                ans[arrayIndex] = nums[i];
                ans[arrayIndex + 1] = nums[i + n];
                arrayIndex = arrayIndex + 2;
            }
            return ans;

        }
    }
}
