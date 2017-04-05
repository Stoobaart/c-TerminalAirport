using System;
using System.Collections.Generic;

namespace AirportApp
{
	public class Flight
	{
		private string location;
		private string destination;
		private string airline;
		public List<Passenger> passengers { get; set; }

		public Flight(string inputFrom, string inputTo, string inputAirline)
		{
			location = inputFrom;
			destination = inputTo;
			airline = inputAirline;
			passengers = new List<Passenger>();
		}

		public override string ToString()
		{
			return String.Format("From: {0}, To: {1}, Airline: {2}", location, destination, airline);
		}

		public void AddPassenger(Passenger passenger)
		{
			passengers.Add(passenger);
		}

		public void RemovePassenger(Passenger passenger)
		{
			passengers.Remove(passenger);
		}
	}
}
