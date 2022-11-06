using Customer_management_system_for_coffee_shops.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_management_system_for_coffee_shops.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
