using System.Collections.Generic;

namespace Productify.Domain.Model
{
    public class Category : IAggregateRoot
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual ICollection<Product> Products {get; set;}

        /// <summary>
        /// Gets wether the current aggregate can be saved
        /// </summary>
        bool IAggregateRoot.CanBeSaved
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets wether the current aggregate can be deleted
        /// </summary>
        bool IAggregateRoot.CanBeDeleted
        {
            get
            {
                return true;
            }
        }
    }
}
