using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            //Declaration
            int results = 0;
            string[] vowel = { "a", "e", "i", "o", "u" };

            var charValue = value.ToLower().ToCharArray();

            for (int i = 0; i < value.Length; i++)
            {
                //if (Array.IndexOf(vowel, charValue[i].ToString()) > 0)
                if (Array.IndexOf(vowel, charValue[i].ToString()) > -1)
                {
                    results++;
                }
            }
            return results;
        }
    }
}
