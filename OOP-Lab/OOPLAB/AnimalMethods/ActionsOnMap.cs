using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class ActionsOnMap
    {
        public static void AddObject(Point newCoordinate, List<GameObject>[,] map, GameObject obj)
        {
            map[newCoordinate.X, newCoordinate.Y].Add(obj);
            obj.Coordinate = newCoordinate;
        }
        public static Animals DeleteObject(List<GameObject>[,] map, Animals animal)
        {
            map[animal.Coordinate.X, animal.Coordinate.Y].Remove(animal);
            return animal;
        }

    }
}
