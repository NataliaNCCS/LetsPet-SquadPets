﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_SquadPets
{
    public class VaccineRegister
    {
        public Species GetSpeciesVaccine()
        {
            bool valido = true;
            int inputNumerico;
            Species vaccineSpecies;
            do
            {
                Console.WriteLine("Para qual espécie é a vacina a ser cadastrada? (Digite 1 para cachorro ou 2 para gato)");
                if (!valido)
                {
                    Console.WriteLine("Erro na leitura, digite uma das especies acima: ");
                }
                var input = Console.ReadLine();
                valido = int.TryParse(input, out inputNumerico) && (inputNumerico == 1 || inputNumerico == 2);
            } while (!valido);
            vaccineSpecies = (Species)inputNumerico;
            return vaccineSpecies;
        }

        public string GetVaccineName()
        {
            string vaccineName;
            do
            {
                Console.WriteLine("Insira o nome da Vacina a ser cadastrada:");
                vaccineName = Console.ReadLine();
                if (!string.IsNullOrEmpty(vaccineName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return vaccineName;
        }
        public int GetVaccineValidity()
        {
            int vaccineValidity;
            do
            {
                Console.WriteLine("Qual o peso do animal");
                if (int.TryParse(Console.ReadLine(), out vaccineValidity))
                {
                    if (vaccineValidity > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return vaccineValidity;
        }
    }
    
}