using DogLife.Interfaces;
using DogLife.Views.TitleViews;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class NotificationPage : ContentPage, ITabPageIcons, IDynamicTitle
    {
        private View _view;

        public NotificationPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_notification";

        public string GetSelectedIcon() => "tab_notification_selected";

        public View GetTitle()
        {
            if (_view == null)
                _view = new NotificationTitleView();

            return _view;
        }
    }
}
