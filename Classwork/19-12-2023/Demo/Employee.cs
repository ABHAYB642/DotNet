namespace hr
{

public abstract class Employee{
    private int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public Employee():this(12,"Ravi", "Tambade"){
        
    }
    public Employee(int id,string fname,string lname)
    {
        this.Id=id;
        this.FirstName=fname;
        this.LastName=lname;
    }
    // public abstract double CalSal();
    public virtual double CalSal(){
        return 10000;
    }
    public override String ToString(){
        return Id+" "+LastName;
    }
    
    
}
}   