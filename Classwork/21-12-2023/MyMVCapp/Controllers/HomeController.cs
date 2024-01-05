using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1;


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
}

