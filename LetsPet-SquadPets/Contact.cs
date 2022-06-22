﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_SquadPets
{
    public class Contact
    {
        protected string Street { get; set; }
        protected int Number { get; set; }
        protected string AdditionalAddressInfo { get; set; }
        protected string District { get; set; }
        protected string City { get; set; }
        protected string State { get; set; }
        protected string ZipCode { get; set; }
        protected string Phone { get; set; }
        protected string MobileNumber { get; set; }
        protected string Email { get; set; }

        public Contact(string street, int number, string district,
            string city, string state, string zipcode,
            string mobileNumber, string email,
            string phone = "", string addInfo = "")
        {
            Street = street;
            Number = number;
            AdditionalAddressInfo = addInfo;
            District = district;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
            MobileNumber = mobileNumber;
            Email = email;
        }
        public Contact()
        {
            Contact NewContact = RegisterContact();
            Street = NewContact.Street;
            Number = NewContact.Number;
            AdditionalAddressInfo = NewContact.AdditionalAddressInfo;
            District = NewContact.District;
            City = NewContact.City;
            State = NewContact.State;
            ZipCode = NewContact.ZipCode;
            Phone = NewContact.Phone;
            MobileNumber = NewContact.MobileNumber;
            Email = NewContact.Email;
        }

        public void UpdateAdress(string street, int number, string district,
            string city, string state, string zipcode,
            string mobileNumber, string email,
            string phone = "", string addInfo = "")
        {
            Street = street;
            Number = number;
            AdditionalAddressInfo = addInfo;
            District = district;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
            MobileNumber = mobileNumber;
            Email = email;
        }
        public Contact RegisterContact()
        {
            string street, district, city, state, zipcode, mobileNumber, email, phone, addInfo;
            int number;

            Header();
            street = Validation.ValidateStringInput("Informe o nome da rua/avenida:", "O nome da Rua/Avenia é inválido.");

            Header();
            number = Validation.ValidatePositiveIntInput("Informe o número:", "O numero informado é inválido.");

            Header();
            district = Validation.ValidateStringInput("Informe o nome do bairro:", "O nome do bairro é inválido.");

            Header();
            city = Validation.ValidateStringInput("Informe o nome da cidade:", "O nome da cidade é inválida.");

            Header();
            state = Validation.ValidateStringInput("Informe o nome do estado:", "O nome do estado é inválido.");

            Header();
            zipcode = Validation.ValidateZipCodeInput("Informe o CEP");

            Header();
            mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone:");

            Header();
            email = Validation.ValidadeEmailInput("Informe o email:");

            Header();
            if (OptionalInfos("Possuiu telefone fixo?"))
            {
                phone = mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone fixo:", "Telefone digitado inválido!\nDigite no formato (12)1234-1234");
            }
            else
                phone = "";

            Header();
            if (OptionalInfos("Alguma informamação adicional?"))
            {
                addInfo = Validation.ValidateStringInput("Descreva a observação:", "O campo de observação está em branco.");
            }
            else
                addInfo = "";

            return new Contact(street, number, district, city, state, zipcode, mobileNumber, email, phone, addInfo);
        }
        private void Header()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE CONTATO -------");
        }
        private bool OptionalInfos(string question, string ErrorMessage = "Input inválido.")
        {
            string response, options = "(S/N)";
            bool validation;
            do
            {
                Console.WriteLine($"{question} {options}");
                response = Console.ReadLine();
                response = response.ToUpper();
                validation = response != "S" && response != "N" || string.IsNullOrWhiteSpace(response);
                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);

            if (response == "S") return true;

            return false;

            
        }

        public void PrintContact()
        {
            Console.WriteLine($"WhatsApp: {MobileNumber}");
            Console.WriteLine($"Telefone Fixo: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"CEP: {ZipCode}");
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Complemento: {AdditionalAddressInfo}");
            Console.WriteLine($"Bairro:{District}");
            Console.WriteLine($"Cidade: {City} - {State}");
            Console.WriteLine("\nPETS DO TUTOR:");

         
        }
    }
}   

