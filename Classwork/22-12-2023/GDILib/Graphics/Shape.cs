
namespace Design.Drawing;


public abstract class Shape
{
    public Shape(){
        this.Color="black";
        this.Width=0;
    }
    public Shape(String color,int w){
        this.Color=color;
        this.Width=w;
    }
    public String Color{get;set;}
    public int Width{get;set;}
    public abstract void draw();
    public override String ToString(){
        return "Width = "+this.Width+"Color = "+this.Color;
    }
}