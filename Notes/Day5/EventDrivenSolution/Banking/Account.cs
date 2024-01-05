namespace Banking;
using Taxation;
using Notification;
public class Account
{
    public event NotificationOperation underBalance;
    public event TaxOperation overBalance;

    public float Balance{get;set;}
    public void Deposit(float amount){
        this.Balance=this.Balance+amount;
        if(this.Balance >=250000){
            //you fired event
            overBalance(5000);
        }
    }

    public void Withdraw(float amount){
        this.Balance=this.Balance-amount;
        if(this.Balance<=10000){
            //Fire event
            
            underBalance("raj", "your account is blocked....");
        }
    }

}
