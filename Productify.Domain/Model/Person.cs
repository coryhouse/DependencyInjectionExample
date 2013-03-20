using System;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Productify.Domain.Model
{
    /// <summary>
    /// Represents a person, which is a type of party
    /// </summary>
    public abstract class Person : Party
    {
        /// <summary>
        /// Gets or sets the surname
        /// </summary>
        [NotNullValidator()]
        public virtual string Surname { get; set; }

        /// <summary>
        /// Gets or sets the birth date
        /// </summary>
        public virtual DateTime BirthDate { get; set; }
    }
}
