using HR;
Employee e1=new Employee();
//Console.WriteLine(e1);
WageEmployee wg1=new WageEmployee();
//Console.WriteLine(wg1);
SalesEmployee salese1=new SalesEmployee();
//Console.WriteLine(salese1);
List<Employee> employees=new List<Employee>();
employees.Add(e1);
employees.Add(wg1);
employees.Add(salese1);

foreach( Employee emp in employees){
   
    Console.WriteLine(emp);
    Console.WriteLine(emp.ComputePay());
}


int amount=67;
//Implicit Typecasting
float cost=amount;

//explicit Typecasting
int latestAmount=(int) cost;

WageEmployee wg3=salese1;

//SalesEmployee latestsalesemp=(SalesEmployee)wg3;
SalesEmployee latestsalesemp=wg3 as SalesEmployee;

if(latestsalesemp is SalesEmployee){
    //
}

int instanceCount=SalesEmployee.count;
