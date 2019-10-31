using System;
using Xamarin.Forms;

namespace Chapter5Examples.Converters
{
    public class EntryTextLogger : TriggerAction<Entry>
    {
        public EntryTextLogger() { }
        protected override void Invoke(Entry entry)
        {
            Console.WriteLine(entry.Text);
        }
    }
}
