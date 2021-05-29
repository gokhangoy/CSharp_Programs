using GamerManagementSystem.Abstract;
using GamerManagementSystem.Concrete;
using GamerManagementSystem.Entities;
using System;

namespace GamerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() {

                Id = 1,
                CustomerNo = "1",
                FirstName = "Gökhan",
                LastName = "Göy",
                NationalityId = 123456,
                BirthYear=2000
            };

            Gamer gamer2 = new Gamer()
            {

                Id = 2,
                CustomerNo = "2",
                FirstName = "Gökhan2",
                LastName = "Göy2",
                NationalityId = 123456,
                BirthYear = 1998
            };

            Gamer gamer3 = new Gamer()
            {

                Id = 3,
                CustomerNo = "3",
                FirstName = "Gökhan3",
                LastName = "Göy3",
                NationalityId = 123546,
                BirthYear = 1991
            };

            GamerOperationManager gamerOperationManager = new GamerOperationManager(new Gamer(), new CheckCustomerManager());
            gamerOperationManager.Register(gamer1);
            gamerOperationManager.Update(gamer1);
            gamerOperationManager.Delete(gamer1);

            gamerOperationManager.Register(gamer2);
            gamerOperationManager.Update(gamer2);
            gamerOperationManager.Delete(gamer2);

            gamerOperationManager.Register(gamer3);
            gamerOperationManager.Update(gamer3);
            gamerOperationManager.Delete(gamer3);

            //We can think we are gathering this info somewhere else in application
            Campaign campaign1 = new Campaign() { Id=1,CampaignName="Entry Level", CampaignPrice=Convert.ToDecimal(12.5) };

            Campaign campaign2 = new Campaign() { Id=1,CampaignName="Middle Level", CampaignPrice=Convert.ToDecimal(25) };

            Campaign campaign3 = new Campaign() { Id=1,CampaignName="Advanced Level", CampaignPrice=Convert.ToDecimal(55) };
           
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            campaignManager.Update(campaign2);

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.MakeOrder(gamer1,campaign1);
            orderManager.MakeOrder(gamer2,campaign2);
            orderManager.MakeOrder(gamer3);




        }
    }
}
