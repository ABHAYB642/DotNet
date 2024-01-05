namespace BOL{
public class Product
{

    public int id {get;set;}
    public string name{get;set;}
    public int qty{get;set;}
    public float Price{get;set;}


     public Product(){
    }

    public Product(int productId,string title, int quantity,float price){
        this.id=productId;
        this.name = title;       
        this.qty = quantity;
        this.Price=price;
        
    }

}
}