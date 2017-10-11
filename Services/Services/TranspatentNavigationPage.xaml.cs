using FormsToolkit;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Services
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TranspatentNavigationPage : Xamarin.Forms.NavigationPage
    {
        public TranspatentNavigationPage()
        {
            InitializeComponent();
        }
        public TranspatentNavigationPage(Xamarin.Forms.Page root) :base (root)
        {
            InitializeComponent();
            MessagingService.Current.Subscribe<Color>(MessageKeys.ToolbarColor, (page, color) =>
            {
                BarBackgroundColor = color;
            });

        }
    }
}