using My_WPF_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace My_WPF_App.View
{
    /// <summary>
    /// Interaction logic for AddPersonView.xaml
    /// </summary>
    public partial class AddPersonView : Window
    {
        private PersonsViewModel _viewModel;

        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PostalNumber { get; set; }
        public string? City { get; set; }        


        public AddPersonView(PersonsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Name = tbName.Text;
            Address = tbAddress.Text;
            City = tbCity.Text;

            if (string.IsNullOrEmpty(tbPostalNumber.Text))
            {
                PostalNumber = 0;
            }
            else
            {
                PostalNumber = int.Parse(tbPostalNumber.Text);
            }

            if (string.IsNullOrEmpty(Name))
            {
                var result = MessageBox.Show("Some values where incorrect! Wanna try again?", "Something went wrong", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }

                return;
            }

            if (_viewModel != null)
            {
                _viewModel.AddNewPerson(Name, Address, PostalNumber, City);
            }

            this.Close();
             
        }
    }
}
