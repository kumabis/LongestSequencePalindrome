using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSequencePalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "ababcbababada";
            List<string> palindromeStrings = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(str[i]);
                if (isPalindrome(sb.ToString()))
                {
                    palindromeStrings.Add(sb.ToString());
                }
                for (int j = i + 1; j < str.Length; j++)
                {
                    sb.Append(str[j]);
                    if (isPalindrome(sb.ToString()))
                    {
                        palindromeStrings.Add(sb.ToString());
                    }
                }
            }

            bool isPalindrome(string s)
            {
                //string[] strArr = s.Split();
                StringBuilder sb = new StringBuilder();
                int len = s.Length;
                for (int i = len - 1; i >= 0; i--)
                {
                    sb.Append(s[i]);
                }
                return (s == sb.ToString());
            }

            string longestPalindrome = "";
            foreach(string item in palindromeStrings)
            {
                int maxLength = item.Length;
                if (maxLength > longestPalindrome.Length)
                {
                    longestPalindrome = item;
                }
            }
            Console.WriteLine("Longest sub-sequence palindrome is : {0}", longestPalindrome);
            Console.ReadKey();
        }
    }
}
