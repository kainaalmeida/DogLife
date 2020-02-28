using DogLife.Models;
using Prism.Mvvm;
using System.Collections.Generic;

namespace DogLife.ViewModels
{
    public class NewsPageViewModel : BindableBase
    {
        public List<News> NewsList { get; set; } = new List<News>();
        public NewsPageViewModel()
        {
            NewsList.Add(new News { Title = "Dogs Are Even More Like Us...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news01" });
            NewsList.Add(new News { Title = "Is Your Dog Super Smart", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news02" });
            NewsList.Add(new News { Title = "Do you think dog's are super...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news03" });
            NewsList.Add(new News { Title = "Your Dog Knows When You're...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news04" });
            NewsList.Add(new News { Title = "Dogs Might Be More Rational...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news05" });
            NewsList.Add(new News { Title = "Are Dogs More Likely To Bite...", Description = "Lorem ipsum dolor sit amet, consectetur adipicing elit, sed do eiusmod tempor incididunt utlabore et dolore magna aliqua. Ut enim…", UrlImage = "news06" });
        }
    }
}
