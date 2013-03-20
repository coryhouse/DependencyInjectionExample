using System;

namespace Productify.Domain.Model
{
	public class Auditor : IAuditor
	{
		public void Record(string eventDescription)
		{
			//Write audited event to the database.
			return;
		}
	}
}
