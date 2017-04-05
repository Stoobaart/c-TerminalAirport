using System;

namespace AirportApp
{
	public class Terminal
	{
		private string terminalName;
		private string capacity;
		public Flight[] flights;

		public Terminal(string inputName, string inputCapacity)
		{
			terminalName = inputName;
			capacity = inputCapacity;
			flights = new Flight[0];
		}

		public override string ToString()
		{
			return String.Format("{0} {1}", terminalName, capacity);
		}
	}
}
