using System;

namespace AirportApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Amazing flight planner! Airports on the database are:");

			/* Initialise Airports */
			Airport londonAirport = new Airport("London City Airport", "United Kingdom");
			Airport romeAirport = new Airport("Rome International", "Italy");

			Airport[] airports = new Airport[2];
			airports[0] = londonAirport;
			airports[1] = romeAirport;

			/* Initialise Terminals */
			Terminal londonTerminal1 = new Terminal("Terminal 1", 4000);
			Terminal londonTerminal2 = new Terminal("Terminal 2", 3000);
			airports[0].terminals[0] = londonTerminal1;
			airports[0].terminals[1] = londonTerminal2;

			Terminal romeTerminal1 = new Terminal("Terminal 1", 5000);
			Terminal romeTerminal2 = new Terminal("Terminal 2", 2500);
			airports[1].terminals[0] = romeTerminal1;
			airports[1].terminals[1] = romeTerminal2;


			/* Print Airports */
			for (int i = 0; i < airports.Length; i++)
			{
				Console.WriteLine((i + 1) + ") " + airports[i].ToString());
			}

			Console.WriteLine("Please type the number of the Airport that you would like to check");
			var chosenNumber = Console.ReadLine();
			var airport = airports[Int32.Parse(chosenNumber) - 1];
			Console.WriteLine("Please see the information for " + airport);

			/* Print Terminals */
			for (int i = 0; i < airport.terminals.Length; i++)
			{
				Console.WriteLine((i + 1) + ") " + airport.terminals[i].ToString());
			}

			Console.WriteLine("Please choose which number terminal you would like to view info for");
			chosenNumber = Console.ReadLine();
			var terminal = airport.terminals[Int32.Parse(chosenNumber) - 1];
			Console.WriteLine("Please see the options for " + terminal);

			/* Print Flights */
			for (int i = 0; i < terminal.flights.Count; i++)
			{
				Console.WriteLine((i + 1) + ") " + terminal.flights[i].ToString());
			}

			Console.WriteLine("Please choose which number flight you would like to view info for");
			Console.WriteLine("0) Create a new flight");
			chosenNumber = Console.ReadLine();
			if (Int32.Parse(chosenNumber) == 0)
			{
				Console.WriteLine("Please Create a Flight");
				Console.WriteLine("Destination?");
				var destination = Console.ReadLine();
				Console.WriteLine("Airline");
				var airline = Console.ReadLine();
				Flight newFlight = new Flight(airport.airportName, destination, airline);
				terminal.AddFlight(newFlight);
				Console.WriteLine(terminal.flights[0].ToString());
			}
			else {
				var flight = terminal.flights[Int32.Parse(chosenNumber) - 1];
				Console.WriteLine("Please see the options for " + flight);
			}
		}

	}
}
