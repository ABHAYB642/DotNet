using Banking;


Account a1=new Account(5000);
a1.overbalance+=TaxService.PayTax;
a1.underbalance+=NotificationService.Email;
a1.deposit(260000);
a1.withdraw(2000);
// Console.WriteLine(a1);  


// NotificationDelegate proxyEmailSender=new NotificationDelegate(NotificationService.Email);
// // proxyEmailSender();
// NotificationDelegate proxy=null;
// proxy+=new NotificationDelegate(NotificationService.Email);
// proxy+=new NotificationDelegate(NotificationService.SMS);
// proxy+=new NotificationDelegate(NotificationService.WhatsApp);
// proxy();

Account a2=new Account(25000);
a2.overbalance+=TaxService.PayTax;
a2.overbalance+=TaxService.PayGST;
a2.underbalance+=NotificationService.Email;
a2.underbalance+=NotificationService.SMS;
a2.withdraw(20000);
a2.deposit(500000);

