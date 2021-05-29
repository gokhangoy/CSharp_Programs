using GamerManagementSystem.Abstract;
using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Concrete
{
    class OrderManager
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void MakeOrder(Gamer gamer, Campaign campaign=null) 
        {
            //You can check some conditions here(age, balance or etc.)

            if (campaign == null)
            {
                Console.WriteLine(gamer.FirstName + " has bought the game without using any campaign.");
            }
            else
            {
                
                Console.WriteLine(gamer.FirstName + " has bought the game using : "+campaign.CampaignName);
            }
            

            
        }
    }
}
