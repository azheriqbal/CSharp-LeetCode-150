using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class StringLeetCode
    {
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
