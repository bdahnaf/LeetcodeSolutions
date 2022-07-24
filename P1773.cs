/**
 * 
 * Problem URL - https://leetcode.com/problems/count-items-matching-a-rule/
 * Problem Id - 1773
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
    internal class P1773
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int ans = 0;
            foreach (var list in items)
            {
                if(ruleKey == "type")
                {
                    if (list[0] == ruleValue)
                    {
                        ans++;
                    }
                }
                else if(ruleKey == "color")
                {
                    if (list[1] == ruleValue)
                    {
                        ans++;
                    }
                }
                else if (ruleKey == "name")
                {
                    if (list[2] == ruleValue)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
