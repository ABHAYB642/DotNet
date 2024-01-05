using Microsoft.AspNetCore.Http.Features;
using PMP.Models;
using PMP.BLL;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => "Hello World!");
app.MapGet("/api/welcome", () => "Welcome to .net SOA!");
app.MapGet("/api/catalog", () => new {Id=12, Title="Gerbera",Description="Wedding Flower",UnitPrice=34});

app.MapGet("/api/pmp/activities",   ( ) =>{
    List<Activity> items= ProjectManager.GetAll();
    return items;
});

app.MapGet("/api/pmp/activities/complete", ( ) =>{

});

app.MapGet("/api/pmp/activities/{id}",   (int id) =>{
});

app.MapPost("/api/pmp/activities", async (Activity Activity) =>
{
    return Results.Created($"/pmp/{Activity.Id}", Activity);
});

app.MapPut("/pmp/activities/{id}",   (int id, Activity inputActivity ) =>
{
    return Results.NoContent();
});

app.MapDelete("/api/pmp/activities/{id}", (int id ) =>
{
    return Results.NotFound();
});




app.MapGet("/api/pmp/resources",   ( ) =>{
    List<Activity> items= ProjectManager.GetAll();
    return items;
});

app.MapGet("/api/pmp/resources/complete", ( ) =>{

});

app.MapGet("/api/pmp/resources/{id}",   (int id) =>{
});

app.MapPost("/api/pmp/resources", async (Activity Activity) =>
{
    return Results.Created($"/pmp/{Activity.Id}", Activity);
});

app.MapPut("/pmp/resources/{id}",   (int id, Activity inputActivity ) =>
{
    return Results.NoContent();
});

app.MapDelete("/api/pmp/resources/{id}", (int id ) =>
{
    return Results.NotFound();
});

app.Run();
