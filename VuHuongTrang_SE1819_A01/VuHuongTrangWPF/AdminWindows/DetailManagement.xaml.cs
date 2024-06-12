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

namespace VuHuongTrangWPF.AdminWindows
{
    /// <summary>
    /// Interaction logic for DetailManagement.xaml
    /// </summary>
    public partial class DetailManagement : Window
    {
        public enum ManagementType
        {
            Customer,
            Room,
            Booking
        }

        private ManagementType managementType;
        private AccountService accountService;
        private RoomBookingService roomBookingService;
        private RoomService roomService;
        public DetailManagement()
        {
            InitializeComponent();
            managementType = ManagementType.Customer;
            accountService = new AccountService();
            roomBookingService = new RoomBookingService();
            roomService = new RoomService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbTitle.Content = "Customer Management";
            lbStartDate.Visibility = Visibility.Hidden;
            lbEndDate.Visibility = Visibility.Hidden;
            dpStartDate.Visibility = Visibility.Hidden;
            dpEndDate.Visibility = Visibility.Hidden;

            //load customer data to datagrid  
            LoadData();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (managementType == ManagementType.Customer)
            {
                CustomerPopUp.IsOpen = true;
            }
            else if (managementType == ManagementType.Room)
            {
                RoomPopup.IsOpen = true;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (managementType == ManagementType.Customer)
            {
                //update information with selected customer
                //display a popup to enter new information to update

            }
            else if (managementType == ManagementType.Room)
            {
                
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IDTextBox.Text.Length > 0)
                {
                    Customer cus = accountService.GetAccountById(Int32.Parse(IDTextBox.Text));
                    accountService.DeleteAccount(cus);

                }
                else
                {
                    MessageBox.Show("You must select a account");
                }

            }
            catch (Exception ex) { }
            finally { LoadData(); }
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;
            //if (managementType == ManagementType.Customer)
            //{
            //    Customer customer = accountService.GetAccountById(Convert.ToInt32(id)) as Customer;
            //    if (customer != null)
            //    {
            //        tbName.Text = customer.Name;
            //        tbEmail.Text = customer.Email;
            //        tbPhone.Text = customer.Phone;
            //        tbAddress.Text = customer.Address;
            //    }
            //}
            //else if (managementType == ManagementType.Room)
            //{
            //    RoomInfomation room = dgData.SelectedItem as RoomInfomation;
            //    if (room != null)
            //    {
            //        tbName.Text = room.Name;
            //        tbEmail.Text = room.Description;
            //        tbPhone.Text = room.Price.ToString();
            //        tbAddress.Text = room.Status.ToString();
            //    }
            //}
            //else if (managementType == ManagementType.Booking)
            //{
            //    RoomBooking booking = dgData.SelectedItem as RoomBooking;
            //    if (booking != null)
            //    {
            //        tbName.Text = booking.Customer.Name;
            //        tbEmail.Text = booking.Room.Name;
            //        tbPhone.Text = booking.StartDate.ToString();
            //        tbAddress.Text = booking.EndDate.ToString();
            //    }
            //}

        }


        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            if (managementType == ManagementType.Booking)
            {
                return;
            }
            managementType = ManagementType.Booking;
            lbTitle.Content = "Booking Management";
            lbStartDate.Visibility = Visibility.Visible;
            lbEndDate.Visibility = Visibility.Visible;
            dpStartDate.Visibility = Visibility.Visible;
            dpEndDate.Visibility = Visibility.Visible;
            btnCreate.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            btnReport.Visibility = Visibility.Visible;
            LoadData();
        }


        private void btnRoom_Click(object sender, RoutedEventArgs e)
        {
            if (managementType == ManagementType.Room)
            {
                return;
            }
            managementType = ManagementType.Room;
            lbTitle.Content = "Room Management";
            lbStartDate.Visibility = Visibility.Hidden;
            lbEndDate.Visibility = Visibility.Hidden;
            dpStartDate.Visibility = Visibility.Hidden;
            dpEndDate.Visibility = Visibility.Hidden;
            btnReport.Visibility = Visibility.Hidden;
            LoadData();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (managementType == ManagementType.Customer)
            {
                return;
            }

            managementType = ManagementType.Customer;
            lbTitle.Content = "Customer Management";
            lbStartDate.Visibility = Visibility.Hidden;
            lbEndDate.Visibility = Visibility.Hidden;
            dpStartDate.Visibility = Visibility.Hidden;
            dpEndDate.Visibility = Visibility.Hidden;
            btnReport.Visibility = Visibility.Hidden;

            LoadData();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //close the window
            this.Close();
        }

        private void LoadData()
        {
            if (managementType == ManagementType.Customer)
            {
                dgData.ItemsSource = accountService.GetAccounts();
            }
            else if (managementType == ManagementType.Room)
            {
                dgData.ItemsSource = roomService.GetRooms();
            }
            else if (managementType == ManagementType.Booking)
            {
                dgData.ItemsSource = roomBookingService.GetRoomBookings();
            }
        }

        private void CustomerPopUp_OkButton_Click(object sender, RoutedEventArgs e)
        {
            var name = NameTextBox.Text;
            var email = EmailTextBox.Text;
            var phone = PhoneTextBox.Text;
            var address = AddressTextBox.Text;
            var birthday = BirthDatePicker.Text;
            var password = PasswordBox.Text;

            //if one of info is null or empty, show a message box to notify
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all information");
                return;
            }
            try
            {
                accountService.AddAccount(new Customer()
                {
                    CustomerFullName = name,
                    EmailAddress = email,
                    TelePhone = phone,
                    CustomerAddress = address,
                    CustomerBirthday = DateOnly.Parse(birthday),
                    Password = password
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
            CustomerPopUp.IsOpen = false;
        }

        private void CustomerPopUp_CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerPopUp.IsOpen = false;
        }

        private void RoomCancelButton_Click(object sender, RoutedEventArgs e)
        {
            RoomPopup.IsOpen = false;
        }

        private void RoomPopup_RoomOkButton_Click(object sender, RoutedEventArgs e)
        {
            RoomPopup.IsOpen = false;
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
