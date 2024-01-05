using Microsoft.AspNetCore.Authentication.OAuth;

namespace Catalog;
public class Product{
    public int Id{get;set;}
    public string Title{get;set;}
    public string Description{get;set;}
    public float UnitPrice{get;set;}
    public int Quantity{get;set;}
    public string Imageurl{get;set;}
}