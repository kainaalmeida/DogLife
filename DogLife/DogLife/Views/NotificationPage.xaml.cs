using DogLife.Interfaces;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class NotificationPage : ContentPage, ITabPageIcons
    {
        public NotificationPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_notification";

        public string GetSelectedIcon() => "tab_notification_selected";
    }
}
