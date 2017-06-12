using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Chars
{
    public class Solution
    {
        /// <summary>
        /// Problem. Write an efficient function that deletes characters from an ASCII
        /// string. Use the prototype:
        /// string removeChars(string str, string remove);
        /// where any character existing in remove must be deleted from str. 
        /// 
        /// Complexity is O(n+m). The number of characters in the ASCII character set
        /// is fixed, zeroing the array is constant time. You perform a constant time 
        /// assignment for each character in remove, so building the lookup array is O(m).
        /// Finally, you do at most one constant time lookup and one constant time copy 
        /// for each character in str, giving O(n) for this stage. Summing these parts         /// yields O(n + m), so the algorithm has linear running time.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="remove"></param>
        /// <returns></returns>
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
