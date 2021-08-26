using bcollection.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bcollection
{
    public partial class MainPage : ContentPage
    {
        DataStore data_store = new DataStore();
  
        public MainPage()
        {
            InitializeComponent();

            BindingContext = data_store.library;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            data_store.library.books.Add("CLR via C#");
        }
    }

}
