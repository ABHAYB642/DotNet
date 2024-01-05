namespace Design.Drawing;
public class Point{
    public float X{get;set;}
    public float Y{get;set;}
    public Point(double v)
    {
        this.X=this.Y=0;
    }
    public Point(float x, float y){
        this.X=x;
        this.Y=y;
    }
    public override string ToString()
    {
        string str=string.Format(" X={0},Y={1}", this.X,this.Y);
        return str ;
    }
}