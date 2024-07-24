using IDC_Web.Services;
using IDC_Web.Shared.Context;
using IDC_Web.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDC_Web.Controllers
{
    [ApiController]
    [Route("dashboard/[controller]")]
    public class CatalogueController : Controller
    {
        private readonly AppDbContext _Context;
        private readonly CatalogueService _Service;

        public CatalogueController(AppDbContext Context, CatalogueService Service)
        {
            _Context = Context;
            _Service = Service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public async Task<ActionResult> GetProductAsync()
        {
            try
            {
                var results = await _Service.ListAllAsync();

                return Ok(results);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<ActionResult> PostProduct(IProduct Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _Context.product.Add(Product);
            await _Context.SaveChangesAsync();
            return CreatedAtAction("Get Product", new { product_id = Product.product_id }, Product);
        }
    }
}
