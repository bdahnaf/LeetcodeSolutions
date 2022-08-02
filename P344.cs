/**
 * 
 * Problem URL - https://leetcode.com/problems/reverse-string/
 * Problem Id - 344
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
    internal class P344
    {
        public void ReverseString(char[] s)
        {
            int len = s.Length;
            Console.WriteLine(len);
            for (int i = len-1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
