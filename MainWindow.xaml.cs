using My_WPF_App.Data;
using My_WPF_App.ViewModel;
using System.Windows;

namespace My_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void PersonsViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataProvider _personDataProvider = new();

            //My_WPF_App.ViewModel.PersonsViewModel personsViewModelObject = new My_WPF_App.ViewModel.PersonsViewModel(_personDataProvider);
            //personsViewModelObject.GetPersonData();

            //PersonsViewControl.DataContext = personsViewModelObject;
        }
    }
}