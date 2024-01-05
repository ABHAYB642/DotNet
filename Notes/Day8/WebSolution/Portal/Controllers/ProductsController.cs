using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Collections.Generic;
using BOL;
using BLL;
namespace Portal.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager mgr=new CatalogManager();
        List<Product> products=mgr.GetAllProducts();
        ViewData["allProducts"]=products;
        return View();
    }

     
}
