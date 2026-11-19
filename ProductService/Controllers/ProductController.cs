using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductContext context;
        public ProductController(ProductContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Product> Get()
        {
            List<Product> s = context.Product.ToList();
            return s;
        }
    }

}
