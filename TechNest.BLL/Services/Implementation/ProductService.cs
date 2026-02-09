

using AutoMapper;
using TechNest.BLL.ModelVM;
using TechNest.BLL.Services.Abstraction;
using TechNest.DAL.Entity;
using TechNest.DAL.Repository.Abstraction;

namespace TechNest.BLL.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepo productRepo,IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        

        public List<GetProductVM> GetAllProducts()
        {
            try
            {
                var result = _productRepo.GetAll();

                var resultVM = _mapper.Map<List<GetProductVM>>(result);
                return resultVM;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
