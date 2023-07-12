using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRendererExample;
using CustomRendererExample.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryCustomControl), typeof(ControlCustomRenderer))]
namespace CustomRendererExample.Droid
{
    
    internal class ControlCustomRenderer : EntryRenderer
    {
        public ControlCustomRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control!=null)
            {
                GradientDrawable gd = new GradientDrawable();
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                gd.SetCornerRadius(25);
               
            }
        }
    }
}