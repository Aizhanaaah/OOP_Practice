using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            set {if(value.Year > DateTime.Now.Year)
                    throw new ArgumentException("Birth date cannot be in the future.");
                birthDate = value; } 
        }
        public Animal(string name, string species, string caretaker, DateTime birthDate)
        {
            Name = name;
            Species = species;
            Caretaker = caretaker;
            BirthDate = birthDate;
        }
        public Animal(string line)
        {
            string[] distribution = line.Split(";");
            Name = distribution[0];
            Species = distribution[1];
            BirthDate = DateTime.Parse(distribution[2]);
            Caretaker = distribution[3];
        }
        public virtual void AddCare()
        {
            Console.WriteLine($"Care added for {Name}.");
        }
        public virtual void RemoveCare()
        {
            Console.WriteLine($"Care removed for {Name}.");
        }
        public virtual string showInfo()
        {
            return $"Name: {Name}, Species: {Species}, Caretaker: {Caretaker}, Birth Date: {BirthDate.ToShortDateString()}";
        }
    }
}
