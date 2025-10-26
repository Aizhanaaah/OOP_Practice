using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aizhan_s_delivery_Service
{
    enum Destination
    {
        Eclipsera, Hyperionex, Quantaflow, Infinitron, Synthara
    }
    internal class Deliver
    {
        public Destination D { get; set; }
        public int Distance { get; set; }

        public Deliver(Destination d, int distance)
        {
            D = d;
            Distance = distance;
        }
    }
}
