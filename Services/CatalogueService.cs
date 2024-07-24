using IDC_Web.Shared.Context;
using IDC_Web.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace IDC_Web.Services
{
    public class CatalogueService
    {
        private readonly AppDbContext _Context;

        public CatalogueService(AppDbContext Context)
        {
            _Context = Context;
        }

        public async Task<List<IProduct>> ListAllAsync()
        {
            return await _Context.product.ToListAsync();
        }
    }
}
