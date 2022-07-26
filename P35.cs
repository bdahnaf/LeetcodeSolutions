/**
 * 
 * Problem URL - https://leetcode.com/problems/search-insert-position/
 * Problem Id - 35
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
    internal class P35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int ans = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(target > nums[i])
                {
                    ans = i;
                }
            }
            return ++ans;
        }
    }
}
