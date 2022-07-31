/**
 * 
 * Problem URL - https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
 * Problem Id - 1431
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
    internal class P1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> kids = new List<bool>();
            int flag = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                for (int j = 0; j < candies.Length; j++)
                {
                    if ((candies[i] + extraCandies) >= candies[j])
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                        break;
                    }
                }
                if(flag == 0)
                {
                    kids.Add(false);
                }
                else
                {
                    kids.Add(true);
                }
                flag = 0;
            }
            return kids;
        }
    }
}
