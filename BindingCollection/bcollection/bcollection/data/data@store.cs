using bcollection.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace bcollection.data
{
    public class DataStore
    {
        LibraryBooks _library = new LibraryBooks();
        public DataStore()
        {
            ObservableCollection<string> books = new ObservableCollection<string> { "Professional Web Pages with C#", "C# and Mobile Applications" };
            _library.books = books;
        }

        public LibraryBooks library
        {
            get => _library; set { _library = value; }
        }
    }
}
