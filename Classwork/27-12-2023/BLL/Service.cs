namespace BLL;

using System;
using BOL;
using Connected;

public static class Service
{

        public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts=DBManager.Getallproducts();
        return allProducts;
    }

    public static User ValidateUser(string username, string password)
    {
        return DBManager.ValidateUser(username,password);
        
    }
}
