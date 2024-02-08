using My_WPF_App.Model;
using System.Windows;

namespace My_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SharedViewModel _viewModel = new SharedViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }
    }
}