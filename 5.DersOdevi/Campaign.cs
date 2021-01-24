using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DersOdevi
{
    class Campaign
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public string CampaignName { get; set; }
        public int DiscountedPrice { get; set; }
    }
}
