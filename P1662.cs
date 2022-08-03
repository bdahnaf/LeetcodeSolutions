/**
 * 
 * Problem URL - https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
 * Problem Id - 1662
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
    internal class P1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            bool ans = false;
            string firstString = "";
            string secondString = "";
            foreach(var word in word1)
            {
                firstString += word;
            }
            foreach (var word in word2)
            {
                secondString += word;
            }
            if(firstString == secondString)
            {
                ans = true;
            }
            return ans;
        }
    }
}
