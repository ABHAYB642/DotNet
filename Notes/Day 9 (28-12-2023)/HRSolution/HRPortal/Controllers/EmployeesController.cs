using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL;

namespace HRPortal.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){
       List<Employee> employees=HRDBManager.GetAllEmployees();
        ViewData["employees"]=employees;
       return View();

    }

    public IActionResult List(){
      
       List<Employee> employees=HRDBManager.GetAllEmployees();
       //Attach model object using View inbuilt method
       return View(employees);

    }
    public IActionResult Insert(){
    
        return View();
     }

    public IActionResult Details(int id){

         List<Employee> employees=HRDBManager.GetAllEmployees();
         var e= employees.Find((emp)=>emp.Id==id);    
        return View(e);
    }



    public IActionResult Edit(int id){
         List<Employee> employees=HRDBManager.GetAllEmployees();
         var e= employees.Find((emp)=>emp.Id==id);    
        return View(e);
     }



    [HttpPost]
    public IActionResult Edit(Employee emp){   
        Console.WriteLine(emp.Id+ " " + emp.Name);
        if (emp != null && ModelState.IsValid) { 
            return RedirectToAction("List");
        } 
        else      
        return View();
    }
//Partial View
    public IActionResult Dashboard(){
        return View();
    }
}
