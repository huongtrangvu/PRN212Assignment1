using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IAccountRepository
    {
        public void AddAccount(Customer customer);
        public void UpdateAccount(Customer customer);
        public List<Customer> GetAccounts();
        public void DeleteAccount(Customer customer);
        public Customer GetAccountById(int id);
        public Customer GetAccountByEmail(string email);

    }
}
