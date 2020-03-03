using DogLife.Models;
using Prism.AppModel;
using Prism.Navigation;

namespace DogLife.ViewModels
{
    public class NewsDetailPageViewModel : ViewModelBase, IAutoInitialize
    {

        private News _selectedNews;
        public News SelectedNews
        {
            get { return _selectedNews; }
            set { SetProperty(ref _selectedNews, value); }
        }

        public NewsDetailPageViewModel()
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            //News = parameters.GetValue<News>("News");
        }
    }
}
