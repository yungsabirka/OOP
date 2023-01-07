using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class ObjectWhoCanPairing : ObjectWhoCanEat
    {

        public void PairingAnimals(List<GameObject>[,] map)
        {
            var obj = (Animals)target;
            obj.Satiety = 0;
            obj.target = null;
            Satiety = 0;
            target = null;
            
            var newBornAnimal = this;
            ActionsOnMap.AddObject(this.Coordinate, map, newBornAnimal);
        }
        public bool PairingTargetTest(GameObject target)
        {
            if (Satiety == MaxSatiety)
            {
                if (target is not null)
                {
                    if (GetType() == target.GetType() && !ReferenceEquals(this, target))
                    {
                        var pairingTarget = (Animals)target;
                        return pairingTarget.Satiety == MaxSatiety;
                    }
                }
            }
            return false;
        }
    }
}
