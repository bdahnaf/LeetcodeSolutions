/**
 * 
 * Problem URL - https://leetcode.com/problems/create-target-array-in-the-given-order/
 * Problem Id - 1389
 * Author - Ahnaf Shahriar
 * Status - Trying
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class P1389
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Inserting at " + index[i] + " Value = " + nums[i]);
                ans[index[i]] = nums[i];
            }
            return ans;
        }
    }
}
