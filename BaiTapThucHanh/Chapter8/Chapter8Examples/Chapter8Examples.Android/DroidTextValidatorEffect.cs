﻿using System;
using System.ComponentModel;
using System.Linq;
using Android.Text;
using Android.Widget;
using Chapter8Examples.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Chapter8Examples")]
[assembly: ExportEffect(typeof(DroidTextValidatorEffect),"TextValidatorEffect")]

namespace Chapter8Examples.Droid
{
    public class DroidTextValidatorEffect : PlatformEffect
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
            var view = Control as EditText;
            var effect = (TextValidatorEffect)Element.Effects.
           FirstOrDefault(
            e => e is TextValidatorEffect);
            if (entry.Text.Length > effect.MaxLength)
            {
                view.SetBackgroundColor(Color.FromHex("#f9c5c9").
               ToAndroid());
            }
            else
            {
                view.SetBackgroundColor(Color.FromHex("#c5f9e1").
               ToAndroid());
            }
        }
    }
}