



using TechNest.DAL.DataBase;

namespace TechNest.DAL.Repository.Implementation
{
    public class ProductRepo : IProductRepo
    {
        private readonly TechNestDbContext _context;
        public ProductRepo(TechNestDbContext context)
        {
            _context = context;
        }
        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            if(filter == null)
            {
               return _context.Products.ToList();
            }
            else
            {
               return _context.Products.Where(filter).ToList();
            }
        }

        public Product? GetById(int id)
        {
            var result = _context.Products.FirstOrDefault(p => p.Id == id);
            if(result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public bool Add(Product product)
        {
             
            var pro = new Product(product.Name, product.Price, "Ahmed Ezz");
            _context.Products.Add(pro);
            int count = _context.SaveChanges();
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Product product)
        {
            var result = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            result.Update(product.Name, product.Price, "Ahmed Ezz");
             _context.Products.Update(result);
            int count = _context.SaveChanges();
            
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ToggleStatus(int id)
        {
           var result = _context.Products.FirstOrDefault(p => p.Id == id);
            result.ToggleStatus("Ahmed Ezz");
            int count = _context.SaveChanges();
            
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
