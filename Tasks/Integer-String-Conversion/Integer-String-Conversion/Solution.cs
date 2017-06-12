using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_String_Conversion
{
    /// <summary>
    /// Problem. Write two conversion routines. The 1st one converts a string to a signed integer.
    /// You may assume that the string containss only digits and the minus character ('-'), that it is
    /// a properly formatted integer number, and that the number is within the range of an int type.
    /// The second routine converts a signed integer stored as an int back to a string.
    /// </summary>
    public class Solution
    {
        public static int StrToInt(string str)
        {
            int i = 0, num = 0;
            bool isNeg = false;
            int len = str.Length;

            if (str[0] == '-')
            {
                isNeg = true;
                i = 1;
            }

            while (i < len)
            {
                num *= 10;
                num += (str[i++] - '0');
            }
            if (isNeg)
                num = -num;
            return num;
        }
    }
}
