using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UBNT.ViewController;
using UBNT.ViewModel;

namespace UBNT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Scroll();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new MainPageViewModel(Navigation);
            Scroll();
        }

        private async void Scroll()
        {
            scr.TranslationX = -500;
            await scr.TranslateTo(0, 0, 250, Easing.BounceIn);
        }
    }
}
