using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
