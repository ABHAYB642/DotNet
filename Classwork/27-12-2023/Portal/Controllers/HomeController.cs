using System.Diagnostics;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BOL;
using System.Text.Json;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login(){
        return View();
    }

    [HttpPost]
    public IActionResult Login(String username,String password){
        
        User u1 = Service.ValidateUser(username,password);
        if(u1!=null){
            TempData["ValidUser"]=u1.ToString();
            return RedirectToAction("welcome");
        }else{
        return View();
        }
    }

     public IActionResult welcome(){
        this.ViewData["validuser"]=TempData["ValidUser"];
        // ViewData["validuser"]=u1;
        return View();
    }


}
