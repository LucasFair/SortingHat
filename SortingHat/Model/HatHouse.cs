using System;

namespace SortingHat.Model
{
	/// <summary>
	/// Class <c>HatHouse</c> contains the data for the Sorting Hat.
	/// </summary>
	public class HatHouse
	{
		enum Houses { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }
		public void Run()
		{
			Random rnd = new Random();
			int hatSort;

			for (int i = 0; i < 10; i++)
			{
				hatSort = rnd.Next(0, 4);
				switch (hatSort)
				{
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						break;
					case 1:
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;
					case 2:
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					case 3:
						Console.ForegroundColor = ConsoleColor.Green;
						break;
				}
				Console.WriteLine((Houses)hatSort);
				Console.WriteLine(string.Empty);
				Console.ResetColor();
			}
		}
	}
}
