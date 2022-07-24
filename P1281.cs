/**
 * 
 * Problem URL - https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
 * Problem Id - 1281
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
    internal class P1281
    {
        public int SubtractProductAndSum(int n)
        {
            int ans = 0;
            int sum = 0;
            int product = 1;
            int digit = 0;
            while ( n > 0)
            {
                digit = n % 10;
                n = n / 10;
                product = product * digit;
                sum = sum + digit;
            }
            ans = product - sum;
            return ans;

        }
    }
}
