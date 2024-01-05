using Utility;
using Mathematics;
using Library;

Books shelf=new Books();

//Console.WriteLine(shelf.titles[3]);

 //Console.WriteLine(shelf.GetTitle(3));
 shelf[3]= "Sepian";
 string bookTitle=shelf[3];
 Console.WriteLine(bookTitle);

int marks=0;

 int? count=null;           //Nullable type
 Nullable<int> amount=null;


//string myname=null;

  //Console.WriteLine(count);

UtilityManager.ShowNames("Ravi");
UtilityManager.ShowNames("Seeta", "Geeta", "Meena", "Reena");
UtilityManager.ShowNames(34, true, 56.5f, "Reena");

 
 int radius=6;
 float area,circum;
 UtilityManager.Calculate(radius,out area, out circum);
Console.WriteLine("Area of Circle="+ area + "  circumference= "+ circum);



MathEngine engine=new MathEngine();
int result1=engine.Addition(56,56);
int result2=engine.Subtraction(56,56);
int result3=engine.Multiplication(56,56);
int result4=engine.Division(56,56);


