using Services.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Services.Navigation
{
   public class NavigationService2
    {
      
        public async Task Navigate(string pageName)
        {            

            switch (pageName)
            {
                case "DetailPage2":

                    await  App.Navigator.PushAsync(new DetailPage2());
                    break;
               
                default:
                    break;
            }
        }
    }
}
