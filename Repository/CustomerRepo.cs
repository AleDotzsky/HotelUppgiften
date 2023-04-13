using Inlamning2DatabasTeknik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2DatabasTeknik.Repository
{
    public class CustomerRepo
    {
        private HotelDatabase _dbConnection;

        public CustomerRepo()
        {
            _dbConnection = new HotelDatabase();
        }

        public void RegisterNewCustomer(Customer customer)
        {
            _dbConnection.Customers.Add(customer);
            _dbConnection.SaveChanges();
        }
        public List<Customer> GetAllCustomers()
        {
            return _dbConnection.Customers.ToList();
        }
        public List<Customer> SearchCustomers(string searchCondition)
        {
            return _dbConnection.Customers.Where(c => c.FirstName.Contains(searchCondition) || c.LastName.Contains(searchCondition) ).ToList();
        }
        public void RemoveCustomer(int customerID)
        {
            _dbConnection.Customers.Remove(GetCustomer(customerID));
            _dbConnection.SaveChanges();
        }
        public Customer GetCustomer(int customerID)
        {
            return _dbConnection.Customers.Find(customerID);
        }
        public void UpdateCustomer(int customerID, Customer newCustomer)
        {
            Customer orgCustomer = GetCustomer(customerID);
            _dbConnection.Entry(orgCustomer).CurrentValues.SetValues(newCustomer);
            _dbConnection.SaveChanges();
        }
    }
}
