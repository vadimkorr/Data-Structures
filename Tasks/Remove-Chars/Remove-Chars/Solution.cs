using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Chars
{
    public class Solution
    {
        public static string RemoveChars(string str, string remove)
        {
            char[] s = str.ToArray();
            char[] r = remove.ToArray();
            int dst = 0;
            // flags automatically initialized to false, size of 128 assumes ASCII
            bool[] flags = new bool[128];
            // Set flags for characters to be removed 
            for (int src = 0; src < r.Length; ++src)
                flags[r[src]] = true;
            // Now loop through all the characters, 
            // copying only if they aren’t flagged 
            for (int i = 0; i < s.Length; ++i)
                if (!flags[s[i]])
                    s[dst++] = s[i];
            return new string(s, 0, dst);
        }
    }
}
