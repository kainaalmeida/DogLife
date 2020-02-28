using DogLife.Interfaces;
using DogLife.Views.TitleViews;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class NewsPage : ContentPage, ITabPageIcons, IDynamicTitle
    {
        private View _view;

        public NewsPage()
        {
            InitializeComponent();
        }

        public string GetIcon() => "tab_news";

        public string GetSelectedIcon() => "tab_news_selected";

        public View GetTitle()
        {
            if (_view == null)
                _view = new NewsTitleView();

            return _view;
        }
    }
}
