using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseSaleManager : ISaleService, ICustomerCheckService
    {

      

        public  void Buy(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " BOUGHT THIS GAME : " + game.ProductName);
        }

        public void CalculateNewPrice(Game game, Campaign campaign)
        {
        
             game.campaignPrice = game.Price * campaign.CampaignPercent;
        }

        public void CampaignBuy(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " BOUGHT THE GAME IN CAMPAIGN THIS PRICE : " + game.campaignPrice + " INSTEAD OF THIS " +game.Price);
        }
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

       
    }
}
