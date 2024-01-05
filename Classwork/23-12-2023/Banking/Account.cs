namespace Banking;

public class Account
{

    public event NotificationDelegate underbalance;
    public event TaxServicedelegate overbalance;
    public double Balance{get;set;}
    public Account(){
        this.Balance=0;
    }
    public Account(double Balance){
        this.Balance=Balance;
    }
    public void withdraw(double amount){
        this.Balance-=amount;
        if(this.Balance<10000){
            underbalance();
        }
    }
    public void deposit(double amount){
        this.Balance+=amount;
        if(this.Balance>250000){
            overbalance();
        }
    }
    public override string ToString()
    {
        return "Balance is " + this.Balance;
    }
}
