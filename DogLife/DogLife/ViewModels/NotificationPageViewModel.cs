using DogLife.Models;
using Prism.Mvvm;
using System.Collections.Generic;

namespace DogLife.ViewModels
{
    public class NotificationPageViewModel : BindableBase
    {

        public List<Notification> Notifications { get; set; } = new List<Notification>();

        public NotificationPageViewModel()
        {
            Notifications.Add(CreateNotification("Apollo Phelps", "Snapped on your post.", "dog_notify_1", "5:30 PM"));
            Notifications.Add(CreateNotification("Bailey Stein", "Give bone on your post.", "dog_notify_2", "4:42 PM"));
            Notifications.Add(CreateNotification("Leo Reilly", "Snapped on your post.", "dog_notify_3", "Yesterday"));
            Notifications.Add(CreateNotification("Coco Gordon", "Give bone on your post.", "dog_notify_4", "Yesterday"));
            Notifications.Add(CreateNotification("Hank Lozano", "Snapped on your post.", "dog_notify_5", "14/12/18"));
            Notifications.Add(CreateNotification("Rocky Ellison", "Give bone on your post.", "dog_notify_6", "13/12/18"));
            Notifications.Add(CreateNotification("Dexter Byrd", "Snapped on your post.", "dog_notify_7", "12/12/18"));
            Notifications.Add(CreateNotification("Billy Coco", "Give bone on your post.", "dog_notify_8", "09/12/18"));
        }

        private Notification CreateNotification(string name, string description, string urlImage, string hourAdd)
        {
            return new Notification
            {
                Name = name,
                Description = description,
                UrlImage = urlImage,
                HourAdd = hourAdd
            };
        }
    }
}
