namespace HR;
  public  class Employee
  {
    private int id;
   //Normal Property Syntax
    public int Id{
        get{ return this.id;}
        set{ this.id=value;}
    }
    
   //Auto Property
    public string FullName{
        get;set;
    }

    public Employee():this(56,"Jeevan Sharma"){
        /*this.id=56;
        this.FullName="Jeevan Sharma";*/
    }
    public Employee(int id, string fullName){
        this.id=id;
        this.FullName=fullName;
    }

    public virtual float ComputePay(){
        return 56000;
    }
    public override string ToString()
    {
        return id+ " "+ FullName;
       // return base.ToString();
    }
}
