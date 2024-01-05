using Hardware;
namespace Design.Drawing;
public class Ellipse:Shape,Iprinter{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}
    public Ellipse():base(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }
    public Ellipse(Point p1, Point p2, int w, string c):base(c,w){
        this.StartPoint=p1;
        this.EndPoint=p2;
    }
    public override void draw()
    {
        Console.WriteLine("Drawing Ellipse");
        Console.WriteLine(this);
    }
    public override string ToString()
    {
        return base.ToString() + this.StartPoint+ ", "+ this.EndPoint;
    }
    
    void Iprinter.Print(){
            Console.WriteLine("Circle is Printing");
        }
}