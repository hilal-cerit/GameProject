using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game:IEntity

    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double campaignPrice { get; set; }






    }
}
