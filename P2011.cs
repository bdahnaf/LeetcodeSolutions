/**
 * 
 * Problem URL - https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
 * Problem Id - 2011
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
    internal class P2011
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int ans = 0;
            foreach (string operation in operations)
            {
                if (operation[0] == '+')
                {
                    ans++;
                    continue;
                } 
                else if (operation[0] == '-')
                {
                    ans--;
                    continue;
                } 
                else if(operation[2] == '+')
                {
                    ans++;
                    continue;
                }
                else if (operation[2] == '-')
                {
                    ans--;
                    continue;
                }
            }
            return ans;
        }
    }
}
