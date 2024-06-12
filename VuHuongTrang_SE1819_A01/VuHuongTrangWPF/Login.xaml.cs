using BusinessLogicLayer.Services;
using DataAccessLayer.Entities;
using VuHuongTrangWPF.AdminWindows;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
using System.Windows.Shapes;


namespace VuHuongTrangWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private AccountService _accountService;
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Customer account = _accountService.GetAccountByEmail(txtUser.Text);
            string AdminEmail = "a";
            string AdminPassword = "a";

            if (account != null && account.Password == txtPass.Password && account.EmailAddress != AdminEmail)
            {
                this.Hide();
                CustomerProfile customerProfile = new CustomerProfile(account.CustomerId);
                customerProfile.Show();

            }
            else if (txtUser.Text == AdminEmail && txtPass.Password == AdminPassword)
            {
                this.Hide();
                DetailManagement detailManagement = new();
                detailManagement.Show();

            }
            else
            {
                MessageBox.Show("You do not have permission!");
                //MessageBox.Show($"AdminEmail: {AdminEmail}, AdminPassword: {AdminPassword}");
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
