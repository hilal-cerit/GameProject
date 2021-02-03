using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
  public   class CampaignManager:BaseCampaignManager

    {

        public void Add(Campaign campaign)
        {
            Console.WriteLine(" NEW CAMPAIGN ADDED "+campaign.CampaingText);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("CAMPAIGN DELETED ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("CAMPAIGN UPDATED ");
        }

    }
}
