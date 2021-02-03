using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
namespace GameProject.Abstract
{
    public interface ICustomerCheckService
    {
       public  bool CheckIfRealPerson(Customer customer);
    }
}
