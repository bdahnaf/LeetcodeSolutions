/**
 * 
 * Problem URL - https://leetcode.com/problems/defanging-an-ip-address/
 * Problem Id - 1108
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
    internal class P1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
