using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1;


public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    //Action Methods
    public IActionResult Index()
    {
        Product p1=new Product();
        p1.Title="Jasmine";
        p1.Description="Smelling Flower";
        p1.UnitPrice=56;
        p1.Quantity=7999;
        p1.Imageurl="/images/jasmine.jpg";
  
        ViewData["flower"]=p1;
        return View();
    }
     
 
}

