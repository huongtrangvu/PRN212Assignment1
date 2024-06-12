using BusinessLogicLayer.Services;
using DataAccessLayer.Entities;
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
using System.Windows.Shapes;

namespace VuHuongTrangWPF
{
    /// <summary>
    /// Interaction logic for CustomerProfile.xaml
    /// </summary>
    public partial class CustomerProfile : Window
    {
        private AccountService _accountService;
        private int id;
        private RoomBookingService _bookingService;
        public CustomerProfile(int id)
        {
            InitializeComponent();
            this.id = id;
            _bookingService = new RoomBookingService();
            _accountService = new AccountService();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //display a popup to enter new information to update
            UpdatePopup.IsOpen = true;

        }
        private void btnUpdatePopup_Click(object sender, RoutedEventArgs e)
        {
            //update information
            UpdatePopup.IsOpen = false;
        }
        private void btnCancelPopup_Click(object sender, RoutedEventArgs e)
        {
            //cancel update
            UpdatePopup.IsOpen = false;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProfile(id);
            LoadBooking(id);
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            var name = NameTextBox.Text;
            var email = EmailTextBox.Text;
            var phone = PhoneTextBox.Text;
            var address = AddressTextBox.Text;
            var birthday = BirthDatePicker.Text;
            var password = PasswordBox.Text;

            try
            {
                // Lấy thông tin hiện tại của khách hàng
                Customer currentCustomer = _accountService.GetAccountById(id);

                // Cập nhật thông tin nếu có dữ liệu mới
                if (!string.IsNullOrEmpty(name)) currentCustomer.CustomerFullName = name;
                if (!string.IsNullOrEmpty(email)) currentCustomer.EmailAddress = email;
                if (!string.IsNullOrEmpty(phone)) currentCustomer.TelePhone = phone;
                if (!string.IsNullOrEmpty(address)) currentCustomer.CustomerAddress = address;
                if (!string.IsNullOrEmpty(birthday)) currentCustomer.CustomerBirthday = DateOnly.Parse(birthday);
                if (!string.IsNullOrEmpty(password)) currentCustomer.Password = password;

                // Gọi hàm cập nhật tài khoản với thông tin mới
                _accountService.UpdateAccount(currentCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadProfile(id);
            UpdatePopup.IsOpen = false;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            UpdatePopup.IsOpen = false;


        }
        private void LoadProfile(int id)
        {
            Customer customer = _accountService.GetAccountById(id);
            txtCustomerName.Text = customer.CustomerFullName;
            txtTelePhone.Text = customer.TelePhone;
            txtEmail.Text = customer.EmailAddress;
            txtAddress.Text = customer.CustomerAddress;
            txtBirthday.Text = customer.CustomerBirthday.ToString();
            txtPassword.Text = customer.Password;
        }
        private void LoadBooking(int id)
        {
            //load booking information
            var bookings = _bookingService.GetRoomBookingsByCustomerId(id);
            dgData.ItemsSource = bookings;
        }


    }
}