using Design.Drawing;
namespace Paint;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
    //     Line l=new Line();
    //     //l.StartPoint=new Graphics.Point(34,45);
    //     //l.EndPoint=new Graphics.Point(67,100);
    //     l.Color="Red";
    //     l.Width=2;
    //     l.draw();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}