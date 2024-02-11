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
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PostalNumber { get; set; }
        public string? City { get; set; }        


        public AddPersonView()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
            
                        
            this.DialogResult = true;
        }
    }
}
