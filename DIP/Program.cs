using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification smsNotification = new Notification(new SMS());
            Notification EmailNotification = new Notification(new Email());
        }
    }
}