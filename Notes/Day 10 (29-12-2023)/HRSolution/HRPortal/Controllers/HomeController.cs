using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;

namespace HRPortal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public IActionResult Register(string companyName, string contactName){
        Console.WriteLine(companyName + " "+ contactName);
        return View();
    }


    [HttpGet]
    public IActionResult Login(){
        return View();
    }

    [HttpPost]
    public IActionResult Login(string userName, string password){
        Console.WriteLine(userName + " "+ password);
        if(userName =="ravit" && password=="seed"){
            return this.RedirectToAction("Welcome");
        }
    
        return View();
    }

    public IActionResult Welcome(){

      List<string> Student = new List<string>();
      Student.Add("Jignesh");
      Student.Add("Tejas");
      Student.Add("Rakesh");
      ViewData["Student"] = Student;
        return View();
    }


    public IActionResult Index()
    {
        List<string> Student = new List<string>();
        Student.Add("Jignesh");
        Student.Add("Tejas");
        Student.Add("Rakesh");
       ViewBag.Student = Student;

        return View();
    }



    //HTTP Web requests
    //action methods are stateless method
    //across stateless web requests if there is a need 
    //to preserve data we do use state management techinque
    //State management in two ways
    //Client Side State management
        //querystring, cookies, Hidden fields, form data
        //Browser objects such localstorage, sessionStorage
    //Server Side State management
        //Session
        //Caching
        //TempData ( allowing data to be shared in between consecutive
        //web requests)
    //get request
    public IActionResult Aboutus()
    {
        List<string> Student = new List<string>();
        Student.Add("Jignesh");
        Student.Add("Tejas");
        Student.Add("Rakesh");
        TempData["Student"] = Student;
        return View();
    }

    //get request
     public IActionResult Contact()
    {
       
        List<string> students=TempData["Student"]as List<string>;
        ViewBag.Students = students;
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
