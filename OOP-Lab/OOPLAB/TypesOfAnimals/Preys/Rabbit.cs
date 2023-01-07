using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Rabbit : Preys
    {
        public Rabbit()
        {
            MaxSpeed = 3;
            MaxSatiety = 1;
            Saturability = 2;
            RadiusOfView = 60;
        }
    }
}
