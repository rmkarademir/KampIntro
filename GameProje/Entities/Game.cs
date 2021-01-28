using GameProje.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Entities
{
    public class Game : IEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
        public string Catagory { get; set; }

    }
}
