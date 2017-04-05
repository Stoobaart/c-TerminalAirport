using System;

namespace AirportApp
{
	public class Flight
	{
		private string location;
		private string destination;
		private string airline;

		public Flight(string inputFrom, string inputTo, string inputAirline)
		{
			location = inputFrom;
			destination = inputTo;
			airline = inputAirline;
		}

		public override string ToString()
		{
			return String.Format("From: {0}, To: {1}, Airline: {2}", location, destination, airline);
		}
	}
}
