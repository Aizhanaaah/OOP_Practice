using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Care
    {
        string animal, careType;
        DateTime careDate;
        public string Animal { get { return animal; } set { animal = value; } }
        public string CareType { get { return careType; } set {careType = value; } }
        public DateTime CareDate 
        { 
            get { return careDate; } 
            set { if(careDate.Year < 2025) 
                careDate = value; }
        }
        public Care(string animal, string careType, DateTime careDate)
        {
            Animal = animal;
            CareType = careType;
            CareDate = careDate;
        }
        string showInfo()
        {
            return $"Animal: {Animal}, Care Type: {CareType}, Care Date: {CareDate.ToShortDateString()}";
        }
    }
}
