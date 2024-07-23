using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Algos
{
    internal class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            return str.ToLower() == new string(str.ToLower().Reverse().ToArray()) && 
                str.ToLower() == string.Join("", str.ToLower().Reverse());
        }
    }
}
