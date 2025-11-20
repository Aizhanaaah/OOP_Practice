using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo 
{
    internal class Predator : Animal, ICareTaking
    {
        public string feedType { get; set; }
        public string FeedType 
        { 
            get { return feedType; } 
            set 
            { 
                if(value == "Meat" || value == "Fish" || value == "Poultry") 
                    feedType = value; 
            }
        }
        public Predator(string name, string species, string caretaker, DateTime birthDate, string feedType)
            : base(name, species, caretaker, birthDate)
        {
            FeedType = feedType;
        }

        public override void AddCare()
        {
            Console.WriteLine($"Predator-specific care added for {Name}.");
        }

        public override void RemoveCare()
        {
            Console.WriteLine($"Predator-specific care removed for {Name}.");
        }
        public override string showInfo()
        {
            return base.showInfo() + $", Feed Type: {FeedType}";
        }
    }
}
