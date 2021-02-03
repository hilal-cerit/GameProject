using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void SignIn(Customer customer)
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
        public virtual void Validation(Customer customer)

        {
            Console.WriteLine("SAVED TO DB AND CAN ENTER THE SYSTEM :"+customer.FirstName);
        }
    }
}
