using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace OOPLAB
{
    abstract class Predators : Animals
    {
        private Preys EatingPreys(List<GameObject>[,] map)
        {

            if (target is not null)
                if (!map[Coordinate.X, Coordinate.Y].Contains(target))
                    target = null;
                else
                    ActionsOnMap.DeleteObject(map, (Animals)target);

            return (Preys) target;
        }

        public override void Eat(List<GameObject>[,] map)
        {
            var prey = EatingPreys(map);
            if (prey != null)
                Satiety += prey.Saturability;
            target = null;
        }
    }
}
