using Domain.Base;
using Domain.Interfaces;
using System;

namespace Domain.Models
{
    public class Person : BaseModel<int>, IPerson
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Job { get; set; }
    }
}
