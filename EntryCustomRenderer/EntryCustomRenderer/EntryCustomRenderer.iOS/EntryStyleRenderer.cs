using EntryCustomRenderer;
using EntryCustomRenderer.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(EntryStyle), typeof(EntryStyleRenderer))]
namespace EntryCustomRenderer.iOS
{
    internal class EntryStyleRenderer: LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control!= null)
            {
                Control.BackgroundColor= UIColor.FromRGB(204, 153, 255);
                Control.TextColor= UIColor.White;
            }
        }
    }
}