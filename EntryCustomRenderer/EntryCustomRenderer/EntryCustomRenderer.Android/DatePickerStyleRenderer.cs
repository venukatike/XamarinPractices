using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EntryCustomRenderer.Droid;
using EntryCustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DatePickerStyle), typeof(DatePickerStyleRenderer))]
namespace EntryCustomRenderer.Droid
{
    [Obsolete]
    public class DatePickerStyleRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);
            Control.SetTextColor(global::Android.Graphics.Color.Red);
           
        }
    }
}