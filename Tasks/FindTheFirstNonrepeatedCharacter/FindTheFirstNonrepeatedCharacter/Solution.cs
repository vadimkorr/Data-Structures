using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheFirstNonrepeatedCharacter
{
    public class Solution
    {
        /// <summary>
        /// Write an efficient function to find the first nonrepeated character
        /// in a string. For instance, the first nonrepeated character in "total" is 'o'
        /// and the first one in "teeter" is 'r'. Discuss the efficiency of your algorithm.
        /// 
        /// It can be determined whether a particular character is repeated by comparing 
        /// it with all other characters in the string. Complexity is O(n^2)
        /// 
        /// The easiest way to improve search efficiency on a set of data is to put it in a data
        /// structure that allows more efficient searching. 
        /// </summary>
        public static char FindFirstNonRepeated(string str)
        {
            Dictionary<char, int> charHash = new Dictionary<char, int>();

            int length = str.Length;
            char c;

            // Scan str, building hash table
            for (int i = 0; i < length; i++)
            {
                c = str[i];
                if (charHash.ContainsKey(c))
                    // Increment count corresponding to c
                    charHash.Add(c, charHash[c] + 1);
                else
                    charHash.Add(c, 1);
            }
            // Search hash table in order of str
            for (int i = 0; i < length; i++)
            {
                c = str[i];
                if (charHash[c] == 1)
                    return c;
            }
            return default(char);
        }

        public static string FindFirstNonRepeated32(string str)
        {
            Dictionary<int, Object> charHash = new Dictionary<int, Object>();
            Object seenOnce = new Object(), seenMultiple = new Object();
            Object seen;
            int length = str.Length;
            // Scan str, building hash table
            for (int i = 0; i < length; i++)
            { //increment intentionally omitted
                int cp = (int)str[i];//get ASCII code
                //i += (byte)(cp & 0xFF) == 0 ? 1 : 2;//.charCount(cp); //increment based on code point
                seen = charHash.ContainsKey(cp) ? charHash[cp] : null;
                if (seen == null)
                    // not present
                    charHash.Add(cp, seenOnce);
                else
                {
                    if (seen == seenOnce)
                        charHash[cp] = seenMultiple;
                }
            }
            // Search hash table in order of str
            for (int i = 0; i < length; i++)
            {
                int cp = (int)str[i];
                //i += Char.charCount(cp);
                if (charHash[cp] == seenOnce)
                    return cp.ToString();
            }
            return null;
        }
    }
}
