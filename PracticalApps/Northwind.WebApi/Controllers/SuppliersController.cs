using Microsoft.AspNetCore.Mvc;
using Northwind.DataContext.SqlServer;
using Northwind.EntityModels;

namespace Northwind.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuppliersController : ControllerBase
{
    private readonly NorthwindContext _db;

    public SuppliersController(NorthwindContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IEnumerable<Supplier> GetSuppliers()
    {
        return _db.Suppliers
                  .OrderBy(s => s.Country)
                  .ThenBy(s => s.CompanyName);
    }
}