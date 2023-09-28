using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLabaC1.Models;

namespace WebLabaC1.Controllers
{
    [Route("api/[controller]")]
    public class getShopsController : Controller
    {
        private readonly ShopWebLabaContext _context;

        public getShopsController(ShopWebLabaContext context)
        {
            _context = context;
        }

        [HttpGet("getShops")]
        public async Task<IActionResult> GetShops()
        {
            try
            {
                var objects = await _context.Shops.ToListAsync(); // Замініть Objects на вашу модель об'єктів
                return Ok(objects);
            }
            catch (Exception ex)
            {
                return BadRequest($"Помилка: {ex.Message}");
            }
        }
    }
}
