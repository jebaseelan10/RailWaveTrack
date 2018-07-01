using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RailWaveTrack.Behaviour
{
    public class PNRValidationBehavior:Behavior<Entry>
    {
        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create("MaxLength", typeof(int), typeof(PNRValidationBehavior), 0);

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
           
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
            
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            bool isValid = double.TryParse(e.NewTextValue, out result);

            if(e.NewTextValue.Length >= MaxLength)
                    ((Entry)sender).Text = e.NewTextValue.Substring(0, MaxLength);

            if (((Entry)sender).Text.Length == MaxLength)
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
            else
                ((Entry)sender).TextColor = Color.Red;
        }
    }
}
