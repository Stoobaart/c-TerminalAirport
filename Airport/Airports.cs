using System;

namespace AirportApp
{
	public class Airport
	{
		private string airportName;
		private string country;

		public Airport(string inputName, string inputCountry)
		{
			airportName = inputName;
			country = inputCountry;
		}

		public override string ToString()
		{
			return String.Format("{0} {1}", airportName, country);
		}
	}
}
