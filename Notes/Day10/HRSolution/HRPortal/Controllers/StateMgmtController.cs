using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;

namespace HRPortal.Controllers;

public class StateMgmtController : Controller
{
    private readonly ILogger<StateMgmtController> _logger;

    public StateMgmtController(ILogger<StateMgmtController> logger)
    {
        _logger = logger;
    }
 
        private const string SessionName = "_Name";
        private const string SessionAge = "_Age";

        public IActionResult Index()
        {
            // Set session data
            HttpContext.Session.SetString(SessionName, "Transflower");
            HttpContext.Session.SetInt32(SessionAge, 48);

            return View();
        }

        public IActionResult About()
        {
            // Retrieve session data
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            ViewData["Message"] = "ASP.NET Core!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

}
