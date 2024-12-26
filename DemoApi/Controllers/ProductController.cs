using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoApi.DBContext;
using DemoApi.Models;

namespace SalesOrderAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        this._context = context;
    }

    [HttpGet("GetProducts")]
    public async Task<List<Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpGet("GetProductById")]
    public async Task<ActionResult<Product>> GetProductById(int productId)
    {
        var product = await _context.Products.FindAsync(productId);

        if (product == null)
        {
            return NotFound();
        }

        return product;
    }
}
