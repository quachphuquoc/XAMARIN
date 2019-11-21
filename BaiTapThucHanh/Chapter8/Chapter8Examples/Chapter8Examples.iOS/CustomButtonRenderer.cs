using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using Chapter8Examples;
using Chapter8Examples.iOS;

[assembly: ExportRenderer(typeof (CustomButton), typeof (CustomButtonRenderer))]
namespace Chapter8Examples.iOS
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged
        (ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Brown;
            }
        }
    }
}