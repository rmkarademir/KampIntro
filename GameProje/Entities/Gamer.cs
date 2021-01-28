using GameProje.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Entities
{
    public class Gamer : IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecurityNumber { get; set; }
        public int BirthYear { get; set; }
    }
}
