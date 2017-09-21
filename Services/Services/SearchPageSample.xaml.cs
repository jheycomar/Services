using Services.CustomRenderers;
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
    public partial class SearchPageSample : SearchPage
    {
        public SearchPageSample()
        {
            InitializeComponent();
        }
    }
}