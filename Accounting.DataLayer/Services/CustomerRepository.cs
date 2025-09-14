using Accounting.DataLayer.Repositories;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
          if(filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    FullName = c.FullName,
                    CustomerID = c.CustomerID
                    
                }).ToList();
            }

            return db.Customers
                     .Where(c => c.FullName.ToLower().Contains(filter.ToLower()))
                     .Select(c => new ListCustomerViewModel()
                     {
                         FullName = c.FullName
                     })
                     .ToList();
        }


        public bool DeleteCustomer(Customer customer)
        {
            try
            {
               db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomerById(int customerid)
        {
            try
            {
                var customer = GetCustomerById(customerid);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public IEnumerable<Customer> GetCustomerByFilter(string Parameter)
        {
            return db.Customers.Where(c=> c.FullName.Contains(Parameter) || 
            c.Email.Contains(Parameter) || c.Address.Contains(Parameter) || 
            c.Mobile.Contains(Parameter)).ToList();
        }

        public Customer GetCustomerById(int customerid)
        {
            //return db.Customers.Where(c => c.CustomerID == customerid).SingleOrDefault();
            return db.Customers.Find(customerid);
        }



        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetIdByName(string name)
        {
            //return db.Customers.Where(c=> c.FullName == name).Select(c => c.CustomerID).First();
            return db.Customers.First(c=> c.FullName == name ).CustomerID;
        }

        public string GetCustomerNameById(int customerid)
        {
            return db.Customers.Find(customerid).FullName;
        }
    }
}
