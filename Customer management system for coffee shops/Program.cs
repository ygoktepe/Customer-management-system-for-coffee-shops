using Customer_management_system_for_coffee_shops.Abstract;
using Customer_management_system_for_coffee_shops.Adapters;
using Customer_management_system_for_coffee_shops.Concrete;
using Customer_management_system_for_coffee_shops.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_management_system_for_coffee_shops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995,1,17), FirstName = "Yasin", LastName = "Göktepe", NationalityId = "22109223876" });
            Console.ReadLine();
        }
    }
}
