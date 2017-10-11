using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using Xamarin.Forms;
using Services.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(MaterialNavigationRenderer))]

namespace Services.iOS
{
    public class MaterialNavigationRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            // Cree la sombra de material
            NavigationBar.Layer.ShadowColor = UIColor.Black.CGColor;
            NavigationBar.Layer.ShadowOffset = new CGSize(0, 0);
            NavigationBar.Layer.ShadowRadius = 3;
            NavigationBar.Layer.ShadowOpacity = 1;

            // Crear la imagen del icono de flecha hacia atrás
            var arrowImage = UIImage.FromBundle("Icons/Icon.png");
            NavigationBar.BackIndicatorImage = arrowImage;
            NavigationBar.BackIndicatorTransitionMaskImage = arrowImage;

            // Establezca el título del botón de retroceso a vacío ya que el diseño de material no lo utiliza.
            if (NavigationItem?.BackBarButtonItem != null)
                NavigationItem.BackBarButtonItem.Title = " ";
            if (NavigationBar.BackItem != null)
            {
                NavigationBar.BackItem.Title = " ";
                NavigationBar.BackItem.BackBarButtonItem.Image = arrowImage;
            }
        }
    }
}