
using Transflower.Drawing;
using System.Drawing;

namespace Paint;


public partial class Form1 : Form
{
          Transflower.Drawing.Point startPoint;
          Transflower.Drawing.Point endPoint;
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
       
    }

    public void onMouseDown(object sender, MouseEventArgs e){
      
       startPoint=new Transflower.Drawing.Point(e.X, e.Y);


    }


     public void onMouseUp(object sender, MouseEventArgs e){
        endPoint=new Transflower.Drawing.Point(e.X, e.Y);
        Line l=new Line(startPoint, endPoint, 3, "red");
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
    }
}
