/**
 * 
 * Problem URL - https://leetcode.com/problems/running-sum-of-1d-array/
 * Problem Id - 1480
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
    internal class P1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int runningSum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                runningSum = runningSum + nums[i];
                ans[i] = runningSum;
            }
            return ans;
        }
    }
}
