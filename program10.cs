using System;

abstract class Notification
{
    public abstract void SendNotification();
}

class EmailNotification : Notification
{
    public override void SendNotification()
    {
        Console.WriteLine("Email notification sent.");
    }
}

sealed class PriorityNotification : EmailNotification
{
    public override void SendNotification()
    {
        Console.WriteLine("Priority email notification sent.");
    }
}

class Program
{
    static void Main()
    {
        Notification notification = new EmailNotification();
        notification.SendNotification();

        PriorityNotification priority =
            new PriorityNotification();

        priority.SendNotification();
    }
}
