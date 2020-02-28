using DogLife.Interfaces;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class NewPage : ContentPage, ITabPageIcons
    {
        public NewPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_new";

        public string GetSelectedIcon() => "tab_new";
    }
}
