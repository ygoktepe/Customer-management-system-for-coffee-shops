using Customer_management_system_for_coffee_shops.Abstract;
using Customer_management_system_for_coffee_shops.Entities;
using Customer_management_system_for_coffee_shops.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Customer_management_system_for_coffee_shops.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
