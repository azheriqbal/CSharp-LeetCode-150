using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class StringLeetCode
    {
        //28. Find the Index of the First Occurrence in a String
        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }

                }
            }

            return -1;
            /*return haystack.IndexOf(needle);*/
        }

        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            int[] charCount = new int[26];

            foreach(char c in s) 
            {
                charCount[c - 'a']++;
            }

            foreach(char c in t)
            {
                charCount[c - 'a']--;
            }

            foreach (int count in charCount)
            {
                if (count != 0)
                    return false;
            }

            return true;
        }

        public static bool IsValidParanthesis(string s)
        {
            var stack = new Stack<char>();
            foreach(char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }

                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }

                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false;
                }
            }
            return stack.Count ==0;
        }

        public static string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            string[] words = s.Trim().Split(' ');
            StringBuilder result = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    result.Append(words[i]);
                    if (i > 0)
                    {
                        result.Append(" ");
                    }
                }
            }

            return result.ToString();
        }
    }
}


/*In C#, StringBuilder is a class that provides an efficient way to
 * manipulate strings, especially when you need to perform a series
 * of append or modification operations. Unlike regular string
 * concatenation, which creates a new string each time you modify
 * it, StringBuilder allows you to modify a single string buffer
 * in memory, reducing the overhead associated with creating
 * new string instances.
 * 
 *  StringBuilder sb = new StringBuilder();

        // Appending strings
        sb.Append("Hello, ");
        sb.Append("world!");

        // Inserting strings at a specific position
        sb.Insert(7, "awesome ");

        // Removing characters
        sb.Remove(12, 7);

        // Replacing characters
        sb.Replace('o', 'O');

        // Converting StringBuilder to string
        string result = sb.ToString();
 * 
 * 
 */
