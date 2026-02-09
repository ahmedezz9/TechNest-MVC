
namespace TechNest.DAL.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product? Product { get; set; }
         
    }
}
