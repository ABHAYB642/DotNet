
namespace Taxation;
public  static class TaxationService{

    public static void PayIncomeTax(float amount){

        Console.WriteLine( "Income Tax : "+ amount + "is deducted from your Bank Account");
        
    }

    public static void PaysalesTax(float amount){
        Console.WriteLine( "Sales Tax : "+ amount + "is deducted from your Bank Account");
        
    }

    public static void PayServiceTax(float amount){

        Console.WriteLine( "Service Tax : "+ amount + "is deducted from your Bank Account");   
    }

    public static void PayGSTTax(float amount){
           Console.WriteLine( "GST Tax : "+ amount + "is deducted from your Bank Account");
    }

}