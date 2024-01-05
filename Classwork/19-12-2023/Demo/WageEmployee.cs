namespace hr;
public class WageEmployee:Employee{
    public int hrs;
    public double rate;
    public WageEmployee():base(){
        this.hrs=10;
        this.rate=500;
    }
    public WageEmployee(int id,string fname,string lname,int hrs,double rate):base(id,fname,lname){
        this.hrs=hrs;
        this.rate=rate;
    }
    public override double CalSal(){
        return 20000;
    }
    public override String ToString(){
        return base.ToString()+" "+hrs+" "+rate;
    }
    ~WageEmployee(){
        Console.WriteLine("Destructer Called");
    }
}