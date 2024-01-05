using PMP.Models;
namespace PMP.DAL;
public class ProjectDbManager{
public static List<Activity> GetAll(){
    List<Activity> items=new List<Activity>();
    //Connected Data Access using ADO.NET
    //OR 
    //Disconnected Data Accessing ADO.NET 
    //OR
    //Data Access using Entity Framework
    return items;
}
}