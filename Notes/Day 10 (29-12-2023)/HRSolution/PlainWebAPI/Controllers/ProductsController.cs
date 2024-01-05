using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
namespace ReactWithWebAPIApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{ 
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        CatalogManager mgr=new CatalogManager();
        List<Product> products=mgr.GetAllProducts();
        return  products.ToArray();
    }

    [HttpGet("{id}")]        
    public Product GetById(int id)
    {
      
      
    }
}
