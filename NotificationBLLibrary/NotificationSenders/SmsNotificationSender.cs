using System;
using NotificationBLLibrary.Interfaces;
using NotificationModelLibrary.Models;

namespace NotificationBLLibrary.NotificationSenders
{
    public class SmsNotificationSender: INotificationSender
    {
        public void Send(User user, Notification notification)
        {
            Console.WriteLine("\nSending SMS Notification...");
            Console.WriteLine($"To : {user.PhoneNumber}");
            Console.WriteLine($"Message : {notification.Message}");
            Console.WriteLine($"Sent Date : {notification.SentDate}");
        }
    }
}
