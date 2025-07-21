using Microsoft.AspNetCore.Mvc.RazorPages;
using Northwind.EntityModels; // assuming your Product class is here
using Northwind.DataContext.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Razor.Pages.Pages;

public class ProductsModel : PageModel
{
    private readonly NorthwindContext _db;

    public ProductsModel(NorthwindContext db) => _db = db;

    public IList<Product> Products { get; set; }

    public async Task OnGetAsync()
    {
        Products = await _db.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .ToListAsync();
    }
}
