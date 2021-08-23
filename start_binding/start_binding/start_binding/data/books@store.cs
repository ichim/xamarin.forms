using start_binding.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace start_binding.data
{
    public class BooksStore
    {
        private Book _book;

        public Book book
        {
            get { return _book; }
            set { _book = value; }
        }
        public BooksStore()
        {
            _book = new Book()
            {
                title = "The Silent Patient",
                launch = new DateTime(2008, 7, 27),
                current_number = 32
            };
        }
    }
}
