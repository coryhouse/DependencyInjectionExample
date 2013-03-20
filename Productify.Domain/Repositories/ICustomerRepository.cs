using Productify.Domain.Model;

namespace Productify.Domain.Repositories
{
    /// <summary>
    /// Represents the repository of objects of type Customer
    /// </summary>
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer FindById(string id);
    }
}