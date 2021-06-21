using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DragDropImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            Image image = (sender as Element)?.Parent as Image;
            image.Opacity = 0.4;
            e.Data.Properties.Add("Demo", image);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var image = e.Data.Properties["Demo"] as Image;
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = image;
            Task.Run(async () => {
                await image.RotateTo(360, 1000);
            });
            Task.Run(async () => {
                await image.ScaleTo(1.4, 400);
                await image.FadeTo(1, 600);
            });

        }
    }
}





























