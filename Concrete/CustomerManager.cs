using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
   public class CustomerManager:BaseCustomerManager

    {
        ICustomerCheckService _customerCheckService;

     

        public CustomerManager( ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

     


        public override void Validation(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {    
                 base.Validation(customer);
                  base.SignIn(customer);
            }
            else
            {
                throw new Exception("NOT A VALID PERSON");
            }
          
        }


       


    }
}
