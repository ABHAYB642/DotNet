namespace Transflower.Drawing;

public abstract class Shape
{
    public Shape(){
        this.Color="black";
        this.Width=0;
    }
    public Shape(int w, string c){
        this.Color=c;
        this.Width=w;
    }
    public string Color{get;set;}
    public int Width{get;set;}
    public abstract void Draw();
    public override string ToString()
    {
        return "Width="+ this.Width + ",  Color="+this.Color;
        
    }
}
