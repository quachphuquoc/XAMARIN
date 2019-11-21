using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using Chapter8Examples.Droid;
using Chapter8Examples;

[assembly: ExportRenderer(typeof(CustomButton), typeof (CustomButtonRenderer))]
namespace Chapter8Examples.Droid
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged
        (ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LimeGreen);
            }
        }
    }
}