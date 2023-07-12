using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using EntryCustomRenderer;
using EntryCustomRenderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryStyle), typeof(EntryStyleRenderer))]
namespace EntryCustomRenderer.Droid
{
    public class EntryStyleRenderer : EntryRenderer
    {
        public EntryStyleRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                GradientDrawable gd = new GradientDrawable();
               Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(global::Android.Graphics.Color.Gray);
                gd.SetCornerRadius(15);
                Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
               
            }
        }
    }
}