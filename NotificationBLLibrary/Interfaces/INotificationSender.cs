
using NotificationModelLibrary.Models;


namespace NotificationBLLibrary.Interfaces
{
    public interface INotificationSender
    {
        void Send(User user, Notification notification);
    }
}