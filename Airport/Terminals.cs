using System;
using System.Collections.Generic;

namespace AirportApp
{
	public class Terminal
	{
		private string terminalName;
		private int capacity;
		public List<Flight> flights { get; set; }

		public Terminal(string inputName, int inputCapacity)
		{
			terminalName = inputName;
			capacity = inputCapacity;
			flights = new List<Flight>();
		}

		public override string ToString()
		{
			return String.Format("Terminal Name: {0}, Capacity: {1}", terminalName, capacity);
		}

		public void AddFlight(Flight flight)
		{
			flights.Add(flight);
		}
	}
}
