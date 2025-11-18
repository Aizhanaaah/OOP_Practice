using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse
{
    internal class Room
    {
        public static int onebed;
        public static int twobed;
        static Room()
        {
            onebed = 800;
            twobed = 1200;
        }

        public int Rent { get; set; }
        public int Beds { get; }
        public int Occupants { get; set; }

        public Room(int beds)
        {
            Beds = beds;
            Occupants = beds;
        }
        public virtual string ShowIt()
        {
            return $"Rents: {Rent}, Occupants: {Occupants}";
        }
        public void Leaves(int numLeave)
        {
            Occupants -= numLeave;
            if (Occupants < 0)
            {
                Occupants = 0;
            }
        }
        public abstract void Moves(Room newRoom, int numMove);
        public abstract void RentCalc();

    }
}
        
       