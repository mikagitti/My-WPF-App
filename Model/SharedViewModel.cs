using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_WPF_App.Model
{
    public class SharedViewModel
    {
        private string _sharedData = "Uskomatonta!";

        public string SharedData
        { 
            get { return _sharedData; } 
            set { 
                _sharedData = value;
                OnPropertyChanged(nameof(SharedData));
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
