using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class P1528
    {
        public string RestoreString(string s, int[] indices)
        {
			char[] resultChars = new char[s.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				resultChars[indices[i]] = s[i];
			}

			return new string(resultChars);
		}
    }
}
