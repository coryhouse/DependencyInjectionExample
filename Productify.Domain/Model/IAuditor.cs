namespace Productify.Domain.Model
{
	public interface IAuditor
	{
		void Record(string auditedEvent);
	}
}
