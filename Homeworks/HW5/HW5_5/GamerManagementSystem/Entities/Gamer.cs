using GamerManagementSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
