using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loops_JSW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Demo: Do Loops
            var doLoopIteration = 0;

            do //Post-condition
            {
                Console.WriteLine("doLoopIteration = {0}", doLoopIteration++);
            } while (doLoopIteration < 5);

            Console.WriteLine("");

            //Demo: While Loops

            var whileLoopIteration = 0;

            while(whileLoopIteration < 5) //Pre-condition
            {
                Console.WriteLine("whileLoopIteration = {0}", whileLoopIteration++);
            }

            Console.WriteLine("");

            //Demo: For Loops

            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("");

            //Demo: Looping over a collection with for

            var survivors = new List<string> { "Rick", "Carl", "Glenn", "Maggie", "Daryl", "Carol" };

            for (var i = 0; i < survivors.Count; i++)
            {
                Console.WriteLine("Survivor: {0}", survivors[i]);
            }

            Console.WriteLine("");

            //Demo: ForEach Loop

            var myList = Enumerable.Range(0, 5);

            foreach(var x in myList)
            {
                Console.WriteLine("x = {0}", x);
            }

            Console.WriteLine("");

            //Demo: ForEach Loop 2
            //Strings are sequences of characters!

            foreach(var c in "Hello World!")
            {
                Console.WriteLine("c = {0}", c);
            }

            Console.WriteLine("");

            //Demo: What does foreach actually do?

            // Iterates over any enumerable type
            //What does that mean? Any type that implements the IEnumerable interface
            //Lists, arrays, dictionaries, even strings!

            //var enumerator = ((IEnumerable)"Hello World!").GetEnumerator();
            //Survivors is a List<string>
            var enumerator = ((IEnumerable < string >) survivors).GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine("Current = {0}", enumerator.Current);
            }

            Console.ReadLine();
        }
    }
}
