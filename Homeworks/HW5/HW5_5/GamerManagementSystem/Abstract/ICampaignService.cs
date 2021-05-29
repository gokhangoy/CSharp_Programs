using GamerManagementSystem.Concrete;
using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Abstract
{
    public interface ICampaignService
    {
   
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        List<Campaign> Delete(int campaignId, List<Campaign> campaigns);
        
    }
}
