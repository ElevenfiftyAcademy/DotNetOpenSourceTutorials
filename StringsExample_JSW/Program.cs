/*
BRONZE CHALLENGE:
	Create 5 different string variables and concatenate them into one string.
	REFERENCE: https://msdn.microsoft.com/en-us/library/ms173104.aspx

SILVER CHALLENGE:
	Create a note to a your future self that states your goals. Include the date in the string by creating a date string that is converted to a short date string.
	REFERENCE: https://msdn.microsoft.com/en-us/library/ms228504.aspx

GOLD CHALLENGE: 
	Create 2 strings: Your username for something in lower case, and your username in uppercase. Write code that compares two similar strings and prints whether or not they are equal. Print one sentence that says that they are equal. Print another string that says that they are not equal. 
	REFERENCE https://msdn.microsoft.com/en-us/library/cc165449.aspx
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringsExample_JSW
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string nameOne = "Andrew";
			string nameTwo = "Frank";
			string nameThree = "Paul";
			string sportOne = "football";
			string sportTwo = "basketball";

			Console.WriteLine("{0}, {1}, and {2} are all sports stars in Indianapolis. But only {0} and {1} play {3}, while {2} plays {4}.", nameOne, nameTwo, nameThree, sportOne, sportTwo);
			Console.WriteLine("");

			string greetings = "Hello Mr. Anderson,";
			string todaysDate = DateTime.Today.ToString();
			string body = "I'm enjoying class immensely. I'm hoping that after this class not only do I have a job as a .NET developer, but that I am also an expert in C#.";

			Console.WriteLine("{0} today is {1}. {2}", greetings, todaysDate, body);
			Console.WriteLine("");

			string userNameLowercase = "jordanwillis";
			string userNameUppercase = "JORDANWILLIS";

			bool resultOrdinal = userNameLowercase.Equals(userNameUppercase, StringComparison.Ordinal);
			bool resultOrdinalIgnore = userNameLowercase.Equals(userNameUppercase, StringComparison.OrdinalIgnoreCase);

			Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", userNameLowercase, userNameUppercase, resultOrdinal ? "equal." : "not equal.");
			Console.WriteLine("Ordinal ignore case: {0} and {1} are {2}", userNameLowercase, userNameUppercase, resultOrdinalIgnore ? "equal." : "not equal.");

			Console.ReadLine();
		}
	}
}
