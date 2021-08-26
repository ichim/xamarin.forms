using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace bcollection.models
{
    public class LibraryBooks
    {
        public ObservableCollection<string> books { get; set; }
    }
}
