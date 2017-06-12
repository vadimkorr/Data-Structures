namespace Reverse_Words
{
    public class Solution
    {
        /// <summary>
        /// Problem. Write a function that reverses the order of the words in a string. 
        /// For example, your function should transform the string 
        /// "Do or do not, there is no try." to "try. no is there not, do or Do".
        /// Assume that all words are space delimited and treat punctuation the same as letters.
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseWords(ref string str)
        {
            int wordReadPos, wordEnd, writePos = 0;

            int strLen = str.Length;
            char[] buffer = new char[strLen];

            //Position of the last character is length - 1
            int tokenReadPos = strLen - 1;

            while (tokenReadPos >= 0)
            {
                //Non-word characters
                if (str[tokenReadPos] == ' ')
                    // Write character
                    buffer[writePos++] = str[tokenReadPos--];
                //Word characters
                else
                {  
                    //store position of end of word
                    wordEnd = tokenReadPos;
                    //Scan to next non-word character
                    while (tokenReadPos >= 0 && str[tokenReadPos] != ' ')
                        tokenReadPos--;
                    //tokenReadPos went past the start of the word
                    wordReadPos = tokenReadPos + 1;
                    //Copy the characters of the word
                    while (wordReadPos <= wordEnd)
                        buffer[writePos++] = str[wordReadPos++];
                }
            }
            str = new string(buffer);
        }

    }
}
