using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Care
    {
        //data field of the class Care:
        string animal, careType;
        DateTime careDate;
        //Setting properties for the data fields:
        public string Animal { get { return animal; } set { animal = value; } }
        public string CareType { get { return careType; } set {careType = value; } }
        public DateTime CareDate 
        { 
            get { return careDate; } 
            set { if(value.Year > DateTime.Now.Year)
                    throw new ArgumentException("Care date cannot be in the future.");
                careDate = value; }
        }
        //constructors of the class Care:
        public Care(string animal, string careType, DateTime careDate)
        {
            Animal = animal;
            CareType = careType;
            CareDate = careDate;
        }
        public Care(string line)
        {
            string[] distribution = line.Split(";");
            Animal = distribution[0];
            CareType = distribution[1];
            CareDate = DateTime.Parse(distribution[2]);
        }
        //method to demonstarte data for objects:
        public string showInfo()
        {
            return $"Animal: {Animal}, Care Type: {CareType}, Care Date: {CareDate.ToShortDateString()}";
        }
    }
}
