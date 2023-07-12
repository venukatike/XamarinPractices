using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace App3.NewFolder
{
    internal class BehaviorClass1 : Behavior<Entry>
    {

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += EmailEntryChanged;
            base.OnAttachedTo(entry);
        }

        private void EmailEntryChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = (Entry)sender;
            if(!string.IsNullOrEmpty(entry.Text))
            {
                string emailRegEx = @"^([\w\.\-]+)@([\w\-] +)((\.(\w){2,3})+)$";
                bool isMacthed = Regex.IsMatch(entry.Text, emailRegEx);
                if (isMacthed)
                    entry.TextColor = Color.Black;
                else
                    entry.TextColor = Color.Red;
            }
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= EmailEntryChanged;
            base.OnDetachingFrom(entry);
        }
    }
}
