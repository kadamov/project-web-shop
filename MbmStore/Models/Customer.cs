using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {

        //fields
        private DateTime birthDate = DateTime.Now;
        private List<string> phoneNumbers = new List<string>();
        //properties
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public int Zip { get; }
        public string City { get; }
        
        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public DateTime BirthDate
        {
            set
            {
                var newBirthDate = value;
                var minAllowedDate = DateTime.Now.Year - 120;
                var maxAllowedDate = DateTime.Now.Year;
                if (newBirthDate.Year > maxAllowedDate || newBirthDate.Year < minAllowedDate)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
            get
            {
                return birthDate;
            }
        }


        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }
        public Customer(string firstName, string lastName, string address, int zip, string city, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
            BirthDate = birthday;
        }
    }
}
