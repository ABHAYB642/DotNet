namespace Hardware;
//Multiple interface inheritance
public class HPPrinter:IPrinter, IScanner{
    public void Print(){
        Console.WriteLine("Printer is started.....");
    }
    public void Scan(){
    Console.WriteLine("Scanning  is started.....");
    }

}