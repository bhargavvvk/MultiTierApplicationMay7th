using System;

using NotificationBLLibrary.Interfaces;
using NotificationModelLibrary.Models;

namespace NotificationBLLibrary.NotificationSenders
{
    public class EmailNotificationSender : INotificationSender
    {
        public void Send(User user, Notification notification)
        {
            Console.WriteLine("\nSending Email Notification...");
            Console.WriteLine($"To : {user.Email}");
            Console.WriteLine($"Message : {notification.Message}");
            Console.WriteLine($"Sent Date : {notification.SentDate}");
        }
    }
}