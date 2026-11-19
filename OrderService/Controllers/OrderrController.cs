using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderrController : ControllerBase
    {
        private readonly HttpClient obj;

        public OrderrController(IHttpClientFactory factory)
        {
            obj = factory.CreateClient();
        }
        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            var products = await obj.GetFromJsonAsync<List<Product>>("http://localhost:5000/api/Product");
            return Ok(products);
        }
    }

}
