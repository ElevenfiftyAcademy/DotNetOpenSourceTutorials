/* Creating a NetflixShow Class

You will have 30 minutes to complete as much of this challenge as possible. While it is ok to ask for help from fellow classmates and instructors, we encourage you to find your own answer to this challenge.

	Bronze: Create a class called NetflixShow. Include a name, rating, and genre in the properties.   

	Silver: Create 3 NetflixShow objects with a variety of rating levels and genres. Print this information to the console in an organized way.
	
	Gold: Create a method that notifies a picky user who only wants to watch shows with a rating of 4 or above.
			For instance, if Dexter is rated 4.5, the console will read: 
			"You definitely need to watch this show!"
	
	Extra: Create another method that notifies a parent whether a show is kid appropriate or not.

If you get stuck, you might want to go at 2X speed through Bob Tabor's "Intro to Classes" video that you watched for HW.
Here's the link to that video: http://bit.ly/1nzswbi

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixChallenge_JSW
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Objects go here
			NetflixShow houseOfCards = new NetflixShow();
			houseOfCards.name = "House of Cards";
			houseOfCards.genre = "Drama";
			houseOfCards.rating = 5.0M;
			houseOfCards.Recommend();

			NetflixShow daredevil = new NetflixShow();
			daredevil.name = "Daredevil";
			daredevil.genre = "Superhero";
			daredevil.rating = 5.0M;
			daredevil.Recommend();

			NetflixShow dragonsRaceToTheEdge = new NetflixShow();
			dragonsRaceToTheEdge.name = "Dragons Race to the Edge";
			dragonsRaceToTheEdge.genre = "Kids";
			dragonsRaceToTheEdge.rating = 5.0M;
			dragonsRaceToTheEdge.Recommend();

			NetflixShow fullerHouse = new NetflixShow();
			fullerHouse.name = "Fuller House";
			fullerHouse.genre = "Family";
			fullerHouse.rating = 3.0M;
			fullerHouse.Recommend();

			Console.ReadLine();
		}

		// Classes and methods go here
		public class NetflixShow
		{
			public string name { get; set; }
			public string genre { get; set; }
			public decimal rating { get; set; }

			public string GoodRating()
			{
				if (this.rating >= 4)
				{
					return ("You definitely need to watch this show!");
				}
				else
				{
					return ("I wouldn't waste my time.");
				}
			}

			public string KidAppropriate()
			{
				if (this.genre == "Kids" || this.genre == "Family")
				{
					return ("This was made for your little ones.");
				}
				else
				{
					return ("It would not be the best idea for young minds to watch this.");
				}
			}

			public void Recommend()
			{
				Console.WriteLine("Show: {0} - Rating: {1} - Genre: {2}", this.name, this.rating, this.genre);
				Console.WriteLine(this.GoodRating());
				Console.WriteLine(this.KidAppropriate());
				Console.WriteLine("");
			}
		}
	}
}
