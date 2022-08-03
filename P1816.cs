/**
 * 
 * Problem URL - https://leetcode.com/problems/truncate-sentence/
 * Problem Id - 1816
 * Author - Ahnaf Shahriar
 * Status - Accepted
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class P1816
    {
        public string TruncateSentence(string s, int k)
        {
            string ans = "";
            int len = s.Length;
            int whitespace = 0;
            for(int i = 0; i <len; i++)
            {
                if (s[i] == ' ')
                {
                    whitespace++;
                }
                if (whitespace == k)
                {
                    break;
                }
                ans += s[i];
            }
            return ans;
        }
    }
}
