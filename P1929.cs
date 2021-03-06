/**
 * 
 * Problem URL - https://leetcode.com/problems/concatenation-of-array/
 * Problem Id - 1929
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
    internal class P1929
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[(nums.Length)*2];
            for(int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }
            return ans;
        }
    }
}
