using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public class SuperheroModel
    {
        public Guid SuperHeroId { get; init; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public SuperheroModel(string name) 
        {
            Name = name;
            IsActive = true;
   
        }
    }    
}