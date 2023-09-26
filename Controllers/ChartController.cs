using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLabaC1.Models;

namespace WebLabaC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly ShopWebLabaContext _context;

        public ChartController(ShopWebLabaContext context)
        {
            _context = context;
        }

        [HttpGet("JsonDataShop")]
        public JsonResult JsonDataShop()
        {
            var shops = _context.Shops.Include(s => s.Products).ToList();
            List<object> productShop = new List<object>();
            productShop.Add(new[] { "Магазин", "Кількість товарів" });
            foreach (var shop in shops)
            {
                productShop.Add(new object[] { shop.Name, shop.Products.Count() });
            }

            return new JsonResult(productShop);
        }
    }
}
