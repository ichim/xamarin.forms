using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            foreach (var child in grid.Children)
            {
                (child as Image).GestureRecognizers.Add(new TapGestureRecognizer() { 
                    Command = new Command(onImageTap),
                    CommandParameter = new Input()
                    {
                        image=child as Image,
                        name=(child as Image).Source.ToString().Split('.')[0]
                    }

                });
            }
        }

        private void onImageTap(object obj)
        {
            img.Source = (obj as Input).image.Source;
            info.Text = (obj as Input).name;
            Task.Run(async () => {
                await img.RotateTo(img.Rotation + 360, 1500);
            });
            Task.Run(async () => {
                await img.ScaleTo(0.5, 750);
                await img.ScaleTo(1, 750);
            });
        }
    }
    public class Input
    {
        public Image image { get; set; }
        public string name { get; set; }
    }
}
