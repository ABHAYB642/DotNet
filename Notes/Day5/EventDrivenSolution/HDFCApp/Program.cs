using System.Threading;
using Banking;
using Notification;
using Taxation;
Account acct=new Account();
acct.Balance=15000;
acct.Deposit(6000);
float currentBalance=acct.Balance;
Console.WriteLine( "Current Balance="+ currentBalance);

//Direct Call Synchronous Call
/*NotificationService.SendEmail("Raj","Your salary is deposited");
TaxationService.PayIncomeTax(5000);
*/

//Indirect Call (Asynchronous Call)


//TaxOperation revadi=new TaxOperation(TaxationService.PayServiceTax);
//revadi(6000);

//Attach functions to delegates
NotificationOperation proxyEmailSender=new NotificationOperation(NotificationService.SendEmail);
NotificationOperation proxySMSSender=new NotificationOperation(NotificationService.SendSMS);
NotificationOperation proxyWhatAppSender=new NotificationOperation(NotificationService.SendWhatsAppMessage);


NotificationOperation proxy=null;
//Chaining
proxy+=proxyEmailSender;
proxy+=proxySMSSender;
proxy+=proxyWhatAppSender;

//Synchronous Calling
proxy("Sameer", "Havaa ka jhoka");
//Synchronous Calling
//Blocking Call

proxy-=proxyEmailSender;
proxy-=proxySMSSender;
proxy("Rahul", " Thank you.");
//proxy.Invoke("Reeya", "Welcome");

//Asynchronous calling
//IAsyncResult iResult=proxy.BeginInvoke("sarang","Thank you",null,null);
                   
// Obtain the result of the Add() method when ready.
//proxy.EndInvoke(iResult);

Thread currentThread=Thread.CurrentThread;
int threadId=currentThread.ManagedThreadId;
Console.WriteLine( "Primary Thread Id="+ threadId);
Console.WriteLine("Primary Thread Prioity: "+ currentThread.Priority);


Console.WriteLine( "\n \n \n  Now Event Driven Application");

Account acct45=new Account();
//attach event handler with with before working with object 
//operation
acct45.overBalance+= TaxationService.PayIncomeTax;
acct45.overBalance+= TaxationService.PayGSTTax;


acct45.underBalance+=NotificationService.SendEmail;
acct45.underBalance+=NotificationService.SendSMS;
acct45.underBalance+=NotificationService.SendSMS;

acct45.Balance=167000;
acct45.Withdraw(166000);

//acct45.Deposit(486000);
float currentBalance_2=acct45.Balance;
Console.WriteLine(" Latest Balance of acct45 "+currentBalance_2);
