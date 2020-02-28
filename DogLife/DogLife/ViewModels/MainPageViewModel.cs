using DogLife.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Threading.Tasks;

namespace DogLife.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand ForgotPasswordCommand { get; set; }
        public DelegateCommand RegisterCommand { get; set; }
        public DelegateCommand LoginCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            ForgotPasswordCommand = new DelegateCommand(async () => await ForgotPasswordCommandExecute());
            RegisterCommand = new DelegateCommand(async () => await RegisterCommandxecute());
            LoginCommand = new DelegateCommand(async () => await LoginCommandxecute());
        }

        private async Task LoginCommandxecute()
        {
            await NavigationService.NavigateAsync($"{nameof(DogTabbedPage)}");
        }

        private async Task RegisterCommandxecute()
        {
            await NavigationService.NavigateAsync($"{nameof(RegisterPage)}");
        }

        private async Task ForgotPasswordCommandExecute()
        {
            await NavigationService.NavigateAsync($"{nameof(ChangePasswordPage)}");
        }
    }
}
