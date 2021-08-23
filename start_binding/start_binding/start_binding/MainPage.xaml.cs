using start_binding.data;
using start_binding.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace start_binding
{
    public partial class MainPage : ContentPage
    {
        BooksStore book_store = new BooksStore();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = book_store;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //book_store.book.current_number--;
            this.borrowing.Text = 21.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(book_store.book.current_number);
        }
    }
}
