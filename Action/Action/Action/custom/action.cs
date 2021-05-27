using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Action.custom
{
    public class action : TriggerAction<Entry>
    {
        public int activate { get; set; }
        protected override void Invoke(Entry sender)
        {
           if(activate == 100)
            {//EnterAction
                sender.Animate("Animation_name", new Animation((value) => {
                    sender.BackgroundColor = Color.FromRgb(1, value, 1 - value);
                }),
                length:1000, //1 sec
                easing:Easing.Linear
                );
            }

           if(activate == 101)
            {//ExitAction
                sender.BackgroundColor = new Entry().BackgroundColor;
            }
        }
    }
}
