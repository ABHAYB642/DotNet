using Hardware;
using Graphics;
using System.Collections.Generic;


HPPrinter printer=new HPPrinter();
printer.Print();
printer.Scan();

List<Shape> shapes=new List<Shape>();

Line l=new Line();
l.StartPoint=new Graphics.Point(34,45);
l.EndPoint=new Graphics.Point(67,100);
l.Color="Red";
l.Width=2;

Point center=new Point(45,54);
Circle c=new Circle(center, 15, 3, "blue");
c.Draw();

shapes.Add(l);
shapes.Add(c);

Console.WriteLine("All shapes showing");
foreach( Shape s in shapes)
{
    Console.WriteLine(s);
}