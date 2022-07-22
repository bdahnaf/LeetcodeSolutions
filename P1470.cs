/**
 * 
 * Problem URL - https://leetcode.com/problems/shuffle-the-array/
 * Problem Id - 1470
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
    internal class P1470
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] ans = new int[n];
            int arrayIndex = 0;
            for(int i = 0; i < 2 * n; i++)
            {
                //ans[arrayIndex] = nums[i];
                //ans[arrayIndex + 1] = nums[i + n - 1];
                Console.WriteLine(arrayIndex);
                Console.WriteLine(arrayIndex + 1);
                arrayIndex = arrayIndex + 2;
            }
            return ans;

        }
    }
}
