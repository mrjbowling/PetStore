using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
    }
}