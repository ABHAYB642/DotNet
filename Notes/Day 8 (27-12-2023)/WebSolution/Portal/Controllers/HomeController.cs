using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Collections.Generic;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person prn1=new Person{Id=23, FirstName="Raj", LastName="Malhotra"};
        Person prn2=new Person{Id=45, FirstName="Simran" , LastName="Kapoor"};
        List<Person> family=new List<Person>();
        family.Add(prn1);
        family.Add(prn2);
        this.ViewData["bFamily"]=family;
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
