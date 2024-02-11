using System.Collections.ObjectModel;

namespace My_WPF_App.ViewModel
{
    public class SharedViewModel : ViewModelBase
    {
        private string _sharedName = "David Walker";
        private string _sharedAddress = "Viittatie 313";
        
        public ObservableCollection<string> Items { get; set; }

        public SharedViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        public string SharedName
        {
            get { return _sharedName; }
            set
            {
                _sharedName = value;
                OnPropertyChanged(nameof(SharedName));
            }
        }

        public string SharedAddress
        {
            get { return _sharedAddress; }
            set
            {
                _sharedAddress = value;
                OnPropertyChanged(nameof(SharedAddress));
            }
        }

    }
}
