using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AllMVC.Models;
using BlL;
using BOL;
namespace AllMVC.Controllers;

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

    public IActionResult welcome()
    {
        return View();
    }

    public IActionResult getallproducts()
    {
        List<Student>list=new List<Student>();
        list=Services.getallstudents();
        ViewData["liststudent"]=list;
        return View();
    }

    public IActionResult delete(int id)
    {
        Boolean status=Services.deletebyID(id);
        return this.RedirectToAction("getallproducts");
    }

    [HttpGet]
    public IActionResult edit(int id)
    {
        List<Student>list=new List<Student>();
        list=Services.getallstudents();
        Student s=list.Find((s)=>s.Id==id);
        ViewData["Studentinfo"]=s;
        return View();
    }


[HttpPost]
    public IActionResult edit(int id,string name,string hobby)
    {
        Boolean status=Services.editbyid(id,name,hobby);
        if(status){
        return this.RedirectToAction("getallproducts");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult login(string username,string password)
    {
        bool status=Services.Validate(username,password);
        if(status){
        return this.RedirectToAction("welcome");
        }
        return View();
    }



    [HttpGet]
    public IActionResult forgetpassword()
    {
        return View();
    }

    [HttpPost]
    public IActionResult forgetpassword(string username,string password)
    {
        bool status=Services.UpdatePass(username,password);
        if(status){
        return this.RedirectToAction("login");
        }
        return View();
    }

    [HttpPost]
    public IActionResult Register(string username,string password)
    {
        bool status=Services.RegisterUser(username,password);
        if(status){
        return this.RedirectToAction("Login");
        }
        return View();
    }

[HttpGet]
     public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public IActionResult deleteaccount(string username,string password)
    {
        bool status=Services.deleteuser(username,password);
        if(status){
        return this.RedirectToAction("Register");
        }
        return View();
    }

[HttpGet]
     public IActionResult deleteaccount()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
