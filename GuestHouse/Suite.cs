using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse
{
    internal class Suite : Room
    {
        public Suite(int beds) : base(beds)
        {
            Rent = twobed + (beds - 2) * onebed;
        }
        public override void Moves(Room newRoom, int numMove)
        {
            if (newRoom.Beds > 2 && newRoom.Beds - newRoom.Occupants >= numMove)
            {
                Console.Write("Nowhere to move!");
            }
        }
        public override string ShowIt()
        {
            return $"In this suite with {Beds} bedrooms " + base.ShowIt();
        }
        public override void RentCalc()
        {
            if (Occupants <= 1)
            {
                Rent = Occupants * onebed;
            }
            else
            {
                Rent = twobed + (Beds - 2) * onebed;
            }
        }
    }
}
