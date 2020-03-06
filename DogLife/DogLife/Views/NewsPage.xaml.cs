using DogLife.Interfaces;
using DogLife.Models;
using DogLife.ViewModels;
using DogLife.Views.TitleViews;
using System.Linq;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class NewsPage : ContentPage, ITabPageIcons, IDynamicTitle
    {
        private View _view;
        private NewsPageViewModel ViewModel => BindingContext as NewsPageViewModel;
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
