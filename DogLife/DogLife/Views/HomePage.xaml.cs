using DogLife.Interfaces;
using DogLife.Views.TitleViews;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class HomePage : ContentPage, ITabPageIcons, IDynamicTitle
    {
        private View _view;

        public HomePage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_home";

        public string GetSelectedIcon() => "tab_home_selected";

        public View GetTitle()
        {
            if (_view == null)
                _view = new HomeTitleView();

            return _view;
        }
    }
}
