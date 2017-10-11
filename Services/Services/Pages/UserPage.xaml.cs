using Services.Navigation;
using Services.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Services.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        private NavigationService2 navigationService2=new NavigationService2();
        public UserPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new Views.DetailPage2());
        }

        private void fabBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Info","Uste iso click","Acep");
        }
    }
}