using DogLife.Interfaces;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class SettingPage : ContentPage, ITabPageIcons
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_setting";

        public string GetSelectedIcon() => "tab_setting_selected";
    }
}
