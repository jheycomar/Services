using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Services.Models;
using FormsToolkit;
using Xamarin.Forms;

namespace Services.Droid
{
    [Activity(Label = "Services", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static Android.Support.V7.Widget.Toolbar ToolBar { get; private set; }
       
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.ToolbarLogo;

            base.OnCreate(bundle);
           
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            MessagingService.Current.Subscribe<bool>(MessageKeys.ChangeToolbar, (page, showLogo) =>
            {
                var logo = FindViewById<ImageView>(Resource.Id.logoImageLayout);
              

                if (showLogo)
                {
                    logo.Visibility = ViewStates.Visible;
                }
                else
                {
                    logo.Visibility = ViewStates.Invisible;
                }
            });
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {           
            ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}

