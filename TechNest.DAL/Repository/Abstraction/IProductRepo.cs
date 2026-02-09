
using System.Linq.Expressions;

namespace TechNest.DAL.Repository.Abstraction
{
    public interface IProductRepo
    {
        List<Product> GetAll(Expression<Func<Product, bool>>? filter = null);
        Product? GetById(int id);
        bool Add(Product product);
        bool Update(Product product);
         bool ToggleStatus(int id);
    }
}
