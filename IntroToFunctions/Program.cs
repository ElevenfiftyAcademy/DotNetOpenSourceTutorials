using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToFunctions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a method/function that is void with no parameter
            // Void methods/functions do not require a return
            Tweet();

            // Create a method that is void that takes a parameter
            Tweet("Indianapolis Colts are the best NFL team!");

            // Your examples of void functions both with and without parameters





            // Public can be seen/used by all
            // Bool must return true or false
            Console.WriteLine("Everyone is happy, right? {0}", isHappy());
            Console.WriteLine("");

            // Ints must return a number
            Console.WriteLine("Total: {0}", StandardAdditionFunction(4568, 3485));
            Console.WriteLine("");

            // Your examples of a bool and int functions





            // Strings must return a string
            Console.WriteLine("My favorite show is {0}.", FavoriteShow("Archer"));
            Console.WriteLine("");

            // Your example of a string function





            Console.ReadLine();
        }

        public static void Tweet()
        {
            Console.WriteLine("Hello Everyone!");
            Console.WriteLine("");
        }

        public static void Tweet(string theWinner)
        {
            Console.WriteLine(theWinner);
            Console.WriteLine("");
        }

        public static bool isHappy()
        {
            return true;
        }

        public static int StandardAdditionFunction(int a, int b)
        {
            return a + b;
        }

        public static string FavoriteShow(string show)
        {
            return show;
        }
    }
}
