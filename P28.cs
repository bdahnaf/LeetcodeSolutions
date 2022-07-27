/**
 * 
 * Problem URL - https://leetcode.com/problems/implement-strstr/
 * Problem Id - 28
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
    internal class P28
    {
        public int StrStr(string haystack, string needle)
        {
            int ans = -1;
            if(needle == "")
            {
                ans = 0;
            } else
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        int innnerIndex = i + 1;
                        for (int j = 1; j < needle.Length; j++)
                        {
                            if (haystack[innnerIndex] != needle[j])
                            {
                                ans = -1;
                                break;
                            }
                            else
                            {
                                innnerIndex++;
                            }
                            ans = i;
                        }
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
