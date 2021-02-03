using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Customer:IEntity

    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
