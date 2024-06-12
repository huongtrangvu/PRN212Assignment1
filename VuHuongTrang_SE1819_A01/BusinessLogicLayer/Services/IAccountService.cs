
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public interface IAccountService
    {
        public void AddAccount(Customer customer);
        public void UpdateAccount(Customer customer);
        public ObservableCollection<Customer> GetAccounts();
        public void DeleteAccount(Customer customer);
        public Customer GetAccountById(int id);
        public Customer GetAccountByEmail(string email);
    }
}
