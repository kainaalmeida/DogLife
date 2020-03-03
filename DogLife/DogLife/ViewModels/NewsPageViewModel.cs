using DogLife.Models;
using DogLife.Views;
using Plugin.SharedTransitions;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogLife.ViewModels
{
    public class NewsPageViewModel : ViewModelBase
    {
        public List<News> NewsList { get; set; } = new List<News>();

        private News _selectedNews;
        public News SelectedNews
        {
            get { return _selectedNews; }
            set { SetProperty(ref _selectedNews, value); }
        }

        private int _selectedNewsId;
        public int SelectedNewsId
        {
            get { return _selectedNewsId; }
            set { SetProperty(ref _selectedNewsId, value); }
        }

        public DelegateCommand<News> SelectedItemCommand { get; set; }

        public NewsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

            //SelectedItemCommand = new DelegateCommand<News>(async (news) => await SelectedItemCommandExecute(news));

            SelectedItemCommand = new DelegateCommand<News>(async (selectedNews) =>
            {
                SelectedNewsId = selectedNews.Id;

                var navParam = new NavigationParameters { { nameof(SelectedNews), selectedNews } };
                await navigationService.NavigateAsync($"{nameof(NewsDetailPage)}", navParam);
            });


            NewsList.Add(new News { Id = 1, Title = "Dogs Are Even More Like Us...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news01" });
            NewsList.Add(new News { Id = 2, Title = "Is Your Dog Super Smart", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news02" });
            NewsList.Add(new News { Id = 3, Title = "Do you think dog's are super...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news03" });
            NewsList.Add(new News { Id = 4, Title = "Your Dog Knows When You're...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news04" });
            NewsList.Add(new News { Id = 5, Title = "Dogs Might Be More Rational...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news05" });
            NewsList.Add(new News { Id = 6, Title = "Are Dogs More Likely To Bite...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news06" });
        }

        //private async Task SelectedItemCommandExecute(News news)
        //{
        //    SelectedNewsId = news.Id;

        //    var navParam = new NavigationParameters { { nameof(SelectedNews), SelectedNews } };
        //    await NavigationService.NavigateAsync($"{nameof(NewsDetailPage)}", navParam);
        //}
    }
}
