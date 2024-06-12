
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public void AddAccount(Customer customer)
        {
            _accountRepository.AddAccount(customer);
        }

        public void DeleteAccount(Customer customer)
        {
            _accountRepository.DeleteAccount(customer);
        }

        public Customer GetAccountByEmail(string email)
        {
            return _accountRepository.GetAccountByEmail(email);
        }

        public Customer GetAccountById(int id)
        {
            return _accountRepository.GetAccountById(id);
        }

        public ObservableCollection<Customer> GetAccounts()
        {
            return new ObservableCollection<Customer>(_accountRepository.GetAccounts());
        }

        public void UpdateAccount(Customer customer)
        {
            _accountRepository.UpdateAccount(customer);
        }
    }
}
