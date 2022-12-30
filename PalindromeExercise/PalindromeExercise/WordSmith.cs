using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    internal class WordSmith
    {
        public bool IsAPalindrome(string word) 
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
           
        }
        
    }
}
