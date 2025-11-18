using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse 
{
    internal class OneBedroom : Room
    {
        public OneBedroom() : base(1)
        {
            Rent = onebed;
        }
        public override void Moves(Room newRoom, int numMove)
        {
            if (newRoom.Beds >= 2 && newRoom.Beds - newRoom.Occupants >= numMove)
            {
                Leaves(numMove);
                newRoom.Occupants += numMove;
                Rent = Occupants * onebed;
                newRoom.Occupants+=onebed;
                newRoom.RentCalc();
            }
        }
        public override string ShowIt()
        {
            return $"In this one-bedroom appartment " + base.ShowIt();
        }
        public override void RentCalc()
        {
            Rent = Occupants*onebed;
        }
    }
}
