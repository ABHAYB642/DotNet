using System.Diagnostics;
using BLL;
using BOL;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    

    public IActionResult Index()
    {
        List<Product>allproduct=new List<Product>();
        allproduct=Service.GetAllProducts();
        ViewData["AllProduct"]=allproduct;
        foreach(Product p in allproduct){
            Console.WriteLine(p);
        }
        return View();
    }

 


}
