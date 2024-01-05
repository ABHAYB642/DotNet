
namespace HR;
public class  WageEmployee:Employee{

    public int WorkingHours{get;set;}

    public WageEmployee():this(99,"Raghu More",70){

    }
    public WageEmployee(int id, string fullName, int hours):base(id, fullName){
        this.WorkingHours=hours;
    }
    public override float ComputePay()
    {
        return base.ComputePay() + WorkingHours* 600;
    }
    public override string ToString()
    {
        return base.ToString()+ "working hours:" +WorkingHours;
    }
}