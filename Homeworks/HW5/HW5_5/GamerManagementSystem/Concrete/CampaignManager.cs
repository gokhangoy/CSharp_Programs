using GamerManagementSystem.Abstract;
using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Concrete
{
    public class CampaignManager : ICampaignService
    {


        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign "+campaign.CampaignName+" has been added." );
        }

        public List<Campaign> Delete(int campaignId, List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                if(campaign.Id == campaignId)
                {
                    Console.WriteLine("Campaign " + campaign.CampaignName + " has been deleted.");
                    campaigns.Remove(campaign);
                }
                    
            }

            return campaigns;
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.CampaignName + " has been updated.");
        }
    }
}
