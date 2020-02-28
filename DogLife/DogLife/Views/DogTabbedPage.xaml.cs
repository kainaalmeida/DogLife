using DogLife.Controls;
using DogLife.Interfaces;
using Xamarin.Forms;

namespace DogLife.Views
{
    public partial class DogTabbedPage : ExtendedTabbedPage
    {
        public DogTabbedPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if (CurrentPage is IDynamicTitle page)
            {
                NavigationPage.SetHasNavigationBar(this, true);
                NavigationPage.SetTitleView(this, page.GetTitle());
                return;
            }

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
