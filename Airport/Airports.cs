using System;

namespace AirportApp
{
	public class Airport
	{
		public string airportName { get; }
		private string country;
		public Terminal[] terminals { get; set; }

		public Airport(string inputName, string inputCountry)
		{
			airportName = inputName;
			country = inputCountry;
			terminals = new Terminal[2];
		}

		public override string ToString()
		{
			return String.Format("Name: {0},  Country: {1}", airportName, country);
		}
	}
}
