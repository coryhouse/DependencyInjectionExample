using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Productify.Domain.Model
{
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the Order Id
        /// </summary>
        private int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the Product Id
        /// </summary>
        private int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the unit price
        /// </summary>
        public virtual decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        [RangeValidator(0, RangeBoundaryType.Inclusive, 32767, RangeBoundaryType.Inclusive)]
        public virtual short Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Discount
        /// </summary>
        [RangeValidator(0f, RangeBoundaryType.Inclusive, 1f, RangeBoundaryType.Inclusive)]
        public virtual float Discount { get; set; }

        [NotNullValidator()]
        public virtual Product Product { get; set; }

        [NotNullValidator()]
        public virtual Order Order { get; set; }

        #region Equality

        public override bool Equals(object other)
        {
            if (this == other)
            {
                return true;
            }
            OrderItem obj = other as OrderItem;
            if (obj == null)
            {
                return false;
            }
            if (this.Order.Id != obj.Order.Id || this.Product.Id != obj.Product.Id)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result;
                result = this.Order.Id.GetHashCode();
                result = 29 * result + this.Product.Id.GetHashCode();
                return result;
            }
        }
        #endregion

        /// <summary>
        /// Gets the base price
        /// </summary>
        /// <returns>The base price</returns>
        public virtual decimal GetBasePrice()
        {
            return this.UnitPrice * this.Quantity;
        }

        /// <summary>
        /// Gets the base price
        /// </summary>
        /// <returns>The base price</returns>
        public virtual decimal GetPrice()
        {
            decimal basePrice = this.GetBasePrice();
            return basePrice * (decimal)(1 - this.Discount);
        }
    }
}
