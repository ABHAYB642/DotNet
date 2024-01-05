using Transflower.Drawing;
namespace Paint;

static class Program
{
    [STAThread]
    static void Main()
    {
        Line l=new Line();
        //l.StartPoint=new Graphics.Point(34,45);
        //l.EndPoint=new Graphics.Point(67,100);
        l.Color="Red";
        l.Width=2;
        l.Draw();
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}