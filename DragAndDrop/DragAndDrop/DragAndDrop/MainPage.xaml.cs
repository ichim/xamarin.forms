using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DragAndDrop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Label label = null;
        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Demo", label.Text);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var data = e.Data.Properties["Demo"].ToString();
            var stack = (sender as Element)?.Parent as StackLayout;
            stack.Children.Add(new Label { 
                Text = data,
                TextColor = Color.Yellow,
                FontSize = 36,
                HorizontalTextAlignment = TextAlignment.Center
            });
            label.Text = "";



        }
    }
}
