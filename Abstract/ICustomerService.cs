using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICustomerService
    {
        void SignIn(Customer customer);//registration
        void Delete(Customer customer);
        void Update(Customer customer);
        void Validation(Customer customer);
    }
}
