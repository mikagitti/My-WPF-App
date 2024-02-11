using My_WPF_App.Model;
using My_WPF_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public partial class PersonView : UserControl
    {
        private int result;

        public PersonView()
        {
            InitializeComponent();        
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {       
            /*
             ToDo: Need to write code so dialog dosen't close before user gives permission to close.
            */

            AddPersonView dialog = new AddPersonView();            
            if (dialog.ShowDialog() == true)             
            {   
                if (string.IsNullOrEmpty(dialog.tbName.Text))
                {
                    var result = MessageBox.Show("Some values where incorrect! Wanna try again?", "Something went wrong", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {                        
                        return;
                    }                    
                }
                
                PersonsViewModel? viewModel = DataContext as PersonsViewModel;
                
                if (viewModel != null)
                {
                    string? name = dialog.tbName.Text;
                    string? address = dialog.tbAddress.Text;
                    string? city = dialog.tbCity.Text;

                    string? txtpostalnumber = dialog.tbPostalNumber.Text;
                    int intpostalnumber;

                    if (!int.TryParse(txtpostalnumber, out intpostalnumber))
                        intpostalnumber = 0;
                    
                    viewModel.AddNewPerson(name, address, intpostalnumber, city);
                }
            }
        }
    }
}
