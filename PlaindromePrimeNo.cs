using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    /// <summary>
    /// Palindrome Method to check how many prime no of range 1-1000 is palindrome.
    /// </summary>
    class PlaindromePrimeNo
    {
        public static bool Palindrome(int Num)
        {
            int temp = Num;
            int res = 0;
            while(temp>0)
            {
                int r = temp % 10;
                res = res * 10 + r;
                temp /= 10;
            }
            if(Num == res)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Anagrams the prime.To check prime  no of range 1-1000 are Anagram or not
        /// </summary>
        public static void AnagramPrime()
        {
            string a = Utility.PrimeRange();
            //to trim space at the end 
            a = a.TrimEnd(' ');
            string[] array = a.Split(" ");
            Console.WriteLine("Anagram in the give Prime Number: ");
            int num = 0;
            for(int i=0; i<array.Length - 1; i++)
            {
                string anagram = "";
                for(int j= i+1; j<array.Length; j++)
                {
                    string s1 = array[i];
                    string s2 = array[j];
                    bool res = Utility.AnagramStrings(s1, s2);
                    if(res == true)
                    {
                        anagram = array[i] + " " + array[j];
                        Console.WriteLine(anagram);
                    }

                }
            }
            Console.WriteLine("Palindrome i the give Prime Numbers: ");
            for(int i=0; i<array.Length; i++)
            {
                num = Convert.ToInt32(array[i]);
                if(Palindrome(num) == true)
                {
                    Console.WriteLine(num);
                }
            }
            
        }
    }
}
