using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace start_binding.models
{
    public class Book:INotifyPropertyChanged
    {
        private string _title;
        private DateTime _launch;
        private int _current_number;
        public string title { get => _title; set { _title = value; RaisePropertyChanged(nameof(title)); } }
        public DateTime launch { get => _launch; set { _launch = value; RaisePropertyChanged(nameof(launch)); } }
        public int current_number { get => _current_number; set { _current_number = value;RaisePropertyChanged(nameof(current_number)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }


    }
}
