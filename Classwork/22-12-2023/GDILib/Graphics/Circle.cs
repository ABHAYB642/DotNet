using Hardware;
namespace Design.Drawing;

public class Circle:Shape,Iprinter{
    public Point Centre{get;set;}
    public int Radius{set;get;}
    public Circle():base(){
        this.Centre=new Point(0,0);
        this.Radius=5;
    }
    public Circle(Point Centre,int radius,int width,String Color):base(Color,width){
        this.Centre=Centre;
        this.Radius=radius;
    }
    public override void draw(){
        Console.WriteLine(this);
    }
    public override String ToString(){
        const float pi=3.14f;
        float area=pi*Radius*Radius;
        return base.ToString()+this.Centre+this.Radius+area;
    }

        void Iprinter.Print(){
            Console.WriteLine("Circle is Printing");
        }
    // public void Print()
    // {
    //    Console.WriteLine("Circle is Printing");
    // }
}