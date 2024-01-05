namespace BOL;

public class Student
{
    public int Id{get;set;}
    public string Name{get;set;}

    public string Hobby{get;set;}


    public  Student(){

    }
    public  Student(int id,string name,string hobby){
        this.Id=id;
        this.Name=name;
        this.Hobby=hobby;
    }


}