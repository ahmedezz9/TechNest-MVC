
namespace TechNest.DAL.Entity
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get;private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; } 
        public string? UpdatedBy { get; private set; } 
        public bool IsDeleted { get; private set; }
        public string? DeletedBy { get; private set; }
        public DateTime DeletedAt { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public Product(string name,double price,int catid,string createdby)
        {
            Name = name;
            Price = price;
            CreatedBy = createdby;
            CategoryId= catid;
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }
        protected Product()
        {
        }
        public bool Update(string name,double price,string updatedby)
        {
            if(updatedby != null)
            {
                Name = name;
                Price = price;
                UpdatedBy = updatedby;
                return true;
            }
            return false;
        }
        public bool ToggleStatus(string deletedby)
        {
            if(deletedby != null)
            {
                IsDeleted = !IsDeleted;
                DeletedBy =  deletedby;
                DeletedAt = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}
