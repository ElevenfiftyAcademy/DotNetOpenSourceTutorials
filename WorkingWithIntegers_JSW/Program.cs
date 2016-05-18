/*
BRONZE:
	Create a variable that is initialized with a normal body temperature. 
	Print the temperature to the console in degrees Fahrenheit. 
	This number should have a decimal. For example, "98.2". 

SILVER: 
	Create a method that will print body temperature to the console when the method is called. 
	Your message should read like this: "Your body temperature is currently 98.6 degrees."
	
GOLD: 
Discuss the weather in the following way:
	1. Write a method that prints the current weather to the console.
	2. Write a method that checks whether or not it would be OK to wear shorts.
	3. Call both methods. Your console should read something like this:
		"The temperature outside is currently 65 degrees. It would be a great day for shorts"
//REFERENCE: https://msdn.microsoft.com/en-us/library/ms173104.aspx
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithIntegers_JSW
{
	public class Program
	{
		public static void Main(string[] args)
		{
			/* BRONZE */
			float bodyTemp = 98.6F;
			Console.WriteLine(bodyTemp);
			Console.WriteLine("");

			/* SILVER */
			PrintTemperature(98.6F);
			Console.WriteLine("");

			/* GOLD */
			CurrentWeather(70);
			OkToWearShorts(70);
			OkToWearShorts(55);

			Console.ReadLine();
		}

		public static void PrintTemperature(float bodyTemperature)
		{
			Console.WriteLine("Your body temperature is {0} degrees.", bodyTemperature);
		}

		public static void CurrentWeather(float currentTemp)
		{
			Console.WriteLine("The temperature outside is currently {0} degrees.", currentTemp);
		}

		public static void OkToWearShorts(float currentTemp)
		{
			if (currentTemp > 65)
			{
				Console.WriteLine("It would be a great day to wear shorts.");
			}
			else
			{
				Console.WriteLine("It would not be the best idea to wear shorts today.");
			}
		}
	}
}
