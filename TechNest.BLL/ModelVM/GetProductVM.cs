
using TechNest.DAL.Entity;

namespace TechNest.BLL.ModelVM
{
    public class GetProductVM
    {
        public string Name { get;  set; }
        public double Price { get;  set; }
        public int CategoryId { get;  set; }
        public Category Category { get;  set; }
         
    }
}
