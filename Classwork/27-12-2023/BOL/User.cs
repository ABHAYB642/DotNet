namespace BOL;
public class User{
    public int Id{get;set;}
    public string Name{get;set;}

    public override string ToString()
    {
        return this.Id+" "+this.Name;
    }
}