namespace Productify.Domain.Model
{
    public class User : IAggregateRoot
    {
        public string UserName { get; set; }
        public string HashedPassword { get; set; }

        bool IAggregateRoot.CanBeSaved
        {
            get { return true; }
        }

        bool IAggregateRoot.CanBeDeleted
        {
            get { return true; }
        }
    }
}
