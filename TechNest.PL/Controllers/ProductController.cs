using Microsoft.AspNetCore.Mvc;
using TechNest.BLL.Services.Abstraction;

namespace TechNest.PL.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var reuslt = _productService.GetAllProducts();
            return View(reuslt);
        }
    }
}
