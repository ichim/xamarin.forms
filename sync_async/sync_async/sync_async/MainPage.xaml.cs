using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sync_async
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {//sync async code
            Task.Run(async () => {
                await this.image.TranslateTo(190, 190, 1500, Easing.SinInOut);
                await this.image.TranslateTo(0, 0, 1500, Easing.SinInOut);
            });
            Task.Run(async () => {
                await this.image.RotateTo(360, 1500, Easing.SinInOut);
                await this.image.RotateTo(0, 1500, Easing.SinInOut);
            });
            Task.Run(async () => {
                await this.image.ScaleTo(1.3, 1500, Easing.SinInOut);
                await this.image.ScaleTo(1, 1500, Easing.SinInOut);
            });

            










        }
    }
}
