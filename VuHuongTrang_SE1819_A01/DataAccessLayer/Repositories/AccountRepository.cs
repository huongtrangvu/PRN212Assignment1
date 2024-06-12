using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AccountRepository : IAccountRepository

    {
        public void AddAccount(Customer customer )
        {
            ApplicationDbContext.Customers.Add(customer);
        }

        public void DeleteAccount(Customer customer)
        {
            var customerToDelete = ApplicationDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if(customerToDelete != null)
                customerToDelete.CustomerStatus = false;
        }

        public Customer GetAccountByEmail(string email)
        {
            return ApplicationDbContext.Customers.FirstOrDefault(c => c.EmailAddress == email);
        }

        public Customer? GetAccountById(int id)
        {
            var customer = ApplicationDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            return customer;
        }

        public List<Customer> GetAccounts()
        {
            return ApplicationDbContext.Customers;
        }
        public void UpdateAccount(Customer customer)
        {
            var customerToUpdate = ApplicationDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.CustomerFullName = customer.CustomerFullName;
                customerToUpdate.EmailAddress = customer.EmailAddress;
                customerToUpdate.TelePhone = customer.TelePhone;
                customerToUpdate.CustomerBirthday = customer.CustomerBirthday;
                customerToUpdate.CustomerStatus = customer.CustomerStatus;
                customerToUpdate.CustomerAddress = customer.CustomerAddress;
                customerToUpdate.Password = customer.Password;

            }
        }

    }
}
