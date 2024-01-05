using System.Collections.Generic;
using System;
using System.Linq;
using IOCWebApp.Models;
using IOCWebApp.Contexts;

namespace IOCWebApp.Repositories
{
    public class ProductManager : IProductManager
    {
        public bool Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
            return true;
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("getting all product from manager");
           List<Product> products=new List<Product>();
           try{
            using (var context = new CollectionContext())
            {
            var  allproducts = from prod in context.Products select prod;

             foreach(Product p in products){
                Console.WriteLine(p.Product_Title);
             }
             products=allproducts.ToList();
            
            }

           }
           catch(Exception e){
            Console.WriteLine("Exception e"+ e.Message);
           }

            return (List<IOCWebApp.Models.Product>)products;
            
        }

        public Product GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var product = context.Products.Find(id);
             return product;
            }
        }

        public bool Insert(Product product)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Add(product);
                context.SaveChanges(); 
            }
            return true;
        }

        public bool Update(Product product)
        {
            using(var context = new CollectionContext())
            {
                var theProduct = context.Products.Find(product.Product_Id);
                theProduct.Product_Title =product.Product_Title;
                theProduct.Stock_Available=product.Stock_Available;
                theProduct.Description=product.Description;
                theProduct.Unit_Price=product.Unit_Price;
                context.SaveChanges();
            }
            return true;
        }
    }
}