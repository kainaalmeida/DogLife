using DogLife.Models;
using Prism.Mvvm;
using System.Collections.Generic;

namespace DogLife.ViewModels
{
    public class HomePageViewModel : BindableBase
    {

        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public HomePageViewModel()
        {
            Dogs.Add(new Dog {Name = "Baxter Johnson", Bones = 42, Snaps = 20, HourAdd="4:30 PM", UrlIamge = "dog01", Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor amet..." });
            Dogs.Add(new Dog {Name = "Hank Lozano", Bones = 55, Snaps = 13, HourAdd = "4:30 PM", UrlIamge = "dog02", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor amet..." });
        }
    }
}
