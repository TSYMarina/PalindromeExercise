using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {

            var revWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                revWord += word[i];
            }
            if (word.ToLower() == revWord.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

            // attempt at refactoring...:

            //var reversed = word.Reverse().ToString().ToLower();
            //var answer = word == reversed ? true : false;
            //return answer;



        }
    }
}
