using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_SquadPets
{
    public class VaccineSystemRegister
    {
        public string VaccineName { get; set; }
        public Species SpeciesVaccine { get; set; }
        public int VaccineValidity { get; set; }

        public List<VaccineRegister> ListVaccine { get; set; }

        public VaccineSystemRegister(string vaccineName, Species speciesVaccine, int vaccineValidity)
        {
            VaccineName = vaccineName;
            SpeciesVaccine = speciesVaccine;
            VaccineValidity = vaccineValidity;
        }

        public void AddVaccineRegister(VaccineRegister vaccine)
        {
            ListVaccine.Add(vaccine);
        }

    }

}
