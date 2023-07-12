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

[assembly:ExportRenderer(typeof(EntryCustomControl),typeof(ControlCustemRenderer))]
namespace CustomRendererExample.iOS
{
    internal class ControlCustemRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor=UIColor.White;
            }
        }
    }
}