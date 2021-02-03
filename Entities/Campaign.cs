using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
   public class Campaign:IEntity

    {


        public int Id { get; set; }
        public string CampaingText { get; set; }
        public DateTime TimeOfBegin { get; set; }
        public int CampaignPrice { get; set; }
        public double CampaignPercent { get; set; }


    }
}
