using HR;
using Graphics;


//C# (C Sharp)
/*(C# )===Simplicity of Java + (Power of C++)
          Elegance of VB
*/
Boolean status=false;

char ch='u';
int count=56;
count ++;
int [] arr={34,76,67,45};

string fullName="Ravi Tambade";

Console.WriteLine(fullName);
Console.WriteLine("Hello, World!");

//Value type and Refernce type

if(count >=100){
    Console.WriteLine("Your are extraordinary");
}
else{
    Console.WriteLine("Your are  ordinary");
}
for(int i=0;i<arr.Length;i++){
      Console.WriteLine(arr[i]);
}

//Person is a class
//value Types: primtive types
//              int, float, double, boolean, char, btye
//              struct
//Rerfernce Type: class, interface, delegate, event

Person prn=new Person(45, "Chetan", "Natu");
string objFirstName=prn.GetFirstName();
prn.LastName="Naik";
string antotherLastName=prn.LastName;
string strPerson=prn.ToString();
Console.WriteLine(strPerson);

Color myColor=new Color(255,0,0);

