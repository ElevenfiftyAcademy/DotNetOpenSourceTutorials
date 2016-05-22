using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyVowelsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the phrase that you want the vowel count for:");

            string input = Console.ReadLine();

            CountVowels(input);

            Console.ReadLine();
        }

        public static void CountVowels(string input)
        {
            int total = 0;

            char[] vowels = new char[10];

            vowels[0] = 'A';
            vowels[1] = 'a';
            vowels[2] = 'E';
            vowels[3] = 'e';
            vowels[4] = 'I';
            vowels[5] = 'i';
            vowels[6] = 'O';
            vowels[7] = 'o';
            vowels[8] = 'U';
            vowels[9] = 'u';

            foreach (char c in input)
            {
                foreach (char e in vowels)
                {
                    if (c == e)
                    {
                        total++;
                    }
                }
            }

            Console.WriteLine(total);
        }
    }
}
