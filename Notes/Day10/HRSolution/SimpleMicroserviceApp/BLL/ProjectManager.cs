using PMP.Models;
namespace PMP.BLL;
public class ProjectManager{
public static List<Activity> GetAll(){
    List<Activity> items=new List<Activity>();
    items.Add(new Activity{ Id=1, Name="Print", IsComplete=false});
    items.Add(new Activity{ Id=2, Name="Code", IsComplete=false});
    items.Add(new Activity{ Id=3, Name="Test", IsComplete=false});
    items.Add(new Activity{ Id=4, Name="Deploy", IsComplete=false});
    items.Add(new Activity{ Id=5, Name="Support", IsComplete=false});
    //Access list from DAL 
    return items;
}
}