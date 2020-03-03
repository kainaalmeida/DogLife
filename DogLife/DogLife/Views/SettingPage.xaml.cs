using DogLife.Interfaces;
using DogLife.Views.TitleViews;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class SettingPage : ContentPage, ITabPageIcons, IDynamicTitle
    {

        private View _view;

        public SettingPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_setting";

        public string GetSelectedIcon() => "tab_setting_selected";

        public View GetTitle()
        {
            if (_view == null)
                _view = new SettingsTitleView();

            return _view;
        }
    }
}
