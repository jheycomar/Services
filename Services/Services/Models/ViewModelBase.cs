using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Services.Models
{
    public class ViewModelBase : BindableObject
    {
        private bool isBusy;

        public bool IsBusy //esta ocupado
        {
            get { return isBusy; }

            set { isBusy = value; OnPropertyChanged(); }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
