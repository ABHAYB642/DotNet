using HRPortal.Models;

namespace DAL;
public static class HRDBManager{

    public static  List<Employee> GetAllEmployees(){
        List<Employee> employees=new List<Employee>();
        employees.Add(new Employee{Id=23,Name="SachinTendulkar"});
        employees.Add(new Employee{Id=24,Name="SunilGavaskar"});
        employees.Add(new Employee{Id=56, Name="SachinPatil"});
        employees.Add(new Employee{Id=33,Name="JeevanSharma"});
        employees.Add(new Employee{Id=99,Name="RajKumar"});
        return employees;
    }
}