using GamerManagementSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public  string CampaignName { get; set; }
        public decimal CampaignPrice { get; set; }
    }
}
