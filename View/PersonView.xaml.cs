using My_WPF_App.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace My_WPF_App.View
{
    public partial class PersonView : UserControl
    {
        private int result;

        public PersonView()
        {
            InitializeComponent();        
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {       
            PersonsViewModel? viewModel = DataContext as PersonsViewModel;

            AddPersonView addPersonWindow = new AddPersonView(viewModel);
            addPersonWindow.Show();
            /*

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

            */
        }
    }
}
