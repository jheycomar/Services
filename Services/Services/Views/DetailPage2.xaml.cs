using FormsToolkit;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Services.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage2 : ContentPage
    {
        private const int ParallaxSpeed = 5;

        private double lastScroll;
        public DetailPage2()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
           
            base.OnAppearing();

            var navigationPage = Parent as Xamarin.Forms.NavigationPage;

            if (navigationPage != null)
                navigationPage.On<iOS>().EnableTranslucentNavigationBar();

            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, false);
            MessagingService.Current.SendMessage(MessageKeys.ToolbarColor, Color.Transparent);
            
            ParallaxScroll.Scrolled += OnParallaxScrollScrolled;
           
        }

        protected override void OnDisappearing()//cuando regrese de la pagina
        {
            base.OnDisappearing();
            var navigationPage = Parent as Xamarin.Forms.NavigationPage;

            if (navigationPage != null)
                navigationPage.On<iOS>().DisableTranslucentNavigationBar();
            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, true);

            MessagingService.Current.SendMessage(MessageKeys.ToolbarColor, Color.FromHex("#2196F3"));
           
            ParallaxScroll.Scrolled -=  OnParallaxScrollScrolled;
          

        }

        private void OnParallaxScrollScrolled(object sender, ScrolledEventArgs e)
        {
            double translation = 0;

            if (lastScroll < e.ScrollY)
            {
                translation = 0 - ((e.ScrollY / 2));

                if (translation > 0) translation = 0;
                fabBtn.IsVisible = false;
            }
            else
            {
                translation = 0 + ((e.ScrollY / 2));

                if (translation > 0) translation = 0;
                fabBtn.IsVisible = true;
            }
          
            HeaderPanel.TranslateTo(HeaderPanel.TranslationX, translation);           
            lastScroll = e.ScrollY;
        }
    }
}