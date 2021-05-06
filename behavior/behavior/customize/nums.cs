using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace behavior.customize
{
    public class Numbers:Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
                return;
            if (String.IsNullOrWhiteSpace(e.NewTextValue))
                (sender as Entry).Text = e.OldTextValue;
            if (!double.TryParse(e.NewTextValue, out _))
                (sender as Entry).Text = e.OldTextValue;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }
    }
}
