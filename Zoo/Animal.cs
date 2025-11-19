using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal: ICareTaking
    {
        string name, species, caretaker;
        DateTime birthDate;
        public string Name { get { return name; } set { name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public string Caretaker { get { return caretaker; } set { caretaker = value; } }
        public DateTime BirthDate 
        { 
            get { return birthDate; } 
            set {if(birthDate.Year < 2025) 
                birthDate = value; } 
        }
        public Animal(string name, string species, string caretaker, DateTime birthDate)
        {
            Name = name;
            Species = species;
            Caretaker = caretaker;
            BirthDate = birthDate;
        }
        public void AddCare()
        {
            Console.WriteLine($"Care added for {Name}.");
        }
        public void RemoveCare()
        {
            Console.WriteLine($"Care removed for {Name}.");
        }
        string showInfo()
        {
            return $"Name: {Name}, Species: {Species}, Caretaker: {Caretaker}, Birth Date: {BirthDate.ToShortDateString()}";
        }

    }
}
