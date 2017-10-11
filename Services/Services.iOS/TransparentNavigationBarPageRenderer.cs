using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Services.iOS
{
    public class TransparentNavigationBarPageRenderer: PageRenderer
    {
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if (NavigationController != null)
            {
                NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
                NavigationController.NavigationBar.ShadowImage = new UIImage();
                NavigationController.NavigationBar.BarTintColor = UIColor.Clear;
                NavigationController.NavigationBar.TintColor = UIColor.White;
            }
        }
    }
}