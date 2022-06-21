using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_SquadPets
{
    public class Guardian : Person
    {
        public DateTime RegistrationDate { get; set; }
        public List<Animal> PetList { get; set; }


        // MÉTODOS
        public void PrintGuardian()
        {
            Console.WriteLine("IMPRIMINDO TUTOR:");
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"WhatsApp: {WhatsApp}");
            Console.WriteLine($"Telefone Fixo: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"CEP: {CEP}");
            Console.WriteLine($"Endereço: {StreetName}, {HouseNumber}");
            Console.WriteLine($"Complemento: {AdditionalAddress}");
            Console.WriteLine("\nPETS DO TUTOR:");
            PrintPetList();
        }

        public void PrintPetList()
        {
            foreach(Animal pet in PetList)
                Console.WriteLine(pet);
        }

        public void AddPet(Animal pet)
        {
            PetList.Add(pet);
        }

    }
}
