namespace BLL;
using BOL;

//using DAL;
using DAL.Connected;
//using DAL.DisConnected;
public class CatalogManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts=DBManager.GetAllProducts();
        return allProducts;
    }

     public Product GetProduct(int  id){
      List<Product> allProducts=GetAllProducts();
      //LINQ Query
     /* var product=from  p in allProducts
                   where p.ProductId ==id
                    select p  ;     
    */
      Product product=allProducts.Find((product)=>product.Id ==id);
      return product ;
     }
}