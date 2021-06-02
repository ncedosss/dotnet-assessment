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
            int results = 0;
            if (!string.IsNullOrEmpty(value))
            {
                //Declaration
                string[] vowel = { "a", "e", "i", "o", "u" };

                //Convert value to charArray and lower cases
                var charValue = value.ToLower().ToCharArray();

                //Loop through the value string and search indexes found on the vowel array
                for (int i = 0; i < value.Length; i++)
                {
                    if (Array.IndexOf(vowel, charValue[i].ToString()) > -1)
                    {
                        results++;
                    }
                }
            }
            else
                throw new ArgumentException();

            return results;
        }
    }
}
