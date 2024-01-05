using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Catalog;
namespace SecondWebApp.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class CatalogModel : PageModel
{
     Product p1=new Product();
    private readonly ILogger<CatalogModel> _logger;

    public CatalogModel(ILogger<CatalogModel> logger)
    {
        /*p1.Title="Jasmine";
        p1.Description="Smelling Flower";
        p1.UnitPrice=56;
        p1.Quantity=7999;
        p1.Imageurl="/images/jasmine.jpg";
  
        ViewData["flower"]=p1;*/
        
        _logger = logger;
    }

    public void OnGet()
    {
        
      

    }
} 
 