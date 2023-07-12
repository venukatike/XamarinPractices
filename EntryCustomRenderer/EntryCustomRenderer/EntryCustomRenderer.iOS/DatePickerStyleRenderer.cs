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

[assembly: ExportRenderer(typeof(DatePickerStyle), typeof(DatePickerStyleRenderer))]
namespace EntryCustomRenderer.iOS
{
    internal class DatePickerStyleRenderer : DatePickerRenderer
    {
            protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
            {
                base.OnElementChanged(e);
                Control.TextColor = UIColor.Green;
            }
        }
    }
}