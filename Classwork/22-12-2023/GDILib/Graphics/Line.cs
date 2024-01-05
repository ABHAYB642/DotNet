using Hardware;
namespace Design.Drawing;
public class Line:Shape,Iprinter{
    public Point Startpoint{set;get;}
    public Point Endpoint{set;get;}

    public Line():base(){
        Startpoint=new Point(0,0);
        Endpoint=new Point(0,0);
    }
    public Line(Point Startpoint,Point Endpoint,int w,String c):base(c,w){
        this.Startpoint= Startpoint;
          this.Endpoint=Endpoint;     
    }
    public override void draw(){
        Console.WriteLine("Drawing Line");
        Console.WriteLine(this);
    }
    void Iprinter.Print(){
         Console.WriteLine("Printing Line");
    }
    public override String ToString(){
        return base.ToString()+this.Startpoint +" " +this.Endpoint;
    } 
}