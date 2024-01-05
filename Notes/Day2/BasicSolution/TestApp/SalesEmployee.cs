
namespace HR;
public sealed class  SalesEmployee:WageEmployee{

    public float Incentive{get;set;}
    public float Target{get;set;}

    public static int count;
    public SalesEmployee():this(499,"Manisha Nene",70,7000,1000000){
        count++;
    }
    public SalesEmployee(int id, string fullName, int hours, float incentive, float target):base(id, fullName,hours){
        
        this.Incentive=incentive;
        this.Target=target;
    }


    public override float ComputePay()
    {
        float totalSalary;
        if(Target >800000){
        totalSalary= base.ComputePay() + Incentive;
        }
        else
        totalSalary= base.ComputePay() ;
        return totalSalary;
    }

    public override string ToString()
    {
        return base.ToString()+ "Target: "+ this.Target + " Incentive: "+ this.Incentive;
    }

    ~ SalesEmployee(){
        count--;
  
    }
}