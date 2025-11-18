using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse
{
    internal class TwoBedroom : Room
    {
        public TwoBedroom() : base(2)
        {
            Rent = twobed;
        }

        public override void Moves(Room newRoom, int numMove) 
        {
            if (newRoom.Beds >= 1 && newRoom.Beds - newRoom.Occupants >= numMove)
            {
                Leaves(numMove);
                newRoom.Occupants += numMove;
                Rent = Occupants * twobed;
                newRoom.RentCalc();
            }
        }
        public override string ShowIt()
        {
            return $"In this two-bedroom appartment " + base.ShowIt();
        }
        public override void RentCalc()
        {
            if(Occupants <= 1)
            {
                Rent = Occupants * twobed;
            }
            else
            {
                Rent = twobed;
            }
        }
        
    }
}
