using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Abstract
{
    interface IGamerService
    { 
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
