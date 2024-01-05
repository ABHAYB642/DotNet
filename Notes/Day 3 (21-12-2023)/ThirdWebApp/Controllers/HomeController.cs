using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThirdWebApp.Models;
using Catalog;
namespace ThirdWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Action Methods
    public IActionResult Index()
    {
      
        return View();
    }
    public IActionResult  Aboutus(){

        return View();
    }
    public IActionResult Contact(){
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
