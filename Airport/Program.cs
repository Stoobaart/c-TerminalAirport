using System;

namespace Airport
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Amazing flight planner! Please Choose an Airport!");
			Airport richmondAirport = new Airport("Richmond", "United Kingdom");
			Airport whateverAirport = new Airport("Whatever", "Wherever");

			Airport[] airports = new Airport[2];
			airports[0] = richmondAirport;
			airports[1] = whateverAirport;

			for (int i = 0; i < airports.Length; i++)
			{
				Console.WriteLine(airports[i].ToString());
			}
		}
	}
}
