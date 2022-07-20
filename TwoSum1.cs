/**
 * 
 * Problem URL - https://leetcode.com/problems/two-sum/
 * Problem Id - 1
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
    internal class TwoSum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int arrayCount = nums.Count();
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < arrayCount; i++)
            {
                Console.WriteLine("Array index" + i);
                for (int j = 0; j < arrayCount; j++)
                {
                    if ((nums[i] + nums[j]) == target && i != j)
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }
            int[] output = { firstIndex, secondIndex };
            return output;
        }
    }
}
