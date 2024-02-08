namespace My_WPF_App.ViewModel
{
    public class SharedViewModel : ViewModelBase
    {
        private string _sharedData = "David Walker";

        public string SharedData
        {
            get { return _sharedData; }
            set
            {
                _sharedData = value;
                OnPropertyChanged(nameof(SharedData));
            }
       }
    }
}
