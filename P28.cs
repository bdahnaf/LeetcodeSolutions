/**
 * 
 * Problem URL - https://leetcode.com/problems/implement-strstr/
 * Problem Id - 28
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
    internal class P28
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    //break the loop -- if at any point character of needle and haystack does not match 
                    if (haystack[i + j] != needle[j])
                        break;

                    if (j == needle.Length - 1)
                        return i;
                }
            }
            return -1;
        }
    }
}
