namespace HR;
public class Person{

    private int id;
    private string firstName;
    private string lastName;
    public void SetFirstName(string f){
        this.firstName=f;
    }
    public string GetFirstName(){
        return this.firstName;
    }

    //Property Syntax
    public string LastName{
        get{
            return this.lastName;
        }
        set{
            this.lastName=value;
        }
    }
    public Person(){
        this.id=99;
        this.firstName="Rajiv";
        this.lastName="Shah";
    }
    public Person(int id,string fname, string lname){
        this.id=id;
        this.firstName=fname;
        this.lastName=lname;
    }
    ~Person(){

    }
    public override string ToString()
    {
        return this.firstName +  " "+ this.lastName;
        //return base.ToString();
    }

}