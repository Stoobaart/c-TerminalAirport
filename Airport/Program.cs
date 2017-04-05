using System;

namespace AirportApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
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

			/* Initialise Flights */
			Flight londonNewyork = new Flight("London City Airport", "New York", "Yankee Dreams");
			Flight londonChina = new Flight("London City Airport", "China", "Dim Sum Air");
			airports[0].terminals[0].AddFlight(londonNewyork);
			airports[0].terminals[0].AddFlight(londonChina);

			Flight londonJapan = new Flight("London City Airport", "Japan", "Robo Air");
			Flight londonNewzealand = new Flight("London City Airport", "New Zealand", "Lord of the Flights");
			airports[0].terminals[1].AddFlight(londonJapan);
			airports[0].terminals[1].AddFlight(londonNewzealand);

			Flight romeNewyork = new Flight("Rome International", "New York", "Yankee Dreams");
			Flight romeChina = new Flight("Rome International", "China", "Dim Sum Air");
			airports[1].terminals[0].AddFlight(romeNewyork);
			airports[1].terminals[0].AddFlight(romeChina);

			Flight romeJapan = new Flight("Rome International", "Japan", "Robo Air");
			Flight romeNewzealand = new Flight("Rome International", "New Zealand", "Lord of the Flights");
			airports[1].terminals[1].AddFlight(romeJapan);
			airports[1].terminals[1].AddFlight(romeNewzealand);

			/* Initialise Passengers */
			Passenger londonNewyorkPassengerOne = new Passenger("Bob", "Dilbert", "20/03/1980");
			Passenger londonNewyorkPassengerTwo = new Passenger("Michelle", "Pfiefer", "03/04/1974");
			airports[0].terminals[0].flights[0].AddPassenger(londonNewyorkPassengerOne);
			airports[0].terminals[0].flights[0].AddPassenger(londonNewyorkPassengerTwo);

			Passenger londonChinaPassengerOne = new Passenger("Robert", "DiNero", "02/06/1953");
			Passenger londonChinaPassengerTwo = new Passenger("Donald", "Trump", "17/09/1956");
			airports[0].terminals[0].flights[1].AddPassenger(londonChinaPassengerOne);
			airports[0].terminals[0].flights[1].AddPassenger(londonChinaPassengerTwo);

			Passenger londonJapanPassengerOne = new Passenger("Stuart", "Smith", "01/04/1983");
			Passenger londonJapanPassengerTwo = new Passenger("Christopher", "Tsoi", "03/04/1992");
			airports[0].terminals[1].flights[0].AddPassenger(londonJapanPassengerOne);
			airports[0].terminals[1].flights[0].AddPassenger(londonJapanPassengerTwo);

			Passenger londonNewzealandPassengerOne = new Passenger("Tom", "Middleton", "11/06/1991");
			Passenger londonNewzealandPassengerTwo = new Passenger("Gurpal", "Bahra", "30/11/1993");
			airports[0].terminals[1].flights[1].AddPassenger(londonNewzealandPassengerOne);
			airports[0].terminals[1].flights[1].AddPassenger(londonNewzealandPassengerTwo);

			Passenger romeNewyorkPassengerOne = new Passenger("Bob", "Dilbert", "20/03/1980");
			Passenger romeNewyorkPassengerTwo = new Passenger("Michelle", "Pfiefer", "03/04/1974");
			airports[1].terminals[0].flights[0].AddPassenger(romeNewyorkPassengerOne);
			airports[1].terminals[0].flights[0].AddPassenger(romeNewyorkPassengerTwo);

			Passenger romeChinaPassengerOne = new Passenger("Lucy", "Lui", "01/04/1978");
			Passenger romeChinaPassengerTwo = new Passenger("Ollie", "Holden", "03/07/2001");
			airports[1].terminals[0].flights[1].AddPassenger(romeChinaPassengerOne);
			airports[1].terminals[0].flights[1].AddPassenger(romeChinaPassengerTwo);

			Passenger romeJapanPassengerOne = new Passenger("Roberto", "Bagio", "02/06/1967");
			Passenger romeJapanPassengerTwo = new Passenger("Matheo", "Dimateo", "17/09/1971");
			airports[1].terminals[1].flights[0].AddPassenger(romeJapanPassengerOne);
			airports[1].terminals[1].flights[0].AddPassenger(romeJapanPassengerTwo);

			Passenger romeNewzealandPassengerOne = new Passenger("Michael", "Jackson", "17/08/1957");
			Passenger romeNewzealandPassengerTwo = new Passenger("Eddie", "Izzard", "25/12/1972");
			airports[1].terminals[1].flights[1].AddPassenger(romeNewzealandPassengerOne);
			airports[1].terminals[1].flights[1].AddPassenger(romeNewzealandPassengerTwo);

			bool finished = false;
			while (!finished)
			{
				Console.WriteLine("\nWelcome to the Amazing flight planner! Airports on the database are:");

				/* Print Airports */
				for (int i = 0; i < airports.Length; i++)
				{
					Console.WriteLine((i + 1) + ") " + airports[i].ToString());
				}

				Console.WriteLine("\nPlease type the number of the Airport that you would like to check");
				var chosenNumber = Console.ReadLine();
				var airport = airports[Int32.Parse(chosenNumber) - 1];
				Console.WriteLine("\nPlease see the information for " + airport);

				/* Print Terminals */
				for (int i = 0; i < airport.terminals.Length; i++)
				{
					Console.WriteLine((i + 1) + ") " + airport.terminals[i].ToString());
				}

				Console.WriteLine("\nPlease choose which number terminal you would like to view info for");
				chosenNumber = Console.ReadLine();
				var terminal = airport.terminals[Int32.Parse(chosenNumber) - 1];
				Console.WriteLine("\nPlease see the options for " + terminal);


				bool flightFinished = false;
				while (!flightFinished)
				{
					Console.WriteLine("\nPlease choose which number flight you would like to view info for");
					Console.WriteLine("0) Create a new flight");

					for (int i = 0; i < terminal.flights.Count; i++)
					{
						Console.WriteLine((i + 1) + ") " + terminal.flights[i].ToString());
					}

					chosenNumber = Console.ReadLine();

					/* Create an new flight */
					if (Int32.Parse(chosenNumber) == 0)
					{
						Console.WriteLine("Please Create a Flight");
						Console.WriteLine("Destination?");
						var destination = Console.ReadLine();
						Console.WriteLine("Airline");
						var airline = Console.ReadLine();
						Flight newFlight = new Flight(airport.airportName, destination, airline);
						terminal.AddFlight(newFlight);
						Console.WriteLine("New flight created: " + newFlight.ToString());
					}
					/* Print Passengers */
					else
					{
						var flight = terminal.flights[Int32.Parse(chosenNumber) - 1];
						Console.WriteLine("\nPlease see the passengers on " + flight);

						Console.WriteLine("0) Create a new passenger");
						Console.WriteLine("1) Remove a passenger");

						for (int i = 0; i < flight.passengers.Count; i++)
						{
							Console.WriteLine((i + 2) + ") " + flight.passengers[i].ToString());
						}

						chosenNumber = Console.ReadLine();

						if (Int32.Parse(chosenNumber) == 0)
						{
							Console.WriteLine("Please Create a Passenger");
							Console.WriteLine("First Name?");
							var firstName = Console.ReadLine();
							Console.WriteLine("Last Name?");
							var lastName = Console.ReadLine();
							Console.WriteLine("Date Of Birth?");
							var dob = Console.ReadLine();
							Passenger newPassenger = new Passenger(firstName, lastName, dob);
							flight.AddPassenger(newPassenger);
							Console.WriteLine("New passenger created: " + newPassenger.ToString());
						}
						else if (Int32.Parse(chosenNumber) == 1)
						{
							Console.WriteLine("Who would you like to remove?");
							for (int i = 0; i < flight.passengers.Count; i++)
							{
								Console.WriteLine((i + 1) + ") " + flight.passengers[i].ToString());
							}
							chosenNumber = Console.ReadLine();
							flight.RemovePassenger(flight.passengers[Int32.Parse(chosenNumber) - 1]);
						}
						else
						{
							flightFinished = true;
						}
					}
				}
			}
		}
	}
}
