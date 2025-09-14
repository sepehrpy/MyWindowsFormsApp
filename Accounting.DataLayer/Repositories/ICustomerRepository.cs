using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();

        List<ListCustomerViewModel> GetNameCustomers(string filter = "");

        IEnumerable<Customer> GetCustomerByFilter(string Parameter);

        Customer GetCustomerById(int customerid);

        int GetIdByName(string name);

        bool InsertCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Customer customer);

        bool DeleteCustomerById(int customerid);

        string GetCustomerNameById(int customerid);

    }
}
