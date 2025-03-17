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

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        public void Login_button_clicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string? envPw=Environment.GetEnvironmentVariable("InvoiceManagement");

            if(envPw != null)
            {
                if(passwordEntered == envPw)
                {
                    MessageBox.Show("Entered Correct Password");
                } else
                {
                    MessageBox.Show("Entered Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("DOESNT EXIST");
            }
        }
    }
}
