using GameProject.Abstract;
using System;
using GameProject.Entities;
using GameProject.Concrete;
using GameProject.Adapters;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { YearOfBirth = 2001, FirstName = "HİLAL", LastName = "CERİT", NationalityId = 12748271888 };
             BaseCustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
             customerManager.Save(customer1);

            Game game1 = new Game();
            game1.ProductName = "CS:GO";
            game1.Price = 200;
            BaseSaleManager saleManager = new SaleManager();
            saleManager.Buy(customer1,game1);
      

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaingText = "%20 INDIRIM BASLADI";
            campaign1.CampaignPercent= 0.2 ; 

            BaseCampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);
            saleManager.CalculateNewPrice(game1, campaign1);
            saleManager.CampaignBuy(customer1,game1);

        }
    }
}
