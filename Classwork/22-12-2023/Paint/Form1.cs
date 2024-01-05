
using Design.Drawing;
using System.Drawing;

namespace Paint;


public partial class Form1 : Form
{
    private Font fnt = new Font("Arial",10);
          Design.Drawing.Point startPoint;
          Design.Drawing.Point endPoint;
    public Form1()
    {
        InitializeComponent();
           // Connect the Paint event of the PictureBox to the event handler method.
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);   
        MouseDown+=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+=new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

    //Event handlers
    public void OnPaint(object sender, PaintEventArgs e){
       Graphics g=this.CreateGraphics();
       g.DrawString("This is a diagonal line drawn on the control",
        fnt, System.Drawing.Brushes.Blue, new System.Drawing.Point(500,500));
    }

    public void onMouseDown(object sender, MouseEventArgs e){
      
       startPoint=new Design.Drawing.Point(e.X,e.Y);


    }


     public void onMouseUp(object sender, MouseEventArgs e){
        endPoint=new Design.Drawing.Point(e.X,e.Y);
        Line l=new Line(startPoint, endPoint, 3, "red");
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.Startpoint.X, l.Startpoint.Y, l.Endpoint.X, l.Endpoint.Y);
    // g.DrawLine(pen,50, 50,100,100);
    }
}

