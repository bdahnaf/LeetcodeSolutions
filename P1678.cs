/**
 * 
 * Problem URL - https://leetcode.com/problems/goal-parser-interpretation/
 * Problem Id - 1678
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
    internal class P1678
    {
        public string Interpret(string command)
        {
            string ans = "";
            for(int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    ans += 'G';
                } 
                else if (command[i] == '(')
                {
                    if(command[i+1] == ')')
                    {
                        ans += 'o';
                        i++;
                    }
                    else if (command[i+1] == 'a')
                    {
                        ans += "al";
                        i = i + 3;
                    }
                }
            }
            return ans;
        }
    }
}
