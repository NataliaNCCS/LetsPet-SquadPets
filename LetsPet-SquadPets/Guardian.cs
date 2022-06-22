﻿using System;
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

        public Guardian(DateTime registrationDate, List<Animal> petList)
        {
            RegistrationDate = registrationDate;
            PetList = petList;
        }

        
        // MÉTODOS
        public void PrintGuardian()
        {
            Console.WriteLine("IMPRIMINDO TUTOR:");
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"CPF: {Cpf}");
            PersonContact.PrintContact();
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
