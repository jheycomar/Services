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

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var navigationPage = Parent as Xamarin.Forms.NavigationPage;

            if (navigationPage != null)
                navigationPage.On<iOS>().DisableTranslucentNavigationBar();

            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, true);
            MessagingService.Current.SendMessage(MessageKeys.ToolbarColor, Color.Black);
        }
    }
}