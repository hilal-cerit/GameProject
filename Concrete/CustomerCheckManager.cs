using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CustomerCheckManager :ICustomerCheckService
    {
        //can be use for test drive 
             public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        
    }
}
