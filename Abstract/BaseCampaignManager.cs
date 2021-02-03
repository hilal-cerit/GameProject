using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(" NEW CAMPAIGN ADDED! "+ campaign.CampaingText );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("CAMPAIGN DELETED " );
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("CAMPAIGN UPDATED ");
        }
    }
}
