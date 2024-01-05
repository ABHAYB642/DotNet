namespace Notification;
using System.Threading;
public  static class PostNotificationService{


    //Post Action
   public  static void NotificationComplete(IAsyncResult itfAR)
    {
        Console.WriteLine("NotificationComplete() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("Your Notification is complete");      
    }

}