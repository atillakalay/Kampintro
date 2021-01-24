using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DersOdevi
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Adı " + campaign.CampaignName+" kampanya eklendi .");
        }
        //public void GetAllCampaign()
        //{
        //    foreach (var x in campaigns)
        //    {
        //        Console.WriteLine("Kampanyalar");
        //        Console.WriteLine("Kampanya Ad : "+x.CampaignName);
        //        Console.WriteLine("Oyun Adı : "+x.Game.GameName);
        //        Console.WriteLine("İnidirimli Fiyat : "+x.DiscountedPrice);
        //    }
        //}
    }
}
