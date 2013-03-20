using System.Drawing;
using Productify.Domain.Model;

namespace Productify.Domain.Repositories
{
    /// <summary>
    /// Represents the repository of objects of type Category
    /// </summary>
    public interface ICategoryRepository : IRepository<Category>
    {
        Image GetThumbnailByCategory(int categoryId);
    }
}
