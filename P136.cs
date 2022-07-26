/**
 * 
 * Problem URL - https://leetcode.com/problems/single-number/
 * Problem Id - 136
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
    internal class P136
    {
        public int SingleNumber(int[] nums)
        {
            int tempSum = 0;
            int sumOfNumArray = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sumOfNumArray = sumOfNumArray + nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        tempSum = tempSum + nums[i] * 2;
                    }
                }
            }
            return sumOfNumArray - tempSum;

        }
    }
}
