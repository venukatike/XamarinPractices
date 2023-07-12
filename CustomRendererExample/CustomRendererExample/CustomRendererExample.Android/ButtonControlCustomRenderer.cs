using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRendererExample.Droid;
using CustomRendererExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(ButtonControlCustom), typeof(ButtonControlCustomRenderer))]

namespace CustomRendererExample.Droid
{
    internal class ButtonControlCustomRenderer : ButtonRenderer
    {
        public ButtonControlCustomRenderer(Context context):base(context)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if(Control!= null)
            {
                GradientDrawable gd = new GradientDrawable();
                Control.SetBackgroundColor(global::Android.Graphics.Color.Purple);
                Control.SetTextColor(global::Android.Graphics.Color.White);
          
            }
        }
    }
}