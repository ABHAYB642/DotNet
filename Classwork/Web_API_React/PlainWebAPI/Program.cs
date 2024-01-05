using BOL;
using DAL.Connected;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
app.MapPost("/api/pmp/activities",   ( ) =>{
    List<Product> items= DBManager.GetAllProducts();
    return items;
});

app.MapGet("/api/pmp/activities",   ( ) =>{
    List<Product> items=DBManager.GetAllProducts();
    return items;
});
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
app.Run();
