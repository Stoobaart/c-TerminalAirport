using System;

namespace AirportApp
{
	public class Passengers
	{
		private string firstName;
		private string lastName;
		private string dateOfBirth;

		public Passengers(string inputFirstName, string inputLastName, string inputDateOfBirth)
		{
			firstName = inputFirstName;
			lastName = inputLastName;
			dateOfBirth = inputDateOfBirth;
		}

		public override string ToString()
		{
			return String.Format("{0} {1} {2}", firstName, lastName, dateOfBirth);
		}
	}
}
