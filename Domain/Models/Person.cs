using Domain.Base;
using Domain.Interfaces;
using System;

namespace Domain.Models
{
    public class Person : BaseModel<int>, IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Job { get; set; }
    }
}
