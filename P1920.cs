/**
 * 
 * Problem URL - https://leetcode.com/problems/build-array-from-permutation/
 * Problem Id - 1920
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
    internal class P1920
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }
}
