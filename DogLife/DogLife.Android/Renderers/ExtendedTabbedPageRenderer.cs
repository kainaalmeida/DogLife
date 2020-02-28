using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Internal;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using DogLife.Controls;
using DogLife.Droid.Renderers;
using DogLife.Droid.Utils;
using DogLife.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

[assembly: ExportRenderer(typeof(ExtendedTabbedPage), typeof(ExtendedTabbedPageRenderer))]
namespace DogLife.Droid.Renderers
{
    class ExtendedTabbedPageRenderer : TabbedPageRenderer
    {
        private ExtendedTabbedPage _formsTabs;
        private BottomNavigationView _bottomNavigationView;

        public ExtendedTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formsTabs = Element as ExtendedTabbedPage;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;

                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.SetMinimumHeight(100);
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = 70;
                _bottomNavigationView.SetShiftMode(false, false);
                _bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;

                UpdateAllTabs();
            }

            if (e.OldElement != null)
            {
                _formsTabs.CurrentPageChanged -= OnCurrentPageChanged;
            }
        }


        private void UpdateAllTabs()
        {
            for (var index = 0; index < _formsTabs.Children.Count; index++)
            {
                var androidTab = _bottomNavigationView.Menu.GetItem(index);
                int iconId;

                if (_formsTabs.Children[index] is ITabPageIcons tabPage)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        iconId = ResourceUtil.GetDrawableIdByFileName(tabPage.GetSelectedIcon(), Context);
                        androidTab.SetIcon(iconId);
                        continue;
                    }

                    iconId = ResourceUtil.GetDrawableIdByFileName(tabPage.GetIcon(), Context);
                    androidTab.SetIcon(iconId);
                    continue;
                }
            }
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            UpdateAllTabs();
        }
    }
}