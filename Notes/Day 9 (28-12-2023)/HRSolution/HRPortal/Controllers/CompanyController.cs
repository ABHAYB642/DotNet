using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL;

namespace HRPortal.Controllers;

public class CompanyController : Controller
{
    private readonly ILogger<CompanyController> _logger;

    public CompanyController(ILogger<CompanyController> logger)
    {
        _logger = logger;
    }

    public IActionResult BasicForm(){
      
       return View();

    }

    [HttpPost]
    public IActionResult BasicForm(string companyName, string contactName, int employeeCount){
      Console.WriteLine( "company name ="+ companyName);
      Console.WriteLine( "contact name ="+ contactName);
      Console.WriteLine( "Employee count ="+ employeeCount);
       return View();
    }

    [HttpPost]
    public IActionResult ReadForm(){
        string? companyName = Request.Form["companyname"];
        string? contactName = Request.Form["contactname"];
        int? employeeCount = int.Parse(Request.Form["employees"].ToString());
        Console.WriteLine( "company name ="+ companyName);
        Console.WriteLine( "contact name ="+ contactName);
        Console.WriteLine( "Employee count ="+ employeeCount);
       return View();
    }
}
