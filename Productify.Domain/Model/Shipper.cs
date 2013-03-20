using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Productify.Domain.Model
{
    /// <summary>
    /// Represents a shipper
    /// </summary>
    public class Shipper
    {
        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        [StringLengthValidator(40)] 
        [NotNullValidator()]
        public virtual string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [StringLengthValidator(24)]
        public virtual string Phone { get; set; }

        /// <summary>
        /// Gets the orders managed by the shipper
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}
