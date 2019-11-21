using System;
using System.ComponentModel;
using System.Linq;
using Chapter8Examples.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Chapter8Examples")]
[assembly: ExportEffect(typeof(IOSTextValidatorEffect),"TextValidatorEffect")]
namespace Chapter8Examples.iOS
{
    public class IOSTextValidatorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Validate();
        }
        protected override void OnDetached() { }
        protected override void
        OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "Text") Validate();
        }
        private void Validate()
        {
            var entry = Element as Entry;
            var view = Control as UITextField;
            var effect = (TextValidatorEffect)Element.Effects.FirstOrDefault(
            e => e is TextValidatorEffect);
            if (entry.Text.Length > effect.MaxLength)
            {
                view.BackgroundColor = Color.FromHex("#f9c5c9").
               ToUIColor();
            }
            else
            {
                view.BackgroundColor = Color.FromHex("#c5f9e1").ToUIColor();
            }
        }
    }
}