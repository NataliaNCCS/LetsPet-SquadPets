using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_SquadPets
{
    public class Person
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Contact PersonContact { get; set; }
        public DateTime RegisterDate { get; set; }
        
    }
}
