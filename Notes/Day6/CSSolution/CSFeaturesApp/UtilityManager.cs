using System.Diagnostics;
using Mathematics;

namespace Utility;
public  static class UtilityManager{

    public static void  Calculate(int radius, out float area, out float circumference){
        area= (3.14f)* radius*radius;
        circumference= 2 *(3.14f)* radius;
    }
    public static void Swap( ref int num1, ref int num2){
        
        int temp=num1;
        num1=num2;
        num2=temp;

    }

    public static void  ShowNames(params object [] names){
        foreach(object name in names){
            Console.WriteLine(name);
        }
    }


    public static int Division(this MathEngine e,int op1, int op2){
        return op1/ op2;
    }

    public static int Multiplication(this MathEngine e,int op1, int op2){
        return op1* op2;
    }

}