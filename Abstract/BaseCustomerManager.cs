using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public  class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("CUSTOMER"+customer.FirstName+ "REGISTERED");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("CUSTOMER" + customer.FirstName + "DELETED");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("CUSTOMER" + customer.FirstName + "UPDATED");
        }
        public virtual void Save(Customer customer)

        {
            Console.WriteLine("SAVED TO DB AND ENTERED THE SYSTEM :"+customer.FirstName);
        }
    }
}
