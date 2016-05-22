/*
BRONZE: 
	Use the char type to print "Hello World" going vertically down the page.

SILVER: 
	Do the same thing in a single line.
	
GOLD: 
	Print your name using an array built with chars. It's a type we haven't seen yet. 
	Use Unicode or hexidecimal numbers to print your name.

	Use the hexadecimal char array with a foreach loop to print your name going down the console. 

char: https://msdn.microsoft.com/en-us/library/x9h8tsay.aspx
foreach: https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForEachChallenge_JSW
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Bronze
			foreach (char c in "Hello World!")
			{
				Console.WriteLine(c);
			}

			Console.WriteLine("");

			// Silver
			foreach (char c in "Hello World!") Console.WriteLine("{0}", c);

			// Gold

			char[] unicodejordan = new char[7];

			unicodejordan[0] = '\u0020'; //adds a space
			unicodejordan[1] = '\u004a';
			unicodejordan[2] = '\u006f';
			unicodejordan[3] = '\u0072';
			unicodejordan[4] = '\u0064';
			unicodejordan[5] = '\u0061';
			unicodejordan[6] = '\u006e';

			foreach (char c in unicodejordan) Console.WriteLine(c);

			char[] hexajordan = new char[7];

			hexajordan[0] = '\x0020'; //adds a space
			hexajordan[1] = '\x004a';
			hexajordan[2] = '\x006f';
			hexajordan[3] = '\x0072';
			hexajordan[4] = '\x0064';
			hexajordan[5] = '\x0061';
			hexajordan[6] = '\x006e';

			foreach (char c in hexajordan) Console.WriteLine(c);

			Console.ReadLine();
		}
	}
}
