using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DragDropView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            BoxView boxview = (sender as Element)?.Parent as BoxView;
            e.Data.Properties.Add("Demo", boxview);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var box_view = e.Data.Properties["Demo"] as BoxView;
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = box_view;


        }
    }
}
