using CustomRendererExample;
using CustomRendererExample.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(ButtonControlCustom),typeof(ButtonControlCustomRenderer))]
namespace CustomRendererExample.iOS
{
    internal class ButtonControlCustomRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
           if(Control!= null)
            {
                
            }
        }
    }
}