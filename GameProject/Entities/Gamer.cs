using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer : IPerson
    {
        public int id {get; set;}
        public string FirstName {get; set;}
        public string LastName { get; set;}
        public DateTime BirthYear { get; set; }
        public string identityNumber {get; set;}

    }
}
