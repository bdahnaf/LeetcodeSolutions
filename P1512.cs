/**
 * 
 * Problem URL - https://leetcode.com/problems/number-of-good-pairs/
 * Problem Id - 1512
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
    internal class P1512
    {
        // A pair (i, j) is called good if nums[i] == nums[j] and i < j.
        public int NumIdenticalPairs(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i < j && nums[i] == nums[j])
                    {
                        Console.WriteLine(i + " " + j);
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
