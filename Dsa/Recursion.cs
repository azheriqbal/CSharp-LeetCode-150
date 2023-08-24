using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Recursion
    {
        public static int Factorial(int n)
        {
            // Base case: Factorial of 0 or 1 is 1

            if (n == 0 || n == 1)
                return 1;

            // Recursive case: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }

        public static void PrintNumber(int n)
        {
            if (n == 0)
                return;
            Console.WriteLine(n);
            PrintNumber(n - 1);
        }
    }
}
