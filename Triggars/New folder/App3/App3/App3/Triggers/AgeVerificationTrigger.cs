using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.Triggers
{
    public class AgeVerificationTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            var entry = sender as Entry;
            var flag = int.TryParse(entry.Text, out int age);

            entry.BackgroundColor=(!flag) ? (Color.Tomato) : Color.Green;
        }
    }
}
