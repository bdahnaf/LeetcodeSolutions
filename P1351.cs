/**
 * 
 * Problem URL - https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
 * Problem Id - 1351
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
    internal class P1351
    {
        public int CountNegatives(int[][] grid)
        {
            var count = 0;

            foreach (var arr in grid)
                foreach (var i in arr)
                    if (i < 0)
                        count++;

            return count;
        }
    }
}
